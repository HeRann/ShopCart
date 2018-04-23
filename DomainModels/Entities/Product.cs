using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels.Entities
{
    public class Product
    {
        public Product()
        {
            createdDate = DateTime.Now;
        }

        [Key]
        [Display(Name="Product Id")]
        public int productId { get; set; }

        [Required(ErrorMessage ="Please Enter Product Name.")]
        [Column(TypeName ="varchar")]
        [StringLength(100)]
        [Display(Name = "Product Name")]
        public string productName { get; set; }

        [Display(Name ="Unit Price")]
        public decimal unitPrice { get; set; }

        [Required(ErrorMessage ="Please Enter Item Description.")]
        [Column(TypeName="varchar")]
        [StringLength(800)]
        [Display(Name = "Description")]
        public string description { get; set; }

        [Required(ErrorMessage ="Please Enter ImageName.")]
        [Column(TypeName="varchar")]
        [StringLength(260)]
        [Display(Name = "Image Name")]
        public string imageName { get; set; }

        [Required(ErrorMessage ="Please Enter Image Path.")]
        [Column(TypeName="varchar")]
        [StringLength(1000)]
        [Display(Name = "Image Path")]
        public string imagePath { get; set; }

        [Required]
        [ForeignKey("Category")]
        [Display(Name ="Category Id")]
        public int categoryId { get; set; }

        [Display(Name = "Created Date")]
        public DateTime? createdDate { get; set; }

        [Display(Name ="Updated Date")]
        public DateTime? updatedDate { get; set; }

        public virtual Category Category { get; set; }

    }
}
