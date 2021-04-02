using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Entities.Employees;
using ByteBank.Entities;
using ByteBank.Exceptions;
using ByteBank.Models;
using ByteBank.Models.System;
using Humanizer;
using System.Text.RegularExpressions;
using ByteBank.Agency.Extensions;
using System.IO;

namespace ByteBank.Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "contas.txt";

            #region FileStream
            //using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            //{
            //    try
            //    {
            //        byte[] buffer = new byte[1024];
            //        int readBytes = -1;

            //        while (readBytes != 0)
            //        {
            //            readBytes = fileStream.Read(buffer, 0, 1024);
            //            WriterBuffer(buffer, readBytes);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            #endregion

            #region WriterBuffer
            //static void WriterBuffer(byte[] buffer, int readBytes)
            //{
            //    Encoding utf8 = Encoding.UTF8;
            //    string text = utf8.GetString(buffer, 0, readBytes);

            //    Console.Write(text);
            //}
            #endregion
            




            Console.ReadKey();
        }

        

        
    }
}
