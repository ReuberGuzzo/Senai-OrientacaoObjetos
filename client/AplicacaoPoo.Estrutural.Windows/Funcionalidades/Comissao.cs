using AplicacaoPOO.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    public partial class frmComissao : Form
    {
        public frmComissao()
        {
            InitializeComponent();
        }
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            int quantidadePeca = int.Parse(txtQuantidade.Text);
            double valorUnitario = double.Parse(txtValorUnitario.Text);

            var result = (quantidadePeca * valorUnitario) * 0.05;

            txtResultado.Text = Comissao.ValorComissao(valorUnitario, quantidadePeca).ToString();
        }
    }
}
