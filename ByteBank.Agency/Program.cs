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

namespace ByteBank.Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test
            //Client client1 = new Client(name: "João", occupation: "Developer", cpf: "225846589-54");
            //Account account1 = new Account(client1, agencyNumber: 123, accountNumber: 456789, balance: 1000);

            //Auxiliary auxiliary1 = new Auxiliary("José", cpf: "224159753-64");

            //Director director1 = new Director(name: "Sthevan", cpf: "229852159-74");


            #endregion

            #region Var

            //var idades = new List<int>();
            //var names = new List<string>();

            //names.AddVarious("a", "c", "j", "s", "b");
            //names.Sort();

            //idades.Add(10);


            //idades.AddVarious(15, 25, 3, 45, 5);
            //idades.Sort();



            //foreach (var item in idades)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}




            //var account = new Account();

            //account.Deposit(1500);




            #endregion

            #region Test Var, Sort, OrderBy, Lambda, Linq

            Client client1 = new Client(name: "João", occupation: "Developer", cpf: "225846589-54");
            Client client2 = new Client(name: "Maria", occupation: "Developer", cpf: "225846589-54");
            Client client3 = new Client(name: "Alex", occupation: "Developer", cpf: "225846589-54");
            Client client4 = new Client(name: "Pedro", occupation: "Developer", cpf: "225846589-54");

            Account account1 = new Account(client1, agencyNumber: 123, accountNumber: 456785, balance: 1000);
            Account account2 = new Account(client2, agencyNumber: 123, accountNumber: 456781, balance: 1000);
            Account account3 = new Account(client3, agencyNumber: 123, accountNumber: 456784, balance: 1000);
            Account account4 = new Account(client4, agencyNumber: 123, accountNumber: 456780, balance: 1000);

            var accounts = new List<Account>();
            accounts.Add(account1);
            accounts.Add(account2);
            accounts.Add(account3);
            accounts.Add(null);
            accounts.Add(account4);

            //accounts.Sort();

            //foreach (var item in accounts)
            //{
            //    Console.WriteLine(item);
            //}

            //var orderAccount = accounts.OrderBy(account =>
            //{
            //    if (account != null)
            //    {
            //    return account.AccountNumber;
            //    }
            //});
            var orderAccount = accounts.Where(account => account != null).OrderBy(account => account.Holder.Name);

            

            foreach (var item in orderAccount)
            {
                Console.WriteLine(item);
            }

            #endregion


            Console.ReadKey();
        }


    }
}
