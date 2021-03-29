using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Employees
{
    public abstract class Employee
    {
        public static int TotalEmployee { get; private set; }
        public string Name { get; set; }
        protected string CPF { get; set; }
        public double Salary { get; protected set; }



        public Employee(string name, string cpf, double salary)
        {
            Name = name;
            CPF = cpf;
            Salary = salary;
            TotalEmployee++;
        }

        public Employee()
        {
            TotalEmployee++;
        }

        internal protected abstract double GetBonification();
        public abstract void PlusSalary();
    }
}