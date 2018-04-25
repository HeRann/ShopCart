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

        public string name { get; set; }

        public string address { get; set; }

        public string password { get; set; }

        public string contactNumber { get; set; }

        public string[] roles { get; set; }
    }
}
