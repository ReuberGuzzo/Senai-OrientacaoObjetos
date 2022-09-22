using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{

    //static
    //partial
    //abstract

    // Exemplo usando classes intanciais
    public class ConverterMoedaService
    {
        decimal CotacaoDolar = 5.25m;
        decimal CotacaoLibra = 6.15m;
        decimal CotacaoEuro = 6.0m;

        public decimal ConverterDolarEmReal(decimal valor)
        {
            return valor * CotacaoDolar;
        }
        
        public decimal ConverterLibrasEmReal(decimal valor)
        {
            return valor * CotacaoLibra;
        }
        
        public decimal ConverterEuroEmReal(decimal valor)
        {
            return valor * CotacaoEuro;
        }

    }

}