using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace thomerson.permission.Core.DAL
{
    public abstract class DAL_Base<T> : IBaseDAL<T> where T : class
    {
        protected DbContext baseContext;
        protected DbSet<T> objectSet;

        public DAL_Base(DbContext context)
        {
            this.baseContext = context;
            this.objectSet = this.baseContext.Set<T>();
        }

        public T Get(Guid id)
        {
            return objectSet.Find(id);
        }

        public IList<T> GetAll(Expression<Func<T, bool>> whereCondition = null)
        {
            return objectSet.Where(whereCondition).ToList<T>();
        }

        public void Update(Expression<Func<T, bool>> whereCondition)
        {

        }

        public void Delete()
        {
        }

        public Guid Insert(T model)
        {
            throw new NotImplementedException();
        }

        public void Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
