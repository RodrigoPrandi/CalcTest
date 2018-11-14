using System;
using System.Collections.Generic;
using System.Text;

namespace CalcTest.Domain.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Delete(Guid id);
        int SaveChanges();
    }
}
