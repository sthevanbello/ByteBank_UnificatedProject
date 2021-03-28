using ByteBank.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticable
    {
        public string Password { get; set; }

        public AuthenticableEmployee(string name, string cpf, double salary) : base(name, cpf, salary)
        {
        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
