using CalcTest.Infra.CrossCutting.Extensions;
using NUnit.Framework;

namespace CalcTest.Infra.CrossCutting.Test.Extensions
{
    [TestFixture]
    class DecimalExtensionsTest
    {
        [Test]
        public void TestarValorDecimal105_10()
        {
            Assert.AreEqual("105,10", 105.10m.FormartStringBr());
        }

        [Test]
        public void TestarValorDecimal100()
        {
            Assert.AreEqual("100,00", 100m.FormartStringBr());
        }

        [Test]
        public void TestarValorDecimal105_14()
        {
            Assert.AreEqual("105,14", 105.14m.FormartStringBr());
        }

        [Test]
        public void TestarValorDecimal105_1215()
        {
            Assert.AreEqual("105,12", 105.1215m.FormartStringBr());
        }

        [Test]
        public void TestarValorDecimal105_1296()
        {
            Assert.AreEqual("105,13", 105.1296m.FormartStringBr());
        }
    }
}
