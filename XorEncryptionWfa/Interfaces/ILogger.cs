namespace XorEncryptionWfa
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogOutput(string message);
        void LogError(string message);
    }
}