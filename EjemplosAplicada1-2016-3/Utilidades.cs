using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemplosAplicada1_2016_3
{
   public class Utilidades
    {
        public static int ToInt(string Numero)
        {
            int retorno = 0;

            int.TryParse(Numero, out retorno);

            return retorno;
        }
    }
}
