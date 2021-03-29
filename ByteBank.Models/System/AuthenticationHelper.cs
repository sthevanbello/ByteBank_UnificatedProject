using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Models.System
{
    /*internal*/ class AuthenticationHelper
    {
        
        // When the access modifier is not placed, the class is internal
        public bool PasswordCompare(string passwordTrue, string passwordTry)
        {
            return passwordTrue == passwordTry;
        }
    }
}
