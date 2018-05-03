using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
    public interface Repositary<TEntity> where TEntity :class
    {
        TEntity GetById(object Id);

        void Add(TEntity model);

        void Delete(TEntity model);

        void DeleteById(object Id);

        void Update(TEntity model);

        IEnumerable<TEntity> GetAll();

    }
}
