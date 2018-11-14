using CalcTest.Domain.Models;

namespace CalcTest.Domain.Repository
{
    public interface ITaxaDeJurosRepository : IRepository<TaxaDeJuros>
    {
        TaxaDeJuros SelecionarTaxaDeJurosAtualizada();
    }
}
