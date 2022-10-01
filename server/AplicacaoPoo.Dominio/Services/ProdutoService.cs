using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacaoPoo.Dominio.Helpers;

namespace AplicacaoPoo.Dominio.Services
{
    public class ProdutoService
    {
        public List<Produto> ListagemProdutosFake()
        {
            var lista = new List<Produto>();

            lista.Add(new Produto()
            {
                CodPeca = 0001,
                DescricaoItem = "Molinete",
                ValorUnitario = 100m
            });
            lista.Add(new Produto()
            {
                CodPeca = 0002,
                DescricaoItem = "Anzol",
                ValorUnitario = 100m
            });
            lista.Add(new Produto()
            {
                CodPeca = 0003,
                DescricaoItem = "Vara de Pescar",
                ValorUnitario = 100m
            });
            lista.Add(new Produto()
            {
                CodPeca = 0004,
                DescricaoItem = "Chumbo",
                ValorUnitario = 100m
            });
            lista.Add(new Produto()
            {
                CodPeca = 0005,
                DescricaoItem = "Linha de Anzol",
                ValorUnitario = 100m
            });

            return lista;
        }
    }
}
