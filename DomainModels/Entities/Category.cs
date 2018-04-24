using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            createdDate = DateTime.Now;
        }

        [Key]
        public int categoryId { get; set; }

        [Required(ErrorMessage = "Please Enter Category Name.")]
        [Display(Name = "Category Name")]
        [StringLength(100)]
        public string categoryName { get; set; }

        public DateTime createdDate { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime? updatedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
