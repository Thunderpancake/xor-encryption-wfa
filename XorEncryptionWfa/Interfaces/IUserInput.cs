namespace XorEncryptionWfa
{
    public interface IUserInput
    {
        void RequestFilePath();
        void RequestKey();
        void VerifyKeyNotNull();
    }
}