namespace AplicacaoPOO.Windows
{
    partial class frmCliente
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblValorDebito = new System.Windows.Forms.Label();
            this.lblValorCredito = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtValorDebito = new System.Windows.Forms.TextBox();
            this.txtValorCredito = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.lblSaldoInicialValor = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(24, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(24, 46);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 15);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF";
            // 
            // lblValorDebito
            // 
            this.lblValorDebito.AutoSize = true;
            this.lblValorDebito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorDebito.Location = new System.Drawing.Point(24, 75);
            this.lblValorDebito.Name = "lblValorDebito";
            this.lblValorDebito.Size = new System.Drawing.Size(93, 15);
            this.lblValorDebito.TabIndex = 2;
            this.lblValorDebito.Text = "Valor de Debito";
            // 
            // lblValorCredito
            // 
            this.lblValorCredito.AutoSize = true;
            this.lblValorCredito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorCredito.Location = new System.Drawing.Point(24, 108);
            this.lblValorCredito.Name = "lblValorCredito";
            this.lblValorCredito.Size = new System.Drawing.Size(96, 15);
            this.lblValorCredito.TabIndex = 3;
            this.lblValorCredito.Text = "Valor de Credito";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(70, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 23);
            this.txtNome.TabIndex = 4;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(70, 38);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(164, 23);
            this.txtCpf.TabIndex = 5;
            // 
            // txtValorDebito
            // 
            this.txtValorDebito.Location = new System.Drawing.Point(124, 67);
            this.txtValorDebito.Name = "txtValorDebito";
            this.txtValorDebito.Size = new System.Drawing.Size(110, 23);
            this.txtValorDebito.TabIndex = 6;
            // 
            // txtValorCredito
            // 
            this.txtValorCredito.Location = new System.Drawing.Point(124, 100);
            this.txtValorCredito.Name = "txtValorCredito";
            this.txtValorCredito.Size = new System.Drawing.Size(110, 23);
            this.txtValorCredito.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(135, 133);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.AutoSize = true;
            this.lblSaldoInicial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoInicial.Location = new System.Drawing.Point(266, 18);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(90, 20);
            this.lblSaldoInicial.TabIndex = 9;
            this.lblSaldoInicial.Text = "Saldo Inicial";
            // 
            // lblSaldoInicialValor
            // 
            this.lblSaldoInicialValor.AutoSize = true;
            this.lblSaldoInicialValor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoInicialValor.Location = new System.Drawing.Point(300, 38);
            this.lblSaldoInicialValor.Name = "lblSaldoInicialValor";
            this.lblSaldoInicialValor.Size = new System.Drawing.Size(17, 20);
            this.lblSaldoInicialValor.TabIndex = 10;
            this.lblSaldoInicialValor.Text = "0";
            this.lblSaldoInicialValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.Location = new System.Drawing.Point(287, 75);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(47, 20);
            this.lblSaldo.TabIndex = 11;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblSaldoValor
            // 
            this.lblSaldoValor.AutoSize = true;
            this.lblSaldoValor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoValor.Location = new System.Drawing.Point(300, 100);
            this.lblSaldoValor.Name = "lblSaldoValor";
            this.lblSaldoValor.Size = new System.Drawing.Size(17, 20);
            this.lblSaldoValor.TabIndex = 12;
            this.lblSaldoValor.Text = "0";
            this.lblSaldoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(368, 168);
            this.Controls.Add(this.lblSaldoValor);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblSaldoInicialValor);
            this.Controls.Add(this.lblSaldoInicial);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorCredito);
            this.Controls.Add(this.txtValorDebito);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblValorCredito);
            this.Controls.Add(this.lblValorDebito);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label lblCpf;
        private Label lblValorDebito;
        private Label lblValorCredito;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtValorDebito;
        private TextBox txtValorCredito;
        private Button btnCalcular;
        private Label lblSaldoInicial;
        private Label lblSaldoInicialValor;
        private Label lblSaldo;
        private Label lblSaldoValor;
    }
}