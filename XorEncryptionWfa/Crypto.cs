using System;
using System.Linq;
using System.Text;

namespace XorEncryptionWfa
{
    public class Crypto
    {
        public string Path { get; set; }
        private byte[] Key { get; set; }
        private UTF8Encoding Encoding { get; set; }

        /// <summary>
        /// Constructors to initialize a new instance of the Crypto class
        /// </summary>
        public Crypto(string key)
        {
            this.Encoding = new UTF8Encoding(true);
            this.Key = Encoding.GetBytes(key).Where(b => b != 0).ToArray();
        }

        /// <summary>
        /// Encrypts the plain text with a XOR calcuation into Base64
        /// </summary>
        /// <param name="plainText">The unencrypted plain text passed in</param>
        /// <returns></returns>
        public string Encrypt(string plainText)
        {
            int i = 0;
            byte[] octets = Encoding.GetBytes(plainText).Select(b => (byte)(b ^ Key[(++i) % Key.Length])).ToArray();
            string cipherText = Convert.ToBase64String(octets);
            return cipherText;
        }

        /// <summary>
        /// Decrypts the cipher text by converting back from base 64, performing the XOR operation, and converts back to the proper Encoding
        /// </summary>
        /// <param name="cipherText">XOR encrypted cipher text.</param>
        /// <returns></returns>
        public string Decrypt(string cipherText)
        {
            int i = 0;
            byte[] octets = Convert.FromBase64String(cipherText).Select(b => (byte)(b ^ Key[(++i) % Key.Length])).ToArray();
            string plainText = Encoding.GetString(octets);
            return plainText;
        }
    }
}