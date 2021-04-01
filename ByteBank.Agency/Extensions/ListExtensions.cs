using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Agency.Extensions
{
    public static class ListExtensions
    {
        public static void AddVarious<T>(this List<T> list, params T[] items)
        {
            foreach (T item in items)
            {
                list.Add(item);
            }
        }

        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(14);
            idades.Add(26);
            idades.Add(60);

            idades.AddVarious<int>(1, 2, 3, 4, 5);

            List<string> argumentos = new List<string>();
            argumentos.Add("teste1");
            argumentos.Add("teste2");
            argumentos.Add("teste3");
            argumentos.Add("teste4");

            argumentos.AddVarious("a", "b", "c");


        }
    }
}
