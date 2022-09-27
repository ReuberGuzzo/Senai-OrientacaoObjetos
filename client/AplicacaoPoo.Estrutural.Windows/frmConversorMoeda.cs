using AplicacaoPoo.Dominio.Helpers;
using AplicacaoPoo.Dominio.services;
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
            btnConverterEmReal.Enabled = false;
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
        
            //Coloca os valores da nossa classe dentro do combobox.

            var list = new List<string>();

            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Real);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libra);
            cmbMoedas.DataSource = list;
            cmbMoedas.SelectedIndex = 0;

        
        }
            
        
        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
          try
            {
                if (txtValorEmDolar.Text == "") return; 
                {
                    var valorEmdolar = decimal.Parse(txtValorEmDolar.Text);
                    var moeda = new ConverterMoedaService();
                    var resultado = moeda.ConverterDolarEmReal(valorEmdolar);
                    lblPrimeiroValor.Text = $"{txtValorEmDolar} {MoedaHelper.Dolar} igual a";
                    lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";

                }
            }

            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtValorEmDolar.Focus();
              
            }
        }

        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtValorEmDolar.Text == "") return;

            var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
            var moedaService = new ConverterMoedaService();

            switch (cmbMoedas.SelectedValue) 
            {
                case MoedaHelper.Dolar:
                    {
                        var valorConvertido = moedaService.ConverterDolarEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $"{txtValorEmDolar} {MoedaHelper.Dolar} igual a";
                        lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";

                        break;
                    }
                case MoedaHelper.Euro:
                    {
                        var valorConvertido = moedaService.ConverterEuroEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $"{txtValorEmDolar} {MoedaHelper.Euro} igual a";
                        lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
                        break;
                    }    
                case MoedaHelper.Libra:
                    {
                        var valorConvertido = moedaService.ConverterLibrasEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $"{txtValorEmDolar} {MoedaHelper.Libra} igual a";
                        lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
                        break;
                    }

            }




            #region MeuPrograma
            // //decimal resultado = 0;

            //// var moeda = new ConverterMoedaService();
            //// var valor = decimal.Parse (txtValorEmDolar.Text);

            // switch (cmbMoedas.SelectedValue)
            // {
            //     case "Real Brasileiro":
            //         {

            //             break;
            //         }
            //     
            //     case "Dolar":
            //         resultado = moeda.ConverterDolarEmReal(valor);
            //         lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Dolar} igual a";
            //         lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
            //         break;

            //     case "Euro":
            //         resultado = moeda.ConverterEuroEmReal(valor);
            //         lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Euro} igual a";
            //         lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
            //         break;


            //     case "Libra":
            //         resultado = moeda.ConverterLibrasEmReal(valor);
            //         lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Libra} igual a";
            //         lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
            //         break;

            //     case "Real":

            //         lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Real} igual a";
            //         lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
            //         break;


            // }
            #endregion
        }
    }
}