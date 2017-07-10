using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejer07;

namespace ejer07Test
{
    [TestClass]
    public class FicheroServiceTest
    {
        [TestMethod]
        public void TestGuardarNumero()
        {
            FicheroService sut = new FicheroService();
            sut.GuardarNumero(5);
            Assert.IsTrue(FicheroUtil.IsLlamado());
        }
    }
}
