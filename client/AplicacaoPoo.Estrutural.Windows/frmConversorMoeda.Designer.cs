﻿namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmConversorMoeda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValorEmDolar = new System.Windows.Forms.TextBox();
            this.btnConverterEmReal = new System.Windows.Forms.Button();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.cmbMoedas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtValorEmDolar
            // 
            this.txtValorEmDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorEmDolar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorEmDolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorEmDolar.ForeColor = System.Drawing.Color.White;
            this.txtValorEmDolar.Location = new System.Drawing.Point(16, 88);
            this.txtValorEmDolar.Name = "txtValorEmDolar";
            this.txtValorEmDolar.PlaceholderText = "Informe o Valor";
            this.txtValorEmDolar.Size = new System.Drawing.Size(190, 22);
            this.txtValorEmDolar.TabIndex = 1;
            this.txtValorEmDolar.TextChanged += new System.EventHandler(this.txtValorEmDolar_TextChanged);
            // 
            // btnConverterEmReal
            // 
            this.btnConverterEmReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConverterEmReal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverterEmReal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConverterEmReal.ForeColor = System.Drawing.Color.Black;
            this.btnConverterEmReal.Location = new System.Drawing.Point(95, 152);
            this.btnConverterEmReal.Name = "btnConverterEmReal";
            this.btnConverterEmReal.Size = new System.Drawing.Size(158, 28);
            this.btnConverterEmReal.TabIndex = 2;
            this.btnConverterEmReal.Text = "Converter em Reais";
            this.btnConverterEmReal.UseVisualStyleBackColor = false;
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimeiroValor.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(16, 18);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(0, 19);
            this.lblPrimeiroValor.TabIndex = 3;
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoValor.ForeColor = System.Drawing.Color.White;
            this.lblSegundoValor.Location = new System.Drawing.Point(16, 43);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(0, 30);
            this.lblSegundoValor.TabIndex = 4;
            // 
            // cmbMoedas
            // 
            this.cmbMoedas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbMoedas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMoedas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMoedas.ForeColor = System.Drawing.Color.White;
            this.cmbMoedas.FormattingEnabled = true;
            this.cmbMoedas.Items.AddRange(new object[] {
            "Real Brasileiro",
            "Dolar Americano",
            "Euro",
            "Libra Esterlina"});
            this.cmbMoedas.Location = new System.Drawing.Point(212, 87);
            this.cmbMoedas.Name = "cmbMoedas";
            this.cmbMoedas.Size = new System.Drawing.Size(119, 25);
            this.cmbMoedas.TabIndex = 5;
            // 
            // frmConversorMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(343, 192);
            this.Controls.Add(this.cmbMoedas);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Controls.Add(this.btnConverterEmReal);
            this.Controls.Add(this.txtValorEmDolar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmConversorMoeda";
            this.Text = "frmConversorMoeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtValorEmDolar;
        private Button btnConverterEmReal;
        private Label lblPrimeiroValor;
        private Label lblSegundoValor;
        private ComboBox cmbMoedas;
    }
}