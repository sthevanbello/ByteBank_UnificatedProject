using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Employees
{
    class Designer : Employee
    {
        public Designer(string name, string cpf) : base(name, cpf, 3000)
        {
            
        }
        public override double GetBonification()
        {
            return Salary * 0.17;
        }

        public override void PlusSalary()
        {
            Salary *= 1.11;
        }
    }
}
