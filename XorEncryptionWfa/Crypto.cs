﻿using System;
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
        private Encoding Encoding { get; set; }

        /// <summary>
        /// Constructors to initialize a new instance of the Crypto class
        /// </summary>
        public Crypto(string key, Encoding encoding, HashAlgorithm hashAlgorithm)
        {
            this.Encoding = encoding;
            this.Key = Encoding.GetBytes(key).Where(b => b != 0).ToArray();
            HashAlgorithm = hashAlgorithm;
        }

        public Crypto(string key)
            : this(key, Encoding.UTF8, HashAlgorithm.Create("MD5"))
        {
            return;
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
        /// <param name="fileContents">The file path of the file to be processed.</param>
        /// <returns></returns>
        public string GenerateHash(string fileContents)
        {
            byte[] fileContentsBytes = Encoding.GetBytes(fileContents);
            string hashBase64 = Convert.ToBase64String(HashAlgorithm.ComputeHash(fileContentsBytes));
            return hashBase64;
        }

        public string ExtractHash(string fileContents)
        {
            return fileContents.Substring(fileContents.Length - 24);
        }
    }
}