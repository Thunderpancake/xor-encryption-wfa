using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace XorEncryptionWfa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(KeyBox.Text))
            {
                MessageBox.Show("You must enter a key!");
            }
            else
            {
                var crypto = new Crypto(KeyBox.Text);
                OutputBox.Text = crypto.Encrypt(InputBox.Text);
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(KeyBox.Text))
            {
                MessageBox.Show("You must enter a key!");
            }
            else
            {
                var crypto = new Crypto(KeyBox.Text);
                OutputBox.Text = crypto.Decrypt(InputBox.Text);
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Ryan\Desktop\";
            ofd.Filter = @"Text Files|*.txt|All|*.*";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FilePathBox.Text = ofd.FileName;
            }
        }

        private void EncryptFileButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(KeyBoxFile.Text) || string.IsNullOrWhiteSpace(FilePathBox.Text))
            {
                MessageBox.Show("You must enter a key!");
            }
            else
            {
                ResultsTextBox.AppendText("Encrypting...\n");
                var crypto = new Crypto(KeyBoxFile.Text);
                string fileContents;
                using (StreamReader sr = new StreamReader(FilePathBox.Text))
                {
                    fileContents = sr.ReadToEnd();
                }
                using (
                        StreamWriter sw =
                            new StreamWriter(Path.Combine(Path.GetDirectoryName(FilePathBox.Text),
                                    Path.GetFileNameWithoutExtension(FilePathBox.Text) + "Encrypted" + ".txt")))
                {
                    sw.Write(crypto.Encrypt(fileContents));
                    sw.Write(Hasher.GenerateBase64Hash(MD5.Create(), fileContents));
                }
                ResultsTextBox.AppendText("Encryption complete.\n");
            }
        }

        private void DecryptFileButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(KeyBoxFile.Text) || string.IsNullOrWhiteSpace(FilePathBox.Text))
            {
                MessageBox.Show("You must enter a key!");
            }
            else
            {
                ResultsTextBox.AppendText("Decrypting...\n");
                var crypto = new Crypto(KeyBoxFile.Text);
                string fileContents;
                string extractedHash;
                string decryptedHash;
                using (StreamReader sr = new StreamReader(FilePathBox.Text))
                {
                    fileContents = sr.ReadToEnd();
                }
                extractedHash = Hasher.ExtractHash(fileContents);
                ExtractedHashBox.Text = extractedHash;
                fileContents = fileContents.Substring(0, fileContents.Length - 24);
                var utf8WithBom = new UTF8Encoding(true);
                using (
                        StreamWriter sw =
                            new StreamWriter(Path.Combine(Path.GetDirectoryName(FilePathBox.Text),
                                    Path.GetFileNameWithoutExtension(FilePathBox.Text) + "Decrypted" + ".txt"), false, utf8WithBom))
                {
                    sw.Write(crypto.Decrypt(fileContents));
                }
                using (StreamReader sr = new StreamReader(Path.Combine(Path.GetDirectoryName(FilePathBox.Text), Path.GetFileNameWithoutExtension(FilePathBox.Text) + "Decrypted" + ".txt")))
                {
                    fileContents = sr.ReadToEnd();
                }
                decryptedHash = Hasher.GenerateBase64Hash(MD5.Create(), fileContents);
                ResultsTextBox.AppendText("Decryption complete.\n");
                ResultsTextBox.AppendText(string.Format("Decrypted Hash: {0}\n", decryptedHash));
                ResultsTextBox.AppendText(string.Format("Extracted Hash: {0}\n", extractedHash));
                if (Hasher.VerifyHash(decryptedHash, extractedHash))
                {
                    ResultsTextBox.AppendText("Hashes match!  Successful decryption.\n");
                }
                else
                {
                    ResultsTextBox.AppendText("Hashes do not match!  Unsuccessful decryption.\n");
                }
            }
        }
    }
}
