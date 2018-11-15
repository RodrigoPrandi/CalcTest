using CalcTest.Domain.Models;

namespace CalcTest.Domain.Business.Interfaces
{
    /// <summary>
    /// Interface que representa o cálculo de juros
    /// </summary>
    public interface ICalculoDeJuros
    {
        /// <summary>
        /// Taxa de juros aplicada no calculo
        /// </summary>
        TaxaDeJuros TaxaAplicada { get; }

        /// <summary>
        /// Realiza o calculo do valor total aplicado juros compostos, 
        /// a partir de um valor inicial e um periodo de tempo em meses
        /// </summary>
        /// <param name="valorInicial">Valor inicial a ser calculado</param>
        /// <param name="quantidadeMeses">Quantidade de meses</param>
        /// <returns>Valor total aplicado o juros no periodo de meses informado</returns>
        decimal Calcular(decimal valorInicial, int quantidadeMeses);
    }
}
