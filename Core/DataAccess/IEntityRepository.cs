using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text; 

namespace Core.DataAccess
{
    public interface IEntityRepository<T>where T:class,IEntity,new() //it is allow to be reference type,IEntity or implemented object from IEntity
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//Using LINQ
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
