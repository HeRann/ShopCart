using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace UserInterface.Security
{
    public class CustomPrincipal : IPrincipal
    {
        public CustomPrincipal(string userName)
        {
            this.Identity = new GenericIdentity(userName);
        }
        public IIdentity Identity { get; private set; }

        public bool IsInRole(string role)
        {
            if (roles.Any(r => role.Contains(r)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public int userId { get; set; }

        public string userName { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }

        public string addressLine1 { get; set; }

        public string addressLine2 { get; set; }

        public string addressLine3 { get; set; }

        public string password { get; set; }

        public string contactNumber { get; set; }

        public string[] roles { get; set; }
    }
}