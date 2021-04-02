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
        static void TestWriter()
        {
            var filePath = "teste.txt";

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            using (var streamWriter = new StreamWriter(fileStream))
            {
                for (int i = 0; i < 10; i++)
                {
                    streamWriter.WriteLine($"Linha {i}");
                    streamWriter.Flush(); // Dumps the buffer into the Stream

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para adicionar mais uma!");
                    Console.ReadLine();
                }
            }
        }
    }
}

