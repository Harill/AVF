using System;
using System.Web.Security;
using Vfi.Client.Module.Authentication.Interfaces;

namespace Vfi.Client.Module.Authentication.Services
{
    public class FormAuthenticationService : IFormAuthenticationService
    {
        public void SignIn(string userName, bool createPersistentCookie)
        {
            if (String.IsNullOrEmpty(userName)) throw new ArgumentException("Value cannot be null or empty.", "userName");
            
            FormsAuthentication.SetAuthCookie(userName, createPersistentCookie);
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}
