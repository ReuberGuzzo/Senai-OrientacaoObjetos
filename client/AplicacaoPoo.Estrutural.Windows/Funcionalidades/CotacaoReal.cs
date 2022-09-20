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
    public partial class frmCotacaoReal : Form
    {
        public frmCotacaoReal()
        {
            InitializeComponent();
            btnCalcular.Enabled = false;
            txtCarteiraDolar.Focus();
        }
            private void btnCalcular_Click(object sender, EventArgs e)
        {
                double carteiraDolar = double.Parse(txtCarteiraDolar.Text);
                double cotacaoDolar = double.Parse(txtCotacaoDolar.Text);

            MessageBox.Show("O Valor em Real é: " + Conversao.ConversaoDolar(carteiraDolar,cotacaoDolar).ToString(), "Conversão para Dolar");
        }

        private void txtCarteiraDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtCotacaoDolar.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor numerico.");
                txtCotacaoDolar.Focus();
                throw;
            }
        }

        private void txtCotacaoDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtCarteiraDolar.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor numerico.");
                txtCarteiraDolar.Focus();
                throw;
            }
        }
    }


}
