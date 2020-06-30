using CalcTest.Domain.Models;
using CalcTest.Domain.Repository;

namespace CalcTest.Infra.Data.InMemory.Repository
{
    public class TaxaDeJurosRepositoryInMemory : RepositoryInMemory<TaxaDeJuros>, ITaxaDeJurosRepository
    {
        public TaxaDeJuros SelecionarTaxaDeJurosAtualizada()
        {
            return new TaxaDeJuros { JurosEfetivo = 1 };
        }
    }
}
