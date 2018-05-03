using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.ViewModel
{
    class ReceiptModel
    {
        public int transactionId { get; set; }

        public string  firstName { get; set; }

        public string email { get; set; }

        public decimal amount { get; set; }

        public string  status { get; set; }

        public string paymentType { get; set; }
    }
}
