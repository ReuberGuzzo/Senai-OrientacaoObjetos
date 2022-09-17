namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    partial class frmComissao
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
            this.lblIdVendedor = new System.Windows.Forms.Label();
            this.lblCodPeca = new System.Windows.Forms.Label();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmbNomes = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIdVendedor
            // 
            this.lblIdVendedor.AutoSize = true;
            this.lblIdVendedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdVendedor.Location = new System.Drawing.Point(21, 20);
            this.lblIdVendedor.Name = "lblIdVendedor";
            this.lblIdVendedor.Size = new System.Drawing.Size(121, 21);
            this.lblIdVendedor.TabIndex = 0;
            this.lblIdVendedor.Text = "ID do Vendedor:";
            // 
            // lblCodPeca
            // 
            this.lblCodPeca.AutoSize = true;
            this.lblCodPeca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodPeca.Location = new System.Drawing.Point(21, 57);
            this.lblCodPeca.Name = "lblCodPeca";
            this.lblCodPeca.Size = new System.Drawing.Size(119, 21);
            this.lblCodPeca.TabIndex = 2;
            this.lblCodPeca.Text = "Codigo da Peça:";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorUnitario.Location = new System.Drawing.Point(21, 96);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(109, 21);
            this.lblValorUnitario.TabIndex = 4;
            this.lblValorUnitario.Text = "Valor Unitario:";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorUnitario.Location = new System.Drawing.Point(148, 88);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(100, 29);
            this.txtValorUnitario.TabIndex = 5;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidade.Location = new System.Drawing.Point(21, 138);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(94, 21);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantidade.Location = new System.Drawing.Point(148, 130);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 29);
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor de Comissão :";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.SkyBlue;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(296, 88);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 27);
            this.txtResultado.TabIndex = 9;
            // 
            // cmbNomes
            // 
            this.cmbNomes.AutoCompleteCustomSource.AddRange(new string[] {
            "1 - João",
            "2 - José",
            "3 - Mateus",
            "4 - Roberto",
            "5 - Reuber",
            "6 - Welton"});
            this.cmbNomes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbNomes.FormattingEnabled = true;
            this.cmbNomes.Items.AddRange(new object[] {
            "1 - Reuber",
            "2 - João",
            "3 - José"});
            this.cmbNomes.Location = new System.Drawing.Point(148, 12);
            this.cmbNomes.Name = "cmbNomes";
            this.cmbNomes.Size = new System.Drawing.Size(100, 29);
            this.cmbNomes.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "001 - Parafuso",
            "002 - Arruela",
            "003 - Spray Preto",
            "004 - Polca",
            "005 - Mouse",
            "006 - Teclado",
            "007 - Molinete",
            "008 - Carretilha",
            "009 - Anzol",
            "010 - Boia",
            "011 - Linha de Pesca 0,35",
            "012 - Chumbo 2g "});
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "001 - Carretilha",
            "002 - Molinete",
            "003 - Anzol",
            "004 - Linha de Pesca",
            "005 - Chumbo",
            "006 - Boia",
            "007 - Vara de Pesca"});
            this.comboBox1.Location = new System.Drawing.Point(148, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 29);
            this.comboBox1.TabIndex = 11;
            // 
            // frmComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(451, 181);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbNomes);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.lblCodPeca);
            this.Controls.Add(this.lblIdVendedor);
            this.Name = "frmComissao";
            this.Text = "Comissao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIdVendedor;
        private Label lblCodPeca;
        private Label lblValorUnitario;
        private TextBox txtValorUnitario;
        private Label lblQuantidade;
        private TextBox txtQuantidade;
        private Label label1;
        private TextBox txtResultado;
        private ComboBox cmbNomes;
        private ComboBox comboBox1;
    }
}