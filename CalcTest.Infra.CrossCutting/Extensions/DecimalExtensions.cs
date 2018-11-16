using System.Globalization;

namespace CalcTest.Infra.CrossCutting.Extensions
{
    public static class DecimalExtensions
    {
        public static string FormartStringBr(this decimal valor)
        {
            return valor.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR"));
        }
    }
}
