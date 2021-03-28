using ByteBank.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities
{
    public class ComercialPartner : IAuthenticable
    {
        public string Password { get; set; }

        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
