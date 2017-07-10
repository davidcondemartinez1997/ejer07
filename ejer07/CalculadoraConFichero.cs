using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer07
{
    public class CalculadoraConFichero
    {

        public ICalculadora calculadora { get; set; }

        public IFicheroService ficheroService { get; set; }

        public void SumarGuardando(int A, int B)
        {
            int c = calculadora.Sumar(A, B);

            ficheroService.GuardarNumero(c);
        }

    }
}
