using ByteBank.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Employees
{
    public class Director : AuthenticableEmployee
    {
        public Director(string name, string cpf) : base(name, cpf, 5000)
        {
        }

        internal protected override double GetBonification()
        {
            return Salary * 0.5;
        }

        public override void PlusSalary()
        {
            Salary *= 1.15;
        }
    }
}
