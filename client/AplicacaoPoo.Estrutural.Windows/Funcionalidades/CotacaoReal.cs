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

        }
            private void btnCalcular_Click(object sender, EventArgs e)
        {
                double carteiraDolar = double.Parse(txtCarteiraDolar.Text);
                double cotacaoDolar = double.Parse(txtCotacaoDolar.Text);

            MessageBox.Show("O Valor em Real é: " + Conversao.ConversaoDolar(carteiraDolar,cotacaoDolar).ToString(), "Conversão para Dolar");
        }
    }


}
