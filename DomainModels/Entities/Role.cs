using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainModels.Entities
{
    public class Role
    {
        public Role()
        {
            Users = new HashSet<User>();        
        }

        [Key]
        public int roleId { get; set; }

        [Required(ErrorMessage ="Please Enter Name.")]
        [Display(Name ="Name")]
        [StringLength(100)]
        public string name { get; set; }                

        [Display(Name ="Description")]
        [StringLength(500)]
        public string description { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
