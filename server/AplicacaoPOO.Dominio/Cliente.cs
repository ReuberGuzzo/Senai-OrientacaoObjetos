using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio
{
    public class Cliente
    {
        string Nome { get; set; }
        string CPF { get; set; }
        Debito Debito { get; set; }
        Credito credito { get; set; }

    }
}
