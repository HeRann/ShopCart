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
        private IAuthenticateRepository _AuthenticateRepo;
        private ICategoryRepository _CategoryRepo;
        private IOrderRepository _OrderRepo;
        private IProductRepository _productRepo;

        public UnitOfWork(DatabaseContext _db)
        {
            this.db = _db;
        }
        public IAuthenticateRepository AuthenticateRepo
        {
            get
            {
                if (_AuthenticateRepo == null)
                {
                    _AuthenticateRepo = new AuthenticateRepository(db);

                   
                }
                return _AuthenticateRepo;
            }
        }

        public ICategoryRepository CategoryRepo
        {
            get
            {
                if (_CategoryRepo == null)
                {
                    _CategoryRepo = new CategoryRepository(db);
                  
                }
                return _CategoryRepo;
            }
        }

        public IOrderRepository OrderRepo
        {
            get
            {
                if (_OrderRepo == null)
                {
                    _OrderRepo = new OrderRepository(db);
                }
                return _OrderRepo;
            }
        }

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
