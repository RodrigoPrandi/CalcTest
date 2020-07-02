using CalcTest.Domain.Models;

namespace CalcTest.Domain.Services.Interfaces
{
    /// <summary>
    /// Repositorio de Taxas de Juros
    /// </summary>
    public interface ITaxaDeJurosServices
    {
        /// <summary>
        /// Consulta a taxa de juros atualizada
        /// </summary>
        /// <returns>Taxa de juros atualizada no momento da consulta</returns>
        TaxaDeJuros SelecionarTaxaDeJurosAtualizada();
    }
}
