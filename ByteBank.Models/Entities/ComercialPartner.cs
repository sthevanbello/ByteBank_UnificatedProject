using ByteBank.Models.System;
using ByteBank.System;


namespace ByteBank.Entities
{
    public class ComercialPartner : IAuthenticable
    {
        private AuthenticationHelper _authenticationHelper = new AuthenticationHelper();
        public string Password { get; set; }

        public bool Authenticate(string password)
        {
            return _authenticationHelper.PasswordCompare(Password, password);
        }
    }
}
