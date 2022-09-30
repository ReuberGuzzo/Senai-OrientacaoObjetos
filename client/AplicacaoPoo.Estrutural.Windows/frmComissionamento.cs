using AplicacaoPoo.Dominio.Helpers;
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
    public partial class frmComissionamento : Form
    {
        public frmComissionamento()
        {
            InitializeComponent();
            var vendedores = new Vendedor();
            cmbVendedoresCadastrados.DataSource = vendedores.VendedorList();
            cmbVendedoresCadastrados.DisplayMember = "Nome";
            cmbVendedoresCadastrados.SelectedIndex = 0;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaração de Variaveis:
                string nome = cmbVendedoresCadastrados.Text;
                string data = mtbData.Text;
                int codigoPeca = int.Parse(txtPecaCodigo.Text);
                double precoUnitario = double.Parse(txtPrecoPeca.Text);
                int quantidadeVendida = int.Parse(txtQuantidadepecaVendida.Text);

                //Chamando Função de Calcular Comissão.
                var resultadoComissao = (Comissao.CalcularComissao(precoUnitario, quantidadeVendida).ToString());

                //Adicionando os dados na List Box
                ltbListaDePecas.Items.Add("Nome do Vendedor: " + nome);
                ltbListaDePecas.Items.Add("Data da Venda:" + data);
                ltbListaDePecas.Items.Add("Código da Peça: " + codigoPeca);
                ltbListaDePecas.Items.Add("Preço Unitario: " + precoUnitario);
                ltbListaDePecas.Items.Add("Quantidade Vendida: " + quantidadeVendida);
                ltbListaDePecas.Items.Add("Valor da Comissão: " + resultadoComissao);
                ltbListaDePecas.Items.Add("-----------------------------");

            }
            catch (Exception)
            {

                MessageBox.Show("Confira os dados inseridos, Erro ao receber Informações passadas");
            }
        }
    }
}