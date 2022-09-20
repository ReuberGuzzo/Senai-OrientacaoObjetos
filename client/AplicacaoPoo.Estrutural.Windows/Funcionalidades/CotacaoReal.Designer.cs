namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    partial class frmCotacaoReal
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
            this.lblCotacao = new System.Windows.Forms.Label();
            this.txtCotacaoDolar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarteiraDolar = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCotacao
            // 
            this.lblCotacao.AutoSize = true;
            this.lblCotacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCotacao.Location = new System.Drawing.Point(12, 78);
            this.lblCotacao.Name = "lblCotacao";
            this.lblCotacao.Size = new System.Drawing.Size(190, 21);
            this.lblCotacao.Text = "Digite a Cotação do Dolar:";
            // 
            // txtCotacaoDolar
            // 
            this.txtCotacaoDolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCotacaoDolar.Location = new System.Drawing.Point(219, 70);
            this.txtCotacaoDolar.Name = "txtCotacaoDolar";
            this.txtCotacaoDolar.Size = new System.Drawing.Size(100, 29);
            this.txtCotacaoDolar.TextChanged += new System.EventHandler(this.txtCotacaoDolar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.Text = "Digite o Valor em Dolar:";
            // 
            // txtCarteiraDolar
            // 
            this.txtCarteiraDolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCarteiraDolar.Location = new System.Drawing.Point(219, 22);
            this.txtCarteiraDolar.Name = "txtCarteiraDolar";
            this.txtCarteiraDolar.Size = new System.Drawing.Size(100, 29);
            this.txtCarteiraDolar.TextChanged += new System.EventHandler(this.txtCarteiraDolar_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(98, 114);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(138, 38);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCotacaoReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(343, 174);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCarteiraDolar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCotacaoDolar);
            this.Controls.Add(this.lblCotacao);
            this.Name = "frmCotacaoReal";
            this.Text = "Cotacao Dolar/Real";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCotacao;
        private TextBox txtCotacaoDolar;
        private Label label1;
        private TextBox txtCarteiraDolar;
        private Button btnCalcular;
    }
}