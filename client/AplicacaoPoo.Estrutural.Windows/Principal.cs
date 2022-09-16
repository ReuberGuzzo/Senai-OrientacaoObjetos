using AplicacaoPoo.Estrutural.Windows.Funcionalidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCotacao_Click(object sender, EventArgs e)
        {
            var form = new frmCotacaoReal();
            form.Show();
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            var form = new frmComissao();
            form.Show();
        }
    }
}
