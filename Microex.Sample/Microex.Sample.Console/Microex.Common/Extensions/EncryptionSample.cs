using Microex.Common.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Microex.Sample.Console.Microex.Common
{
    public class EncryptionSample
    {
        public void ComputeMd5Test()
        {
            //string
            string testString = "123";
            string stringComputValue=testString.ComputeMd5();

            //byte[]
            string rootPath = Directory.GetCurrentDirectory();
            string path = rootPath + "\\Microex.Common\\Extensions\\Pictures\\cat.jpg";
            FileStream stream = new FileStream(path, FileMode.Open);
            //Position should be reset to 0
            //Position应该被重置为0
            stream.Position = 0;
            MemoryStream ms = new MemoryStream();
            stream.CopyTo(ms);
            byte[] bytes = ms.ToArray();
            string byteComputValue = bytes.ComputeMd5();
        }
    }
}
