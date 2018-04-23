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
        [Key]
        public int orderId { get; set; }

        [Required(ErrorMessage ="Please Enter Cutomer Name.")]
        [Display(Name ="Customer Name")]
        [Column(TypeName ="varchar")]
        []
        public string customerName { get; set; }

        public string shippingAddress { get; set; }

        public int cartId { get; set; }

        public int userId { get; set; }

        public string status { get; set; }

        public decimal grandTotal { get; set; }

        public decimal tax { get; set; }

        public decimal discount { get; set; }

        public decimal payableAmount { get; set; }

        public DateTime createdDate { get; set; }

        public DateTime? updatedDate { get; set; }

        public virtual ICollection<OrderItem> OrderItem { get; set; }

        public virtual User User { get; set; }

        public virtual Cart Cart { get; set; }

    }
}

