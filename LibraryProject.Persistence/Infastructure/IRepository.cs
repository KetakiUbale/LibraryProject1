using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LibraryProject.Persistence
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> Predicate);
        T FirstOrDefault(Expression<Func<T, bool>> Predicate);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
