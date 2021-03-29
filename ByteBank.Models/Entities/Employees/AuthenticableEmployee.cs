using ByteBank.Models.System;
using ByteBank.System;


namespace ByteBank.Entities.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticable
    {
        private AuthenticationHelper _authenticationHelper = new AuthenticationHelper();
        public string Password { get; set; }

        public AuthenticableEmployee(string name, string cpf, double salary) : base(name, cpf, salary)
        {
        }

        public bool Authenticate(string password)
        {
            return _authenticationHelper.PasswordCompare(Password, password);
        }
    }
}
