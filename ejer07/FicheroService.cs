using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer07
{
    public class FicheroService
    {
        public static void GuardarNumero(object Res)
        {
            FicheroUtil fichero = new FicheroUtil();
            fichero.AlmacenarDatos(Res, "miFichero.txt");
        }
    }
}
