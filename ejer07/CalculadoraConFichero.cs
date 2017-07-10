using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer07
{
    public class CalculadoraConFichero
    {

        public void SumarGuardando(int A, int B)
        {
            int res = Calculadora.Sumar(A, B);

            FicheroService.GuardarNumero(res);
        }


    }
}
