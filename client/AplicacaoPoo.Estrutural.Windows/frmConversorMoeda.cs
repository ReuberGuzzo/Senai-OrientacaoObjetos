using AplicacaoPoo.Dominio.Helpers;
using AplicacaoPoo.Dominio.services;
using Microsoft.VisualBasic;
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
    public partial class frmConversorMoeda : Form
    {
        
        public frmConversorMoeda()
        {
            InitializeComponent();
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
            txtValorEmDolar.Text = "1";    

            //Coloca os valores da nossa classe dentro do combobox.

            var list = new List<string>();

            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libra);
            cmbMoedas.DataSource = list;
            cmbMoedas.SelectedIndex = 0;

        
        }
            
        
        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {


            if (txtValorEmDolar.Text == "") 
            {
                cmbMoedas.Enabled = false;
                return;
            }
            cmbMoedas.Enabled = true;
            EfetuarConversaoDeMoeda();
        }

        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfetuarConversaoDeMoeda();
        }


        private void EfetuarConversaoDeMoeda()
        {
            try
            {
                #region Meu Programa
                //Atalho para comentar código CTRL + K + C
                //Atalho para descomentar o código CTRL + K + U

                if (txtValorEmDolar.Text == "") return;

                var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
                var moedaService = new ConverterMoedaService();

                switch (cmbMoedas.SelectedValue)
                {
                    case MoedaHelper.Dolar:
                        {
                            var valorConvertido = moedaService.ConverterDolarEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                            lblSegundoValor.Text = $" {valorConvertido} {MoedaHelper.Real}";

                            break;
                        }
                    case MoedaHelper.Euro:
                        {
                            var valorConvertido = moedaService.ConverterEuroEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Euro} igual a";
                            lblSegundoValor.Text = $" {valorConvertido} {MoedaHelper.Real}";
                            break;
                        }
                    case MoedaHelper.Libra:
                        {
                            var valorConvertido = moedaService.ConverterLibrasEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Libra} igual a";
                            lblSegundoValor.Text = $" {valorConvertido} {MoedaHelper.Real}";
                            break;
                        }
                }
                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("Você Precisa Informar um Valor Numerico!");
                txtValorEmDolar.Text = String.Empty;   
                txtValorEmDolar.Focus();    
            }
            
        }

    }

}