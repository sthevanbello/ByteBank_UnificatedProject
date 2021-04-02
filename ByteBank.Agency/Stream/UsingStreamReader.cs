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
        static void UseStreamReader()
        {
            string filePath = "contas.csv";

            List<Account> listAccount = new List<Account>();
            using (var fileStream = new FileStream(filePath, FileMode.Open))
            using (var streamReader = new StreamReader(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    //Console.WriteLine(line);
                    listAccount.Add(ConvertToAccount1(line));
                }
            }
            var orderList = listAccount.OrderBy(l => l.Holder.Name);

            foreach (var item in orderList)
            {
                Console.WriteLine(item);
            }
        }

        private static Account ConvertToAccount1(string line)
        {
            string[] fields = line.Split(',');
            int agencyNumber = int.Parse(fields[0]);
            int AccountNumber = int.Parse(fields[1]);
            double balance = double.Parse(fields[2], CultureInfo.InvariantCulture);
            string name = fields[3];
            return new Account(new Client(name), agencyNumber, AccountNumber, balance);
        }
    }


}