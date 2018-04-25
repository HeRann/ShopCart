using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainModels.Entities
{
    public class OrderItem
    {
        [Key]
        public int orderItemId { get; set; }

        //[ForeignKey("Product")]
        public int productId { get; set; }

        [Display(Name ="Unit Price")]
        public decimal unitPrice { get; set; }

        [Display(Name ="Quantity")]
        public decimal quantity { get; set; }

        [Display(Name ="Total")]
        public decimal total { get; set; }
        
        [ForeignKey("Order")]
        public int orderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
