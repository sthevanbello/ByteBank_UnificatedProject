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
using System.Globalization;

namespace ByteBank.Agency
{
    partial class Program
    {
       static void MakeFile()
        {
            var filePathNewFile = "accountExport.csv";

            using (var fileStream = new FileStream(filePathNewFile, FileMode.Create))
            {
                var accountString = "456,78495,4785.50,Gustavo Santos";

                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(accountString);

                fileStream.Write(bytes, 0, bytes.Length);

                Console.WriteLine("File maked");

            }

            
        }
        private static void makeUsingStreamWriter()
        {
            string filePath = "accountExport.csv";

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            using (var streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
            {
                streamWriter.WriteLine("456,78495,4785.50,Gustavo Santos");
            }
            
        }
    }


}