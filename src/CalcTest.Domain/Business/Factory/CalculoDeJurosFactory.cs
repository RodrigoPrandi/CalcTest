using CalcTest.Domain.Business.Factory.Interfaces;
using CalcTest.Domain.Business.Interfaces;
using CalcTest.Domain.Services.Interfaces;

namespace CalcTest.Domain.Business.Factory
{
    /// <summary>
    /// Classe responsável por constuir implementações concretas de cálculo de juros
    /// </summary>
    public class CalculoDeJurosFactory : ICalculoDeJurosFactory
    {
        private readonly ITaxaDeJurosServices _taxaDeJurosServices;

        /// <summary>
        /// Construtor responsável por inicializar as dependências necessárias para criação das classes de cálculo de juros
        /// </summary>
        /// <param name="taxaDeJurosServices">Serviço de taxas de juros usado para selecionar a taxa atualizada</param>
        public CalculoDeJurosFactory(ITaxaDeJurosServices taxaDeJurosServices)
        {
            _taxaDeJurosServices = taxaDeJurosServices;
        }

        /// <summary>
        /// Cria instância da classe de cálculo de juros compostos
        /// </summary>
        /// <returns>Implementação concreta da classe de cálculo de juros compostos</returns>
        public ICalculoDeJuros CreateCalculoDeJurosCompostos()
        {
            return new CalculoDeJuros(_taxaDeJurosServices.SelecionarTaxaDeJurosAtualizada());
        }
    }
}
