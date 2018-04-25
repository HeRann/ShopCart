using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels.Entities
{
    public class User
    {
        public User()
        {
            Roles = new HashSet<Role>();
            Orders = new HashSet<Order>();
            createdDate = DateTime.Now;
        }

        [Key]
        public int userId { get; set; }

        [Required(ErrorMessage ="Please Enter User Name.")]
        [Display(Name ="User Name")]
        [Column(TypeName ="varchar")]
        [StringLength(50,ErrorMessage ="The {0} must between {1} and {2} char long.",ErrorMessageResourceName =null,ErrorMessageResourceType =null,MinimumLength =4)]
        public string userName { get; set; }

        [Required(ErrorMessage ="Please Enter Password.")]
        [Display(Name ="Password")]
        [Column(TypeName ="varchar")]
        [StringLength(50, ErrorMessage = "The {0} must between {1} and {2} char long.", ErrorMessageResourceName = null, ErrorMessageResourceType = null, MinimumLength = 4)]
        public string password { get; set; }

        [Display(Name ="First Name")]
        [Column(TypeName ="varchar")]
        [StringLength(100)]
        public string firstName { get; set; }

        [Display(Name = "Middle Name")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string middleName { get; set; }

        [Display(Name = "Last Name")]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string lastName { get; set; }

        [Display(Name ="Address Line 1")]
        [Column(TypeName ="varchar")]
        [StringLength(500)]
        public string addressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string addressLine2 { get; set; }

        [Display(Name = "Address Line 3")]
        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string addressLine3 { get; set; }

        [Display(Name ="City")]
        [Column(TypeName ="varchar")]
        [StringLength(200)]
        public string city { get; set; }

        [Display(Name ="State")]
        [Column(TypeName ="varchar")]
        [StringLength(200)]
        public string state { get; set; }

        [Display(Name = "Country")]
        [Column(TypeName = "varchar")]
        [StringLength(200)]
        public string country { get; set; }

        [Display(Name ="Contact Number")]
        [Column(TypeName ="varchar")]
        [StringLength(20)]
        public string contactNumber { get; set; }

        public DateTime createdDate { get; set; }

        public DateTime? updatedDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

    }
}
