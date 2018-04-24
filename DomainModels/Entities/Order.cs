using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels.Entities
{
    public class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
            createdDate = DateTime.Now;
        }
        [Key]
        public int orderId { get; set; }

        [Required(ErrorMessage ="Please Enter Cutomer Name.")]
        [Display(Name ="Customer Name")]
        [Column(TypeName ="varchar")]
        [StringLength(250)]
        public string customerName { get; set; }

        [Required(ErrorMessage ="Please Enter Shipping Address.")]
        [Display(Name ="Shipping Address")]
        [Column(TypeName ="varchar")]
        [StringLength(500)]
        public string shippingAddress { get; set; }

        [ForeignKey("Cart")]
        public int cartId { get; set; }

        [ForeignKey("User")]
        public int userId { get; set; }

        [Display(Name ="Status")]
        [Column(TypeName ="varchar")]
        [StringLength(25)]
        public string status { get; set; }

        [Display(Name ="Grand Total")]
        public decimal grandTotal { get; set; }

        [Display(Name ="Tax")]
        public decimal tax { get; set; }

        [Display(Name="Discount")]
        public decimal discount { get; set; }

        [Display(Name ="Payable Amount")]
        public decimal payableAmount { get; set; }

        public DateTime createdDate { get; set; }

        public DateTime? updatedDate { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public virtual User User { get; set; }

        public virtual Cart Cart { get; set; }

    }
}

