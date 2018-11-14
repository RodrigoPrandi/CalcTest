namespace CalcTest.Domain.Services.Interfaces
{
    public interface ICalculoDeJurosServices
    {
        decimal Calcular(decimal valorInicial, int quantidadeMeses);
    }
}
