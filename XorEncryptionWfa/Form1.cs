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
            ofd.InitialDirectory = @"C:\";
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
                var crypto = new Crypto(KeyBoxFile.Text);
                using (StreamReader sr = new StreamReader(FilePathBox.Text))
                {
                    using (
                        StreamWriter sw =
                            new StreamWriter(Path.Combine(Path.GetDirectoryName(FilePathBox.Text),
                                    Path.GetFileNameWithoutExtension(FilePathBox.Text) + "Encrypted" + ".txt")))
                    {
                        sw.WriteLine(crypto.Encrypt(sr.ReadToEnd()));
                    }
                }
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
                var crypto = new Crypto(KeyBoxFile.Text);
                using (StreamReader sr = new StreamReader(FilePathBox.Text))
                {
                    using (
                        StreamWriter sw =
                            new StreamWriter(Path.Combine(Path.GetDirectoryName(FilePathBox.Text),
                                    Path.GetFileNameWithoutExtension(FilePathBox.Text) + "Decrypted" + ".txt")))
                    {
                        sw.WriteLine(crypto.Decrypt(sr.ReadToEnd()));
                    }
                }
            }
        }
    }
}
