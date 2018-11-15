using System;
using System.Collections.Generic;
using System.Text;

namespace CalcTest.Application.Services.Interfaces
{
    public interface ICalculoDeJurosApplicationService
    {
        double Calcular(decimal valorInicial, int quantidadeMeses);
    }
}
