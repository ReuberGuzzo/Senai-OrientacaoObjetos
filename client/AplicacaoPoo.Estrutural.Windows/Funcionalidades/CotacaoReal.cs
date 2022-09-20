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
        private bool CotacaoEhValido;
        private bool CarteiraEmDolarEhValido;

        public frmCotacaoReal()
        {
            InitializeComponent();
            HabilitarOuDesabilitarBotaoCalcularConversao();
            txtCarteiraDolar.Focus();
        }
            private void btnCalcular_Click(object sender, EventArgs e)
        {
                double cotacaoDolar = double.Parse(txtCotacaoDolar.Text);
                double carteiraDolar = double.Parse(txtCarteiraDolar.Text);

            MessageBox.Show("O Valor em Real é: " + Conversao.ConversaoDolar(carteiraDolar,cotacaoDolar).ToString(), "Conversão para Dolar");
        }

        private void txtCarteiraDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtCarteiraDolar.Text);
                CarteiraEmDolarEhValido = true;
                HabilitarOuDesabilitarBotaoCalcularConversao();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor numerico.");
                txtCarteiraDolar.Focus();
                CarteiraEmDolarEhValido = false;
                HabilitarOuDesabilitarBotaoCalcularConversao();

            }
        }

        private void txtCotacaoDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtCotacaoDolar.Text);
                CotacaoEhValido = true;
                HabilitarOuDesabilitarBotaoCalcularConversao();


            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor numerico.");
                txtCotacaoDolar.Focus();
                HabilitarOuDesabilitarBotaoCalcularConversao();

            }
        }

        private void HabilitarOuDesabilitarBotaoCalcularConversao() 
        {
            if (CarteiraEmDolarEhValido && CotacaoEhValido)
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

    }


}
