namespace CalcTest.Domain.Business.Interfaces
{
    public interface ICalculoDeJuros
    {
        decimal Calcular(decimal valorInicial, int quantidadeMeses);
    }
}
