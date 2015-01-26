using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculeMinhaConta.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var consumo = new Consumo("Denis", 1, 2, 3);

            var plano = new Plano("Vivo Smart", 0.10m, 0.35m, 0.75m, 30m);

            var conta = plano.CalcularConta(consumo);

            Assert.AreEqual(33.05m, conta.Total);
        }
    }
}
