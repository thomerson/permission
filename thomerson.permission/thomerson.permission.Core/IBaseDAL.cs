using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace thomerson.permission.Core
{
    interface IBaseDAL<T> where T : class
    {
        T Get(Guid id);

        IList<T> GetAll(Expression<Func<T, bool>> whereCondition = null);

        Guid Insert(T model);

        void Update(T model);

        void Update(Expression<Func<T, bool>> whereCondition = null);

    }

   
}
