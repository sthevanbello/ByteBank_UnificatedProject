using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Employees
{
    class Auxiliary : Employee
    {
        public Auxiliary(string name, string cpf) : base(name, cpf, 2000)
        {
            
        }

        public override double GetBonification()
        {
            return Salary * 0.2;
        }

        public override void PlusSalary()
        {
            Salary *= 1.1;
        }
    }
}
