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
            Client client2 = new Client(name: "José", occupation: "Developer", cpf: "225846589-53");
            Client client3 = new Client(name: "Maria", occupation: "Developer", cpf: "225846589-52");
            Client client4 = new Client(name: "Léo", occupation: "Developer", cpf: "225846589-51");
            Client client5 = new Client(name: "Bruce", occupation: "Developer", cpf: "225846589-50");
            Account account1 = new Account(client1, agencyNumber: 123, accountNumber: 456789, balance: 1000);
            Account account2 = new Account(client2, agencyNumber: 123, accountNumber: 126456, balance: 1500);
            Account account3 = new Account(client3, agencyNumber: 123, accountNumber: 123789, balance: 2000);
            Account account4 = new Account(client4, agencyNumber: 123, accountNumber: 456123, balance: 500);
            Account account5 = new Account(client5, agencyNumber: 123, accountNumber: 789123, balance: 1750);
           
            Auxiliary auxiliary1 = new Auxiliary("José", cpf: "224159753-64");

            Director director1 = new Director(name: "Sthevan", cpf: "229852159-74");

            #endregion

            AccountList list = new AccountList();

            list.AddAccount(account1);
            list.AddAccount(account2);
            list.AddAccount(account3);
            list.AddAccount(account4);
            list.AddAccount(account5);
            list.AddAccount(account5);
            list.AddAccount(account5);

            foreach (var item in list.ReturnList())
            {
                Console.WriteLine($"Name: {item.Holder.Name} - Agency number: {item.AgencyNumber} - Account number: {item.AccountNumber} - Balance: {item.GetBalance():C}");
            }

            Console.ReadKey();
        }
    }
}
