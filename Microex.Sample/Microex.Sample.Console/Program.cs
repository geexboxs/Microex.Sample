using Microex.Sample.Console.Microex.Common;
using System;

namespace Microex.Sample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            EncryptionSample encryptionSample = new EncryptionSample();
            encryptionSample.ComputeMd5Test();
        }
    }
}
