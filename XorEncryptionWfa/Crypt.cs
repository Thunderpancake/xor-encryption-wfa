using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XorEncryptionWfa
{
    public class Crypt
    {
        private readonly IReadTextFile _readTextFile;
        private readonly IWriteTextFile _writeTextFile;
        private readonly ILogger _logger;

        public Crypt(ILogger logger)
        {
            _logger = logger;
        }

        public Crypt(ILogger logger, IReadTextFile readTextFile, IWriteTextFile writeTextFile)
            :this(logger)
        {
            _readTextFile = readTextFile;
            _writeTextFile = writeTextFile;
        }

        public void XorConsole(string message, string key)
        {
            var messageChars = message.ToCharArray();
            var keyChars = key.ToCharArray();
            var cipherChars = new List<char>();
            var cipherText = new StringBuilder();

            for (int i = 0; i < messageChars.Count(); i++)
            {
                cipherChars.Add((char)(messageChars[i] ^ keyChars[i % keyChars.Count()]));
            }

            foreach (var cipherChar in cipherChars)
            {
                int value = Convert.ToInt32(cipherChar);
                cipherText.Append(String.Format("{0:D3}", value));
            }

            _logger.LogOutput(cipherText.ToString());
        }

        public void XorFile(string path, string key)
        {
            
        }
    }
}