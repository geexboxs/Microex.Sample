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

            //Stream
            string rootPath = Directory.GetCurrentDirectory();
            string path = rootPath + "\\Microex.Common\\Extensions\\Pictures\\cat.jpg";
            FileStream stream = new FileStream(path, FileMode.Open);
            string streamComputValue = stream.ComputeMd5();

            //byte[]
            //Position should be reset to 0
            //Position应该被重置为0
            stream.Position = 0;
            MemoryStream ms = new MemoryStream();
            stream.CopyTo(ms);
            byte[] bytes = ms.ToArray();

            //byte[] bytes=new byte[stream.Length];
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    int read;
            //    while ((read = stream.Read(bytes, 0, bytes.Length)) > 0)
            //    {
            //        ms.Write(bytes, 0, read);
            //    }
            //    bytes = ms.ToArray();
            //}
            string byteComputValue = bytes.ComputeMd5();

            //check if byteComputValue==streamComputValue(same picture)  
            //核对同一图片的MD5码是否相同
            bool isCorrect = streamComputValue == byteComputValue;
        }
    }
}
