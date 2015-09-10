using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace XorEncryptionWfa
{
    public class Crypto
    {
        private HashAlgorithm HashAlgorithm { get; set; }
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
            HashAlgorithm = HashAlgorithm.Create("MD5");
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

        /// <summary>
        /// Calculates the hash of the text file before encrypting it.
        /// </summary>
        /// <param name="fileContents">The contents of the file to be processed.</param>
        /// <returns></returns>
        public string GenerateBase64Hash(string fileContents)
        {
            byte[] fileContentsBytes = Encoding.GetBytes(fileContents);
            string hashBase64 = Convert.ToBase64String(HashAlgorithm.ComputeHash(fileContentsBytes));
            return hashBase64;
        }

        public string GenerateHash(string fileContents)
        {
            byte[] fileContentsBytes = Encoding.GetBytes(fileContents);
            byte[] data = HashAlgorithm.ComputeHash(fileContentsBytes);
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
            //return Encoding.GetString(HashAlgorithm.ComputeHash(fileContentsBytes));
        }

        /// <summary>
        /// Extracts the embedded hash from the encrypted file that was generated on the orignal file before encryption
        /// </summary>
        /// <param name="fileContents">The contents of the encrypted file.</param>
        /// <returns></returns>
        public string ExtractHash(string fileContents)
        {
            string hashBase64 = fileContents.Substring(fileContents.Length - 24);
            byte[] hashBase64Bytes = Convert.FromBase64String(hashBase64);
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < hashBase64Bytes.Length; i++)
            {
                sBuilder.Append(hashBase64Bytes[i].ToString("x2"));
            }
            return sBuilder.ToString();
            //string hash = Encoding.GetString(hashBase64Bytes);
            //return hash;
            //return fileContents.Substring(fileContents.Length - 24);
        }

        public bool VerifyHash(string decryptedHash, string originalHash)
        {
            return decryptedHash == originalHash;
        }
    }
}