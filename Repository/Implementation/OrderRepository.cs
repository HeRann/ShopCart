using ApplicationCore;
using DomainModels.Entities;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.ViewModel;

namespace Repository.Implementation
{
    class OrderRepository: Repository<Order>, IOrderRepository
    {
        public OrderRepository(DatabaseContext _db)
        {
            this.db = _db;
        }

        public void placeOrder(TransactionModel model)
        {
            Transaction Trans = new Transaction();
            Trans.amount = model.amount;
            Trans.cartId = model.cartId;
            Trans.transactionId = model.transactionId;
            Trans.createdDate = model.createdDate;
            Trans.paymentType = model.paymentType;
            Trans.status = model.status;

            Cart crt = db.Carts.Where(m => m.cartId == model.cartId).FirstOrDefault();

            if (Trans.status == "True")
            {
                Order order = new Order();
                order.cartId = crt.cartId;
                order.createdDate = DateTime.Now;
                order.customerName = model.nameinTransModel;
                order.shippingAddress = model.addressinTransModel;
                order.grandTotal = crt.grandTotal;
                order.userId = crt.userId;

                foreach (var itms in crt.Items)
                {
                    OrderItem ordItemObj = new OrderItem();
                    ordItemObj.productId = itms.productId;
                    ordItemObj.quantity = itms.quantity;
                    ordItemObj.total = itms.total;
                    ordItemObj.unitPrice = itms.unitPrice;

                    order.OrderItems.Add(ordItemObj);
                }
                db.Orders.Add(order);
            }
            Trans.userId = crt.userId;
            db.Transactions.Add(Trans);
        }

        public int saveCart(Cart model)
        {
            db.Carts.Add(model);
            db.SaveChanges();
            return model.cartId;
        }
    }
}
