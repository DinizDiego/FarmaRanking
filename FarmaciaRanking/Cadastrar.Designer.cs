namespace FarmaciaRanking
{
    partial class Cadastrar
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
            this.telefonee = new System.Windows.Forms.MaskedTextBox();
            this.codigoo = new System.Windows.Forms.MaskedTextBox();
            this.nomee = new System.Windows.Forms.TextBox();
            this.rgg = new System.Windows.Forms.TextBox();
            this.plan = new System.Windows.Forms.TextBox();
            this.farmacia = new System.Windows.Forms.TextBox();
            this.produto = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.rg = new System.Windows.Forms.TextBox();
            this.planoDeSaude = new System.Windows.Forms.TextBox();
            this.farmaciaPopular = new System.Windows.Forms.TextBox();
            this.produtos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.caixaNao = new System.Windows.Forms.CheckBox();
            this.caixaSim = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // telefonee
            // 
            this.telefonee.Location = new System.Drawing.Point(475, 304);
            this.telefonee.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.telefonee.Mask = "(99)99999-9999";
            this.telefonee.Name = "telefonee";
            this.telefonee.Size = new System.Drawing.Size(314, 29);
            this.telefonee.TabIndex = 0;
            this.telefonee.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefonee_MaskInputRejected);
            // 
            // codigoo
            // 
            this.codigoo.Location = new System.Drawing.Point(475, 122);
            this.codigoo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.codigoo.Mask = "999999";
            this.codigoo.Name = "codigoo";
            this.codigoo.Size = new System.Drawing.Size(314, 29);
            this.codigoo.TabIndex = 1;
            this.codigoo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codigoo_MaskInputRejected);
            // 
            // nomee
            // 
            this.nomee.Location = new System.Drawing.Point(475, 181);
            this.nomee.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nomee.Name = "nomee";
            this.nomee.Size = new System.Drawing.Size(314, 29);
            this.nomee.TabIndex = 2;
            this.nomee.TextChanged += new System.EventHandler(this.nomee_TextChanged);
            // 
            // rgg
            // 
            this.rgg.Location = new System.Drawing.Point(475, 241);
            this.rgg.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rgg.Name = "rgg";
            this.rgg.Size = new System.Drawing.Size(314, 29);
            this.rgg.TabIndex = 3;
            this.rgg.TextChanged += new System.EventHandler(this.rgg_TextChanged);
            // 
            // plan
            // 
            this.plan.Location = new System.Drawing.Point(475, 360);
            this.plan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.plan.Name = "plan";
            this.plan.Size = new System.Drawing.Size(314, 29);
            this.plan.TabIndex = 4;
            this.plan.TextChanged += new System.EventHandler(this.plan_TextChanged);
            // 
            // farmacia
            // 
            this.farmacia.Location = new System.Drawing.Point(475, 418);
            this.farmacia.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.farmacia.Name = "farmacia";
            this.farmacia.Size = new System.Drawing.Size(314, 29);
            this.farmacia.TabIndex = 5;
            this.farmacia.TextChanged += new System.EventHandler(this.farmacia_TextChanged);
            // 
            // produto
            // 
            this.produto.Location = new System.Drawing.Point(475, 477);
            this.produto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.produto.Name = "produto";
            this.produto.Size = new System.Drawing.Size(314, 29);
            this.produto.TabIndex = 6;
            this.produto.TextChanged += new System.EventHandler(this.produto_TextChanged);
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codigo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(89, 133);
            this.codigo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(128, 18);
            this.codigo.TabIndex = 7;
            this.codigo.Text = "Código";
            // 
            // nome
            // 
            this.nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(89, 192);
            this.nome.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(128, 18);
            this.nome.TabIndex = 8;
            this.nome.Text = "Nome";
            // 
            // telefone
            // 
            this.telefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(89, 315);
            this.telefone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(128, 18);
            this.telefone.TabIndex = 9;
            this.telefone.Text = "Telefone";
            // 
            // rg
            // 
            this.rg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rg.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg.Location = new System.Drawing.Point(89, 252);
            this.rg.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(128, 18);
            this.rg.TabIndex = 10;
            this.rg.Text = "RG";
            // 
            // planoDeSaude
            // 
            this.planoDeSaude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.planoDeSaude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.planoDeSaude.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planoDeSaude.Location = new System.Drawing.Point(89, 371);
            this.planoDeSaude.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.planoDeSaude.Name = "planoDeSaude";
            this.planoDeSaude.Size = new System.Drawing.Size(202, 18);
            this.planoDeSaude.TabIndex = 11;
            this.planoDeSaude.Text = "Plano de sáude";
            // 
            // farmaciaPopular
            // 
            this.farmaciaPopular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.farmaciaPopular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.farmaciaPopular.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.farmaciaPopular.Location = new System.Drawing.Point(89, 429);
            this.farmaciaPopular.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.farmaciaPopular.Name = "farmaciaPopular";
            this.farmaciaPopular.Size = new System.Drawing.Size(202, 18);
            this.farmaciaPopular.TabIndex = 12;
            this.farmaciaPopular.Text = "Farmácia Popular";
            // 
            // produtos
            // 
            this.produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.produtos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.produtos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtos.Location = new System.Drawing.Point(89, 477);
            this.produtos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.produtos.Name = "produtos";
            this.produtos.Size = new System.Drawing.Size(128, 18);
            this.produtos.TabIndex = 13;
            this.produtos.Text = "Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastrar Cliente";
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.Location = new System.Drawing.Point(265, 649);
            this.botaoVoltar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(335, 65);
            this.botaoVoltar.TabIndex = 16;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastrar.Location = new System.Drawing.Point(265, 546);
            this.botaoCadastrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(335, 94);
            this.botaoCadastrar.TabIndex = 17;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // caixaNao
            // 
            this.caixaNao.AutoSize = true;
            this.caixaNao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaNao.Location = new System.Drawing.Point(379, 362);
            this.caixaNao.Name = "caixaNao";
            this.caixaNao.Size = new System.Drawing.Size(64, 27);
            this.caixaNao.TabIndex = 85;
            this.caixaNao.Text = "Não";
            this.caixaNao.UseVisualStyleBackColor = true;
            // 
            // caixaSim
            // 
            this.caixaSim.AutoSize = true;
            this.caixaSim.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaSim.Location = new System.Drawing.Point(268, 362);
            this.caixaSim.Name = "caixaSim";
            this.caixaSim.Size = new System.Drawing.Size(62, 27);
            this.caixaSim.TabIndex = 84;
            this.caixaSim.Text = "Sim";
            this.caixaSim.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(379, 418);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 27);
            this.checkBox1.TabIndex = 87;
            this.checkBox1.Text = "Não";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(268, 420);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(62, 27);
            this.checkBox2.TabIndex = 86;
            this.checkBox2.Text = "Sim";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(833, 727);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.caixaNao);
            this.Controls.Add(this.caixaSim);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produtos);
            this.Controls.Add(this.farmaciaPopular);
            this.Controls.Add(this.planoDeSaude);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.produto);
            this.Controls.Add(this.farmacia);
            this.Controls.Add(this.plan);
            this.Controls.Add(this.rgg);
            this.Controls.Add(this.nomee);
            this.Controls.Add(this.codigoo);
            this.Controls.Add(this.telefonee);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox telefonee;
        private System.Windows.Forms.MaskedTextBox codigoo;
        private System.Windows.Forms.TextBox nomee;
        private System.Windows.Forms.TextBox rgg;
        private System.Windows.Forms.TextBox plan;
        private System.Windows.Forms.TextBox farmacia;
        private System.Windows.Forms.TextBox produto;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox rg;
        private System.Windows.Forms.TextBox planoDeSaude;
        private System.Windows.Forms.TextBox farmaciaPopular;
        private System.Windows.Forms.TextBox produtos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.CheckBox caixaNao;
        private System.Windows.Forms.CheckBox caixaSim;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}