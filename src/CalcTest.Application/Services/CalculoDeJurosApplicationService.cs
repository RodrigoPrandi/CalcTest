using CalcTest.Application.Services.Interfaces;
using CalcTest.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcTest.Application.Services
{
    public class CalculoDeJurosApplicationService : ICalculoDeJurosApplicationService
    {
        private readonly ICalculoDeJurosServices _calculoDeJurosServices;

        public CalculoDeJurosApplicationService(ICalculoDeJurosServices calculoDeJurosServices)
        {
            _calculoDeJurosServices = calculoDeJurosServices;
        }
        public decimal Calcular(decimal valorInicial, int quantidadeMeses)
        {
            return _calculoDeJurosServices.Calcular(valorInicial, quantidadeMeses);
        }
    }
}
