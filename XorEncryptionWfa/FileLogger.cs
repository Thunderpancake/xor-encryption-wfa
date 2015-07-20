using System;
using System.IO;

namespace XorEncryptionWfa
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        private void Log(string message, string messageType)
        {
            try
            {
                using (var streamWriter = new StreamWriter(_path, false))
                {
                    streamWriter.WriteLine(messageType + ": " + message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            }
        }
        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        public void LogOutput(string message)
        {
            Log(message, "OUTPUT");
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }
    }
}