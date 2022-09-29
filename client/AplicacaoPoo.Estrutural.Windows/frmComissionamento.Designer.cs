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
            this.SuspendLayout();
            // 
            // txtPecaCodigo
            // 
            this.txtPecaCodigo.Location = new System.Drawing.Point(12, 41);
            this.txtPecaCodigo.Name = "txtPecaCodigo";
            this.txtPecaCodigo.PlaceholderText = "Codigo da Peça";
            this.txtPecaCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtPecaCodigo.TabIndex = 1;
            this.txtPecaCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecoPeca
            // 
            this.txtPrecoPeca.Location = new System.Drawing.Point(12, 84);
            this.txtPrecoPeca.Name = "txtPrecoPeca";
            this.txtPrecoPeca.PlaceholderText = "Valor Unitario";
            this.txtPrecoPeca.Size = new System.Drawing.Size(100, 23);
            this.txtPrecoPeca.TabIndex = 2;
            this.txtPrecoPeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantidadepecaVendida
            // 
            this.txtQuantidadepecaVendida.Location = new System.Drawing.Point(12, 127);
            this.txtQuantidadepecaVendida.Name = "txtQuantidadepecaVendida";
            this.txtQuantidadepecaVendida.PlaceholderText = "Quantidade";
            this.txtQuantidadepecaVendida.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidadepecaVendida.TabIndex = 3;
            this.txtQuantidadepecaVendida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(12, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adcionar Peça";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cmbVendedoresCadastrados
            // 
            this.cmbVendedoresCadastrados.FormattingEnabled = true;
            this.cmbVendedoresCadastrados.Items.AddRange(new object[] {
            "1 - Reuber",
            "2 - João",
            "3 - Shamyra",
            "4 - Jeanderson",
            "5 - Welton"});
            this.cmbVendedoresCadastrados.Location = new System.Drawing.Point(89, 8);
            this.cmbVendedoresCadastrados.Name = "cmbVendedoresCadastrados";
            this.cmbVendedoresCadastrados.Size = new System.Drawing.Size(129, 23);
            this.cmbVendedoresCadastrados.TabIndex = 5;
            this.cmbVendedoresCadastrados.ValueMemberChanged += new System.EventHandler(this.comboBox1_ValueMemberChanged);
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
            this.ltbListaDePecas.Location = new System.Drawing.Point(139, 43);
            this.ltbListaDePecas.Name = "ltbListaDePecas";
            this.ltbListaDePecas.Size = new System.Drawing.Size(291, 154);
            this.ltbListaDePecas.TabIndex = 7;
            // 
            // frmComissionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 245);
            this.Controls.Add(this.ltbListaDePecas);
            this.Controls.Add(this.lblVendedorNome);
            this.Controls.Add(this.cmbVendedoresCadastrados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQuantidadepecaVendida);
            this.Controls.Add(this.txtPrecoPeca);
            this.Controls.Add(this.txtPecaCodigo);
            this.Name = "frmComissionamento";
            this.Text = "frmComissionamento";
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
    }
}