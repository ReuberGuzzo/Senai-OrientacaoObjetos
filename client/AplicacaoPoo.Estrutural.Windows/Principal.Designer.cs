namespace AplicacaoPoo.Estrutural.Windows
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnCotacaoReal = new System.Windows.Forms.Button();
            this.btnComissao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCotacaoReal
            // 
            this.btnCotacaoReal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCotacaoReal.Image = ((System.Drawing.Image)(resources.GetObject("btnCotacaoReal.Image")));
            this.btnCotacaoReal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCotacaoReal.Location = new System.Drawing.Point(38, 12);
            this.btnCotacaoReal.Name = "btnCotacaoReal";
            this.btnCotacaoReal.Size = new System.Drawing.Size(155, 74);
            this.btnCotacaoReal.TabIndex = 0;
            this.btnCotacaoReal.Text = "Cotação \r\nDolar\r\nReal";
            this.btnCotacaoReal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCotacaoReal.UseVisualStyleBackColor = true;
            this.btnCotacaoReal.Click += new System.EventHandler(this.btnCotacao_Click);
            // 
            // btnComissao
            // 
            this.btnComissao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComissao.Image = ((System.Drawing.Image)(resources.GetObject("btnComissao.Image")));
            this.btnComissao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComissao.Location = new System.Drawing.Point(218, 12);
            this.btnComissao.Name = "btnComissao";
            this.btnComissao.Size = new System.Drawing.Size(155, 74);
            this.btnComissao.TabIndex = 1;
            this.btnComissao.Text = "Comissão \r\nVendas";
            this.btnComissao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComissao.UseVisualStyleBackColor = true;
            this.btnComissao.Click += new System.EventHandler(this.btnComissao_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(414, 110);
            this.Controls.Add(this.btnComissao);
            this.Controls.Add(this.btnCotacaoReal);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCotacaoReal;
        private Button btnComissao;
    }
}