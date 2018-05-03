using DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.ViewModel
{
    [NotMapped]
    public class TransactionModel:Transaction
    {
        public string nameinTransModel { get; set; }

        public string addressinTransModel { get; set; }
    }
}
