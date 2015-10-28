using System;
using System.Security.Cryptography;
using System.Text;

namespace XorEncryptionWfa
{
    public static class Hasher
    {
        /// <summary>
        /// Calculate hash.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="inputBytes"></param>
        /// <returns></returns>
        public static byte[] Hash(HashAlgorithm algorithm, byte[] inputBytes)
        {
            return algorithm.ComputeHash(inputBytes);
        }

        /// <summary>
        /// Calculates the hash of the text file before encrypting it.
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="fileContents">The contents of the file to be processed.</param>
        /// <returns></returns>
        public static string GenerateBase64Hash(HashAlgorithm algorithm, string fileContents)
        {
            byte[] fileContentsBytes = Encoding.UTF8.GetBytes(fileContents);
            return Convert.ToBase64String(Hash(algorithm, fileContentsBytes));
        }

        /// <summary>
        /// Extracts hash out of encrypted file.
        /// </summary>
        /// <param name="fileContents"></param>
        /// <returns></returns>
        public static string ExtractHash(string fileContents)
        {
            return fileContents.Substring(fileContents.Length - 24);
        }
        /// <summary>
        /// Check if decrypted hash matches original
        /// </summary>
        /// <param name="decryptedHash"></param>
        /// <param name="originalHash"></param>
        /// <returns></returns>
        public static bool VerifyHash(string decryptedHash, string originalHash)
        {
            return decryptedHash == originalHash;
        }
    }
}