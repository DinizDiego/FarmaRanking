using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaRanking
{
    public partial class CadastrarProduto : Form
    {
        DAO bd;
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void codigoProduto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo código

        private void nomeProduto_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo nome

        private void quantidadeProduto_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo quantidade

        private void custoProduto_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo custo

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(codigoProduto.Text);
            string nome = nomeProduto.Text;
            int quantidade = Convert.ToInt32(quantidadeProduto.Text);
            int custo = Convert.ToInt32(custoProduto.Text);

            bd.InserirProduto(codigo, nome, quantidade, custo);//Inserindo no BD

            //Limpando os campos
            codigoProduto.Text = "";
            nomeProduto.Text = "";
            quantidadeProduto.Text = "";
            custoProduto.Text = "";

            //Limpando os campos
            codigoProduto.Text = "";
            nomeProduto.Text = "";
            quantidadeProduto.Text = "";
            custoProduto.Text = "";
        }//Fim do botão cadastrar

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do botão voltar

    }//Fim da classe
}//Fim do Projeto
