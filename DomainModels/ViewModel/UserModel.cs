using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.ViewModel
{
    public class UserModel
    {
        public int userIdinModel { get; set; }

        public string userNameinModel { get; set; }

        public string firstNameinModel { get; set; }
        public string lastNameinModel { get; set; }

        public string addressLine1inModel { get; set; }

        public string addressLine2inModel { get; set; }

        public string addressLine3inModel { get; set; }

        public string passwordinModel { get; set; }

        public string contactNumberinModel { get; set; }

        public string[] rolesinModel { get; set; }
    }
}
