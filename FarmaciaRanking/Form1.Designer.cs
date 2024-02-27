namespace FarmaciaRanking
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadastrarCliente = new System.Windows.Forms.Button();
            this.cadastrarProduto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cadastrarCliente
            // 
            this.cadastrarCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarCliente.Location = new System.Drawing.Point(61, 103);
            this.cadastrarCliente.Name = "cadastrarCliente";
            this.cadastrarCliente.Size = new System.Drawing.Size(162, 58);
            this.cadastrarCliente.TabIndex = 0;
            this.cadastrarCliente.Text = "Cadastrar Cliente";
            this.cadastrarCliente.UseVisualStyleBackColor = true;
            this.cadastrarCliente.Click += new System.EventHandler(this.cadastrarCliente_Click);
            // 
            // cadastrarProduto
            // 
            this.cadastrarProduto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarProduto.Location = new System.Drawing.Point(312, 103);
            this.cadastrarProduto.Name = "cadastrarProduto";
            this.cadastrarProduto.Size = new System.Drawing.Size(162, 58);
            this.cadastrarProduto.TabIndex = 1;
            this.cadastrarProduto.Text = "Cadastrar Produto";
            this.cadastrarProduto.UseVisualStyleBackColor = true;
            this.cadastrarProduto.Click += new System.EventHandler(this.cadastrarProduto_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Firebrick;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(179, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 43);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Bem Vindo!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmaciaRanking.Properties.Resources.wallpapers_crfrs_81;
            this.ClientSize = new System.Drawing.Size(529, 521);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cadastrarProduto);
            this.Controls.Add(this.cadastrarCliente);
            this.Name = "Form1";
            this.Text = "FarmaRanking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrarCliente;
        private System.Windows.Forms.Button cadastrarProduto;
        private System.Windows.Forms.TextBox textBox1;
    }
}

