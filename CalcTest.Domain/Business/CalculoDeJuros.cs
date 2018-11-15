using System;
using CalcTest.Domain.Business.Interfaces;
using CalcTest.Domain.Models;

namespace CalcTest.Domain.Business
{
    /// <summary>
    /// Claasse responsável por realizar o cálculo de juros compostos
    /// </summary>
    public class CalculoDeJuros : ICalculoDeJuros
    {
        /// <summary>
        /// Taxa de juros aplicada no calculo
        /// </summary>
        public TaxaDeJuros TaxaAplicada { get; }

        /// <summary>
        /// Inicializa a classe com a taxa de juros informada
        /// </summary>
        /// <param name="taxaDeJuros">Taxa de juros que será aplicada no cálculo</param>
        public CalculoDeJuros(TaxaDeJuros taxaDeJuros)
        {
            TaxaAplicada = taxaDeJuros;
        }

        /// <summary>
        /// Realiza o calculo do valor total aplicado juros compostos, 
        /// a partir de um valor inicial e um periodo de tempo em meses
        /// </summary>
        /// <param name="valorInicial">Valor inicial a ser calculado</param>
        /// <param name="quantidadeMeses">Quantidade de meses</param>
        /// <returns>Valor total aplicado o juros no periodo de meses informado</returns>
        public double Calcular(decimal valorInicial, int quantidadeMeses)
        {
            var jurosPercentual = (double)(TaxaAplicada.JurosEfetivo / 100m);
            var resultado = (double)valorInicial * Math.Pow((1 + jurosPercentual), quantidadeMeses);

            resultado = Math.Truncate(100 * resultado);
            resultado = resultado / 100;

            return resultado;
        }
    }
}
