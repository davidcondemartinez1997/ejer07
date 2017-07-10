using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer07
{
    public class Calculadora : ICalculadora
    {
        /// <summary>
        /// Metodo de suma de numeros enteros
        /// </summary>
        /// <param name="A">Primer sumando</param>
        /// <param name="B">Segundo sumando</param>
        /// <returns></returns>
        public int Sumar(int A, int B)
        {
            return A + B;
        }
    }
}
