using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Agency
{
    partial class Program
    {
        static void UsingInputStream()
        {
            using (var inputStream = Console.OpenStandardInput())
            using (var fileStream = new FileStream("InputConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024];

                while (true)
                {
                    var readBytes = inputStream.Read(buffer, 0, 1024);

                    fileStream.Write(buffer, 0, readBytes);
                    fileStream.Flush();

                    Console.WriteLine($"Read bytes - {readBytes}");
                }

            }
        }
    }
}
