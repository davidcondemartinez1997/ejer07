using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejer07;

namespace ejer07Test
{
    [TestClass]
    public class CalculadoraConFicheroTest
    {
        [TestMethod]
        public void TestSumarConFichero()
        {
            CalculadoraConFichero sut = new CalculadoraConFichero();
            sut.SumarGuardando(3, 2);

        }

        [TestMethod]
        public void TestCamposEstaticos()
        {
            CalculadoraConFichero instancia1 = new CalculadoraConFichero();
            CalculadoraConFichero instancia2 = new CalculadoraConFichero();
            CalculadoraConFichero instancia3 = new CalculadoraConFichero();
        }
    }
}
