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
        static void Main(string[] args)
        {
            string filePath = "contas.txt";

            var linhas = File.ReadAllLines(filePath);

            var bytesFile = File.ReadAllBytes(filePath);

            Console.WriteLine($"{bytesFile.Length} bytes");

            File.WriteAllText("writeTextFile.txt", "testWriter");

            //foreach (var item in linhas)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }

        
    }
}
