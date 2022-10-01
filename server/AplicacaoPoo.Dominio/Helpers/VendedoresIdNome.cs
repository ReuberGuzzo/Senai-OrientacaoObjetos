using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.Services
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
       
        public List<Vendedor> VendedorList()
        {
            var lista = new List<Vendedor>();
            lista.Add(new Vendedor()
            {
                Id = 0,
                Nome = ""
            });

            lista.Add(new Vendedor()
            {
                Id = 1,
                Nome = "Reuber"
            });

            lista.Add(new Vendedor()
            {
                Id = 2,
                Nome = "Thaís"
            });
            return lista;

        }
    }
}