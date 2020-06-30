namespace CalcTest.Domain.Services.Interfaces
{
    /// <summary>
    /// Interface do serviço de cálculo de juros compostos
    /// </summary>
    public interface ICalculoDeJurosServices
    {
        /// <summary>
        /// Realiza o cálculo do valor total de juros a partir de um valor inicial
        /// e uma quantidade de meses especificada
        /// </summary>
        /// <param name="valorInicial">Valor inial a ser aplicado o juros </param>
        /// <param name="quantidadeMeses">Quantidade de meses a ser aplicado o juros</param>
        /// <returns>Valor final do calculo de juros pelos meses informado</returns>
        decimal Calcular(decimal valorInicial, int quantidadeMeses);
    }
}
