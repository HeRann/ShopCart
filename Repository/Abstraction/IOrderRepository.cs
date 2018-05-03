using DomainModels.Entities;
using DomainModels.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
    public interface IOrderRepository :Repositary<Order>
    {
        int saveCart(Cart model);

        void placeOrder(TransactionModel model);
    }
}
