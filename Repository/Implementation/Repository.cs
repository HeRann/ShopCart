﻿using ApplicationCore;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class Repository<TEntity> : Repositary<TEntity> where TEntity : class
    {
        protected DatabaseContext db;// { get; set; }

        public void Add(TEntity model)
        {
            db.Set<TEntity>().Add(model);
        }

        public void Delete(TEntity model)
        {
            db.Set<TEntity>().Remove(model);
        }

        public void DeleteById(object Id)
        {
            TEntity entity = db.Set<TEntity>().Find(Id);
            this.Delete(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(object Id)
        {
            return db.Set<TEntity>().Find(Id);
        }

        public void Update(TEntity model)
        {
            db.Entry<TEntity>(model).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
