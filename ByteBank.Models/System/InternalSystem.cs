using ByteBank.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.System
{
    public class InternalSystem
    {
        public bool Login(IAuthenticable employee, string password)
        {
            bool autenticatedUser = employee.Authenticate(password);

            if (autenticatedUser)
            {
                Console.WriteLine("Wellcome to the system");
                return true;
            }
            Console.WriteLine("Access denied");
            return false;
        }

        
    }
}
