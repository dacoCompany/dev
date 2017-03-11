using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure.Common.DB
{
    /// <summary>
    /// Interface of repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T: class
    {
        IQueryable<T> FindWhere(Expression<Func<T, bool>> predicate);
        IQueryable<T> FindAll();
        T FindById(int id);
        T Add(T obj);
        IEnumerable<T> AddRange(IEnumerable<T> objCollection);
        void Delete(T obj);
    }
}
