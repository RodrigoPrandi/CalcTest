using CalcTest.Domain.Business.Factory.Interfaces;
using CalcTest.Domain.Business.Interfaces;
using CalcTest.Domain.Repository;

namespace CalcTest.Domain.Business.Factory
{
    /// <summary>
    /// Classe responsável por constuir implementações concretas de cálculo de juros
    /// </summary>
    public class CalculoDeJurosFactory : ICalculoDeJurosFactory
    {
        private readonly ITaxaDeJurosRepository _taxaDeJurosRepository;

        /// <summary>
        /// Construtor responsável por inicializar as dependências necessárias para criação das classes de cálculo de juros
        /// </summary>
        /// <param name="taxaDeJurosRepository">Repoisitorio de taxas de juros usado para selecionar a taxa atualizada</param>
        public CalculoDeJurosFactory(ITaxaDeJurosRepository taxaDeJurosRepository)
        {
            _taxaDeJurosRepository = taxaDeJurosRepository;
        }

        /// <summary>
        /// Cria instância da classe de cálculo de juros compostos
        /// </summary>
        /// <returns>Implementação concreta da classe de cálculo de juros compostos</returns>
        public ICalculoDeJuros CreateCalculoDeJurosCompostos()
        {
            return new CalculoDeJuros(_taxaDeJurosRepository.SelecionarTaxaDeJurosAtualizada());
        }
    }
}
