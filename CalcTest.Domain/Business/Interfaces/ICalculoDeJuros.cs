using CalcTest.Domain.Models;

namespace CalcTest.Domain.Business.Interfaces
{
    public interface ICalculoDeJuros
    {
        TaxaDeJuros TaxaAplicada { get; }
        decimal Calcular(decimal valorInicial, int quantidadeMeses);
    }
}
