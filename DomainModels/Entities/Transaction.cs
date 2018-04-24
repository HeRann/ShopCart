using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels.Entities
{
    public class Transaction
    {
        [Key]
        public int transactionId { get; set; }

        //public int transId { get; set; }

        [Display(Name ="Status")]    
        [Column(TypeName ="varchar")]
        [StringLength(100)]
        public string status { get; set; }

        [ForeignKey("User")]
        public int userId { get; set; }

        [ForeignKey("Cart")]
        public int cartId { get; set; }

        [Display(Name ="Amount")]
        public decimal amount { get; set; }

        public DateTime? createdDate { get; set; }

        public DateTime? updatedDate { get; set; }

        public virtual User User { get; set; }

        public virtual Cart Cart { get; set; }

    }
}
