using ByteBank.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities
{
    static class BonificationManager
    {
        private static double _totalBonification;
        public static void Register(Employee employee)
        {
            _totalBonification += employee.GetBonification();
        }
       

        public static double GetTotalBonification()
        {
            return _totalBonification;
        }
    }
}
