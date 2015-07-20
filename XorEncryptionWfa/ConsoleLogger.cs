using System;

namespace XorEncryptionWfa
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message, string messageType)
        {
            try
            {
                Console.WriteLine(messageType + ": " + message);
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