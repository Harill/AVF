
namespace Vfi.Client.Module.Authentication.Interfaces
{
    public interface IFormAuthenticationService
    {
        void SignIn(string userName, bool createPersistentCookie);

        void SignOut();
    }
}
