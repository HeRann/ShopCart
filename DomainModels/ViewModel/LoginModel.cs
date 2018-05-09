using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels.ViewModel
{
    public class LoginModel
    {
        [Display(Name ="User Name")]
        public string userName { get; set; }

        [Display(Name = "Password")]
        public string password { get; set; }
    }
}
