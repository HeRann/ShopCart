using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels.Entities
{
    public class CartItem
    {
        [Key]
        public int cartItemId { get; set; }

        [ForeignKey("Product")]
        public int productId { get; set; }

        [Display(Name ="Unit Price")]
        public decimal unitPrice { get; set; }

        [Display(Name ="Quantity")]
        public decimal quantity { get; set; }

        [Display(Name ="Tax")]
        public decimal  Tax { get; set; }

        [Display (Name ="Total")]
        public Decimal Total { get; set; }

        [ForeignKey("Cart")]
        public int cartId { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual Product Product { get; set; }
    }
}
