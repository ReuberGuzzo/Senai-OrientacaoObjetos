using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio
{
    public class Conversao
    {
        public static double ConversaoDolar(double carteiraDolar, double cotacaoDolar)
        {
            double resultado = carteiraDolar * cotacaoDolar;
            return resultado;

        }
    }
}
