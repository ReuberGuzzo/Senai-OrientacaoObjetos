namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmComissionamento
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
            this.txtPecaCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecoPeca = new System.Windows.Forms.TextBox();
            this.txtQuantidadepecaVendida = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbVendedoresCadastrados = new System.Windows.Forms.ComboBox();
            this.lblVendedorNome = new System.Windows.Forms.Label();
            this.ltbListaDePecas = new System.Windows.Forms.ListBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtPecaCodigo
            // 
            this.txtPecaCodigo.Location = new System.Drawing.Point(12, 52);
            this.txtPecaCodigo.Name = "txtPecaCodigo";
            this.txtPecaCodigo.PlaceholderText = "Codigo da Peça";
            this.txtPecaCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtPecaCodigo.TabIndex = 1;
            this.txtPecaCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecoPeca
            // 
            this.txtPrecoPeca.Location = new System.Drawing.Point(131, 52);
            this.txtPrecoPeca.Name = "txtPrecoPeca";
            this.txtPrecoPeca.PlaceholderText = "Valor Unitario";
            this.txtPrecoPeca.Size = new System.Drawing.Size(100, 23);
            this.txtPrecoPeca.TabIndex = 2;
            this.txtPrecoPeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantidadepecaVendida
            // 
            this.txtQuantidadepecaVendida.Location = new System.Drawing.Point(251, 52);
            this.txtQuantidadepecaVendida.Name = "txtQuantidadepecaVendida";
            this.txtQuantidadepecaVendida.PlaceholderText = "Quantidade";
            this.txtQuantidadepecaVendida.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidadepecaVendida.TabIndex = 3;
            this.txtQuantidadepecaVendida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(362, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar Peça";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbVendedoresCadastrados
            // 
            this.cmbVendedoresCadastrados.FormattingEnabled = true;
            this.cmbVendedoresCadastrados.Location = new System.Drawing.Point(102, 8);
            this.cmbVendedoresCadastrados.Name = "cmbVendedoresCadastrados";
            this.cmbVendedoresCadastrados.Size = new System.Drawing.Size(129, 23);
            this.cmbVendedoresCadastrados.TabIndex = 5;
            // 
            // lblVendedorNome
            // 
            this.lblVendedorNome.AutoSize = true;
            this.lblVendedorNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVendedorNome.Location = new System.Drawing.Point(12, 9);
            this.lblVendedorNome.Name = "lblVendedorNome";
            this.lblVendedorNome.Size = new System.Drawing.Size(71, 19);
            this.lblVendedorNome.TabIndex = 6;
            this.lblVendedorNome.Text = "Vendedor:";
            // 
            // ltbListaDePecas
            // 
            this.ltbListaDePecas.FormattingEnabled = true;
            this.ltbListaDePecas.ItemHeight = 15;
            this.ltbListaDePecas.Location = new System.Drawing.Point(12, 94);
            this.ltbListaDePecas.Name = "ltbListaDePecas";
            this.ltbListaDePecas.Size = new System.Drawing.Size(478, 184);
            this.ltbListaDePecas.TabIndex = 7;
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(251, 8);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(100, 23);
            this.mtbData.TabIndex = 8;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // frmComissionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(516, 290);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.ltbListaDePecas);
            this.Controls.Add(this.lblVendedorNome);
            this.Controls.Add(this.cmbVendedoresCadastrados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQuantidadepecaVendida);
            this.Controls.Add(this.txtPrecoPeca);
            this.Controls.Add(this.txtPecaCodigo);
            this.Name = "frmComissionamento";
            this.Text = "Comissão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPecaCodigo;
        private TextBox txtPrecoPeca;
        private TextBox txtQuantidadepecaVendida;
        private Button button1;
        private ComboBox cmbVendedoresCadastrados;
        private Label lblVendedorNome;
        private ListBox ltbListaDePecas;
        private MaskedTextBox mtbData;
    }
}