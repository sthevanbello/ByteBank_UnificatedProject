using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Agency
{
    public static class ListExtensions
    {
        public static void AddVarious(this List<int> listInteger, params int[] items)
        {
            foreach (int item in items)
            {
                listInteger.Add(item);
            }
        }
    }
}
