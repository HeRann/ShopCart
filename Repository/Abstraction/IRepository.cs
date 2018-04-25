using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
    interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity model);

        void Edit(TEntity model);

        void Delete(TEntity model);

        void DeleteById(object Id);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(object Id);
    }
}
