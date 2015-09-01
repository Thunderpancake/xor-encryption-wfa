using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ofd.InitialDirectory = @"C:\Desktop";
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
                    sw.Write(crypto.GenerateBase64Hash(fileContents));
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
                ExtractedHashBox.Text = crypto.ExtractHash(fileContents);
                extractedHash = crypto.ExtractHash(fileContents);
                fileContents = fileContents.Substring(0, fileContents.Length - 24);
                decryptedHash = crypto.GenerateHash(fileContents);
                using (
                        StreamWriter sw =
                            new StreamWriter(Path.Combine(Path.GetDirectoryName(FilePathBox.Text),
                                    Path.GetFileNameWithoutExtension(FilePathBox.Text) + "Decrypted" + ".txt")))
                {
                    sw.Write(crypto.Decrypt(fileContents));
                }
                ResultsTextBox.AppendText("Decryption complete.\n");
                ResultsTextBox.AppendText(string.Format("Decrypted Hash: {0}\n", decryptedHash));
                ResultsTextBox.AppendText(string.Format("Extracted Hash: {0}\n", extractedHash));
                if (crypto.VerifyHash(decryptedHash, extractedHash))
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
