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
            sut.calculadora = new CalculadoraDel9();
            sut.ficheroService = new FIcheroServiceDeMentira();
            sut.SumarGuardando(3, 2);


        }
    }

    [TestClass]
    public class CalculadoraDel9 : ICalculadora
    {
        public int Sumar(int A, int B)
        {
            return 9;
        }
    }

    public class FIcheroServiceDeMentira : IFicheroService
    {
        public void GuardarNumero(object Res)
        {
           
        }
    }
}
