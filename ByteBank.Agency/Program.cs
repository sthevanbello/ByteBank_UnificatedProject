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

namespace ByteBank.Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test
            Client client1 = new Client(name: "João", occupation: "Developer", cpf: "225846589-54");
            Account account1 = new Account(client1, agencyNumber: 123, accountNumber: 456789, balance: 1000);

            Auxiliary auxiliary1 = new Auxiliary("José", cpf: "224159753-64");

            Director director1 = new Director(name: "Sthevan", cpf: "229852159-74");


            #endregion

            Console.ReadKey();
        }


    }
}
