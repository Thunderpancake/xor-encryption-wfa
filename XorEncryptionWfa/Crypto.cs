using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XorEncryptionWfa
{
    public class Crypto
    {
        public string Path { get; set; }
        private byte[] Key { get; set; }
        private Encoding Encoding { get; set; }

        public Crypto(string key, Encoding encoding)
        {
            this.Encoding = encoding;
            this.Key = Encoding.GetBytes(key).Where(b => b != 0).ToArray();
        }

        public Crypto(string key)
            : this(key, Encoding.UTF8)
        {
            return;
        }

        public Crypto(string key, string path)
            : this(key, Encoding.UTF8)
        {
            this.Path = path;
        }

        public string Encrypt(string plainText)
        {
            int i = 0;
            byte[] octets = Encoding.GetBytes(plainText).Select(b => (byte)(b ^ Key[(++i) % Key.Length])).ToArray();
            string cipherText = Convert.ToBase64String(octets);
            return cipherText;
        }

        public string Decrypt(string cipherText)
        {
            int i = 0;
            byte[] octets = Convert.FromBase64String(cipherText).Select(b => (byte)(b ^ Key[(++i) % Key.Length])).ToArray();
            string plainText = Encoding.GetString(octets);
            return plainText;
        }
    }
}