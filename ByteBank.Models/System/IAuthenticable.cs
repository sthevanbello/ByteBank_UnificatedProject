
namespace ByteBank.System
{
    public interface IAuthenticable
    {
        string Password { get; set; }

        bool Authenticate(string password);

    }
}
