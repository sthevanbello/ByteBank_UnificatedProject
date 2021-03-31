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
            Account account1 = new Account(client1, agencyNumber: 123, accountNumber: 126456, balance: 1000);

            Auxiliary auxiliary1 = new Auxiliary("José", cpf: "224159753-64");

            Director director1 = new Director(name: "Sthevan", cpf: "229852159-74");

            #endregion

            #region Test Extract value
            //string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";

            //ExtractValueArgumentsURL extractValues = new ExtractValueArgumentsURL(url);

            //string term1 = "moedaOrigem";

            //string extracted = extractValues.GetValue(term1);

            //Console.WriteLine("Moeda de origem: " + extracted);

            //string term2 = "moedaDestino";
            //string extracted2 = extractValues.GetValue(term2);
            //Console.WriteLine("Moeda de destino: " + extracted2);
            #endregion

            #region StartsWith EndsWith Contains

            //string urlTest = "http://www.bytebank.com/cambio";
            //int indiceByteBank = urlTest.IndexOf("http://www.bytebank.com");

            //Console.WriteLine(indiceByteBank == 0);

            //Console.WriteLine(urlTest.StartsWith("http://www.bytebank.com"));
            //Console.WriteLine(urlTest.EndsWith("cambio"));
            #endregion

            #region Patterns

            //            string padrao =
            //"[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";

            //            string padrao2 = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //            string padrao3 = "[0-9]{4}[-][0-9]{4}";
            //            string padrao4 = "[0-9]{4,5}[-][0-9]{4,5}";
            //            string padrao5 = "[0-9]{4,5}[-]{0,1}[0-9]{4,5}";
            //            string padrao6 = "[0-9]{4,5}-{0,1}[0-9]{4,5}";
            //            string padrao7 = "[0-9]{4,5}-?[0-9]{4,5}";

            //            string textoDeTeste = "Meu nome é Guilherme, me ligue em 94784-4546";
            //            string textoDeTeste2 = "Meu nome é Guilherme, me ligue em 947844546";

            //            Match resultado = Regex.Match(textoDeTeste, padrao);
            //            Match resultado2 = Regex.Match(textoDeTeste, padrao2);
            //            Match resultado3 = Regex.Match(textoDeTeste, padrao3);
            //            Match resultado4 = Regex.Match(textoDeTeste, padrao4);
            //            Match resultado5 = Regex.Match(textoDeTeste2, padrao5);
            //            Match resultado6 = Regex.Match(textoDeTeste, padrao6);
            //            Match resultado7 = Regex.Match(textoDeTeste2, padrao6);
            //            Match resultado8 = Regex.Match(textoDeTeste, padrao7);
            //            Match resultado9 = Regex.Match(textoDeTeste2, padrao7);

            //            Console.WriteLine(resultado.Value);
            //            Console.WriteLine(resultado2.Value);
            //            Console.WriteLine(resultado3.Value);
            //            Console.WriteLine(resultado4.Value);
            //            Console.WriteLine(resultado5.Value);
            //            Console.WriteLine(resultado6.Value);
            //            Console.WriteLine(resultado7.Value);
            //            Console.WriteLine(resultado8.Value);
            //            Console.WriteLine(resultado9.Value);


            #endregion

            #region Class object

            //object conta = new Account(client1, agencyNumber: 123, accountNumber: 126456, balance: 1000);
            //Console.WriteLine(conta);


            #endregion

            #region Equals

            Client client2 = null; /*new Client(name: "João", occupation: "Developer", cpf: "225846589-54");*/


            Console.WriteLine(client1 == client2);
            try
            {
                if (client1.Equals(client2))
                {
                    Console.WriteLine("Equals");
                }
                else
                {
                    Console.WriteLine("Different");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            #endregion


            Console.ReadKey();
        }
    }
}
