using AplicacaoPoo.Dominio.Helpers;
using AplicacaoPoo.Dominio.Services;
using System;
using System.Collections;
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

            var produtos = new ProdutoService();
            cmbProdutos.DataSource = produtos.ListagemProdutosFake();
            cmbProdutos.DisplayMember = "Nome";
            cmbProdutos.ValueMember = "CodPeca";
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaração de Variaveis:
                string nome = cmbVendedoresCadastrados.Text;
                string data = mtbData.Text;
                int quantidadeVendida = int.Parse(txtQuantidadepecaVendida.Text);
                


                //chamando função de calcular comissão.
                // var resultadocomissao = (comissao.calcularcomissao(precounitario, quantidadevendida).tostring());

                //adicionando os dados na list box
                //ltblistadepecas.items.add("nome do vendedor: " + nome);
               // ltblistadepecas.items.add("data da venda:" + data);
               // ltblistadepecas.items.add("quantidade vendida: " + quantidadevendida);
                //ltblistadepecas.items.add("valor da comissão: " + resultadocomissao);
               // ltblistadepecas.items.add("-----------------------------");

            }
            catch (Exception)
            {

                MessageBox.Show("Confira os dados inseridos, Erro ao receber Informações passadas");
            }
        }

        private void cmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produtoSelecionado = (Produto)cmbProdutos.SelectedValue;
                
                
            var produto = new ProdutoService();
            var produtosFake = produto.ListagemProdutosFake();
            var dado = produtosFake.Where(x => x.CodPeca == produtoSelecionado.CodPeca).FirstOrDefault();
            txtPrecoPeca.Text = dado.ValorUnitario.ToString();
        }
    }
}