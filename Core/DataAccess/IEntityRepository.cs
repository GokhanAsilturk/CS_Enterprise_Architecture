
using Core.Entities;
using System.Linq.Expressions;

namespace Core.Abstract
{
    //Generic constraint
    //class : referans tip olabilir
    //IEntity : IEntity veya ondan implement edilmiş olmalı
    //new() : newlenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
