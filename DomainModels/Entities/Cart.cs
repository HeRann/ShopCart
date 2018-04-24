using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DomainModels.Entities
{
    public class Cart
    {
        public Cart()
        {
            Items = new HashSet<CartItem>();
            createdDate = DateTime.Now;
        }
        [Key]
        public int cartId { get; set; }

        [Display(Name ="Grand Total")]
        public decimal grandTotal { get; set; }

        [Display(Name ="Tax")]
        public decimal tax { get; set; }

        [Display(Name ="Discount")]
        public decimal discount { get; set; }

        [ForeignKey("User")]
        public int userId { get; set; }

        [Display(Name ="Payable Amount")]
        public decimal payableAmount { get; set; }

        public DateTime createdDate { get; set; }

        public DateTime? updatedDate { get; set; }

        public virtual ICollection<CartItem> Items { get; set; }

        [ForeignKey("User")]
        public virtual User User { get; set; }
    }
}
