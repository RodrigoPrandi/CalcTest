using CalcTest.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcTest.Infra.Data.InMemory.Repository
{
    /// <summary>
    /// Criado classe apenas para representar um rempositorio abstrato
    /// não será utilizado nessa implementação
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class RepositoryInMemory<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly List<TEntity> _lista;

        public RepositoryInMemory()
        {
            _lista = new List<TEntity>();
        }
        public void Add(TEntity obj)
        {
            _lista.Add(obj);
        }

        public void Delete(Guid id)
        {
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _lista;
        }

        public TEntity GetById(Guid id)
        {
            return _lista.FirstOrDefault();
        }

        public void SaveChanges()
        {
        }

        public void Update(TEntity obj)
        {
        }
    }
}
