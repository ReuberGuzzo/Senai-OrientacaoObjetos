using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio
{
    public class Comissao
    {
        public static double ValorComissao(double valorUnitario, int quantidadePeca)
        {
            double resultado = (valorUnitario * quantidadePeca) * 0.05;
            return resultado;
        }
    }
}