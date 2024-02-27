namespace FarmaciaRanking
{
    partial class CadastrarProduto
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
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.TextBox();
            this.custo = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.TextBox();
            this.custoProduto = new System.Windows.Forms.TextBox();
            this.quantidadeProduto = new System.Windows.Forms.TextBox();
            this.nomeProduto = new System.Windows.Forms.TextBox();
            this.codigoProduto = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastrar.Location = new System.Drawing.Point(261, 435);
            this.botaoCadastrar.Margin = new System.Windows.Forms.Padding(5);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(335, 94);
            this.botaoCadastrar.TabIndex = 34;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.Location = new System.Drawing.Point(261, 539);
            this.botaoVoltar.Margin = new System.Windows.Forms.Padding(5);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(335, 65);
            this.botaoVoltar.TabIndex = 33;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cadastrar Produto";
            // 
            // quantidade
            // 
            this.quantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.quantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantidade.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidade.Location = new System.Drawing.Point(86, 284);
            this.quantidade.Margin = new System.Windows.Forms.Padding(5);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(128, 18);
            this.quantidade.TabIndex = 28;
            this.quantidade.Text = "Quantidade";
            // 
            // custo
            // 
            this.custo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.custo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custo.Location = new System.Drawing.Point(86, 347);
            this.custo.Margin = new System.Windows.Forms.Padding(5);
            this.custo.Name = "custo";
            this.custo.Size = new System.Drawing.Size(128, 18);
            this.custo.TabIndex = 27;
            this.custo.Text = "Custo";
            // 
            // nome
            // 
            this.nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(86, 224);
            this.nome.Margin = new System.Windows.Forms.Padding(5);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(128, 18);
            this.nome.TabIndex = 26;
            this.nome.Text = "Nome";
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codigo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(86, 160);
            this.codigo.Margin = new System.Windows.Forms.Padding(5);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(128, 18);
            this.codigo.TabIndex = 25;
            this.codigo.Text = "Código";
            // 
            // custoProduto
            // 
            this.custoProduto.Location = new System.Drawing.Point(472, 347);
            this.custoProduto.Margin = new System.Windows.Forms.Padding(5);
            this.custoProduto.Name = "custoProduto";
            this.custoProduto.Size = new System.Drawing.Size(314, 20);
            this.custoProduto.TabIndex = 22;
            this.custoProduto.TextChanged += new System.EventHandler(this.custoProduto_TextChanged);
            // 
            // quantidadeProduto
            // 
            this.quantidadeProduto.Location = new System.Drawing.Point(472, 279);
            this.quantidadeProduto.Margin = new System.Windows.Forms.Padding(5);
            this.quantidadeProduto.Name = "quantidadeProduto";
            this.quantidadeProduto.Size = new System.Drawing.Size(314, 20);
            this.quantidadeProduto.TabIndex = 21;
            this.quantidadeProduto.TextChanged += new System.EventHandler(this.quantidadeProduto_TextChanged);
            // 
            // nomeProduto
            // 
            this.nomeProduto.Location = new System.Drawing.Point(472, 219);
            this.nomeProduto.Margin = new System.Windows.Forms.Padding(5);
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(314, 20);
            this.nomeProduto.TabIndex = 20;
            this.nomeProduto.TextChanged += new System.EventHandler(this.nomeProduto_TextChanged);
            // 
            // codigoProduto
            // 
            this.codigoProduto.Location = new System.Drawing.Point(472, 149);
            this.codigoProduto.Margin = new System.Windows.Forms.Padding(5);
            this.codigoProduto.Mask = "999999";
            this.codigoProduto.Name = "codigoProduto";
            this.codigoProduto.Size = new System.Drawing.Size(314, 20);
            this.codigoProduto.TabIndex = 19;
            this.codigoProduto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codigoProduto_MaskInputRejected);
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(870, 627);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.custo);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.custoProduto);
            this.Controls.Add(this.quantidadeProduto);
            this.Controls.Add(this.nomeProduto);
            this.Controls.Add(this.codigoProduto);
            this.Name = "CadastrarProduto";
            this.Text = "CadastrarProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.TextBox custo;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox custoProduto;
        private System.Windows.Forms.TextBox quantidadeProduto;
        private System.Windows.Forms.TextBox nomeProduto;
        private System.Windows.Forms.MaskedTextBox codigoProduto;
    }
}