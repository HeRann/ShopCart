using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUnitOfWork
    {
        IAuthenticateRepository AuthenticateRepo { get;  }
        IOrderRepository OrderRepo { get; }
        ICategoryRepository CategoryRepo { get; }
        IProductRepository ProductRepo { get; }

        int SaveChanges();
    }
}
