namespace CalcTest.Domain.Services.Interfaces
{
    public interface ICalculoDeJurosServices
    {
        double Calcular(decimal valorInicial, int quantidadeMeses);
    }
}
