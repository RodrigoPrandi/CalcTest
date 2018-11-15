using CalcTest.Domain.Business.Interfaces;

namespace CalcTest.Domain.Business.Factory.Interfaces
{

    /// <summary>
    /// Interface responsável por constuir implementações concretas de cálculo de juros
    /// </summary>
    public interface ICalculoDeJurosFactory
    {
        /// <summary>
        /// Cria instância da classe de cálculo de juros compostos
        /// </summary>
        /// <returns>Implementação concreta da classe de cálculo de juros compostos</returns>
        ICalculoDeJuros CreateCalculoDeJurosCompostos();
    }
}
