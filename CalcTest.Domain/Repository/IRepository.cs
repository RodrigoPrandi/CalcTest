using System;
using System.Collections.Generic;

namespace CalcTest.Domain.Repository
{
    /// <summary>
    /// Interface genérica para representar o acesso aos dados do sistema
    /// </summary>
    /// <typeparam name="TEntity">Uma entidade do sistema</typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Adiciona uma entidade
        /// </summary>
        /// <param name="obj">Entidade que será incluida</param>
        void Add(TEntity obj);
        /// <summary>
        /// Seleciona a entidade pelo Id
        /// </summary>
        /// <param name="id">Identificado único do registro</param>
        /// <returns>Entidade com o Id informado</returns>
        TEntity GetById(Guid id);
        /// <summary>
        /// Seleciona todas entidades
        /// </summary>
        /// <returns>Lista com todos os registros da entidades</returns>
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// Altera a o registro da entidade
        /// </summary>
        /// <param name="obj">Entidade que será alterada</param>
        void Update(TEntity obj);
        /// <summary>
        /// Apaga o registro com o Id informado
        /// </summary>
        /// <param name="id">Identificador único do registro</param>
        void Delete(Guid id);
        /// <summary>
        /// Salva as alterações realizadas
        /// </summary>
        void SaveChanges();
    }
}
