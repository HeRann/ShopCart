using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.ViewModel
{
    public class UserModel
    {
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
