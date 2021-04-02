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
        static void FileBinaryWriter()
        {

            using (var fileStream = new FileStream("accountBinary.txt", FileMode.Create))
            using (var binaryWriter = new BinaryWriter(fileStream))
            {
                binaryWriter.Write(456); // Agency number
                binaryWriter.Write(546544); // Account number
                binaryWriter.Write(4000.50); // Balance
                binaryWriter.Write("Gustavo Braga"); // Name

            }

        }

        static void ReadBinary()
        {

            using (var fileStream = new FileStream("accountBinary.txt", FileMode.Open))
            using (var binaryReader = new BinaryReader(fileStream))
            {
                var agencyNumber = binaryReader.ReadInt32();
                var accountNumber = binaryReader.ReadInt32();
                var balance = binaryReader.ReadDouble();
                var name = binaryReader.ReadString();

                Console.WriteLine($"{name} - {agencyNumber} - {accountNumber} - {balance}");
            }

        }

    }
}
