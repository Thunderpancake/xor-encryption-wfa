using System.Collections.Generic;

namespace XorEncryptionWfa
{
    public interface IReadTextFile
    {
        List<char> ReturnCharList(string path);
        List<byte> ReturnByteList(string path);
    }
}