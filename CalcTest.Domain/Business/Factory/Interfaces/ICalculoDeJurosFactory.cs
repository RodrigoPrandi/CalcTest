using System;
using System.Collections.Generic;
using System.Text;
using CalcTest.Domain.Business.Interfaces;

namespace CalcTest.Domain.Business.Factory.Interfaces
{
    public interface ICalculoDeJurosFactory
    {
        ICalculoDeJuros Build();
    }
}
