using CalcTest.Domain.Models;

namespace CalcTest.Domain.Repository
{
    /// <summary>
    /// Repositorio de Taxas de Juros
    /// </summary>
    public interface ITaxaDeJurosRepository : IRepository<TaxaDeJuros>
    {
        /// <summary>
        /// Seleciona a taxa de juros atualizada
        /// </summary>
        /// <returns>Taxa de juros atualizada no momento da consulta</returns>
        TaxaDeJuros SelecionarTaxaDeJurosAtualizada();
    }
}
