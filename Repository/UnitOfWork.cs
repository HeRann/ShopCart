using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Abstraction;
using ApplicationCore;
using Repository.Implementation;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext db;

        public UnitOfWork()
        {
            db = new DatabaseContext();
        }
        private IAuthenticateRepository _authenticateRepo;
        public IAuthenticateRepository AuthenticateRepo
        {
            get
            {
                if (_authenticateRepo == null)
                {
                    _authenticateRepo = new AuthenticateRepository(db);
                }
                return _authenticateRepo;
            }
        }

        private ICategoryRepository _categoryRepo;
        public ICategoryRepository CategoryRepo
        {
            get
            {
                if(_categoryRepo == null)
                { 
                    _categoryRepo = new CategoryRepository(db);
                }
                return _categoryRepo;
            }
        }

        private IOrderRepository _orderRepo;
        public IOrderRepository OrderRepo
        {
            get
            {
                if (_orderRepo == null)
                {
                    _orderRepo = new OrderRepository(db);
                }
                return _orderRepo;
            }
        }

        private IProductRepository _productRepo;
        public IProductRepository ProductRepo
        {
            get
            {
                if (_productRepo == null)
                {
                    _productRepo = new ProductRepository(db);
                }
                return _productRepo;
            }
        }


        public int SaveChanges()
        {
           return db.SaveChanges();
        }
    }
}
