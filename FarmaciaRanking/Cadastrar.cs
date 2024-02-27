using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaRanking
{
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void codigoo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo Código

        private void nomee_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo Nome

        private void rgg_TextChanged(object sender, EventArgs e)
        {

        }//fim do campo RG

        private void telefonee_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do campo Telefone

        private void plan_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo Plano de Sáude

        private void farmacia_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo Farmácia popular

        private void produto_TextChanged(object sender, EventArgs e)
        {

        }//Fim do campo produto

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(codigoo.Text);
            string name = nomee.Text;
            string rg = rgg.Text;
            string tel = telefonee.Text;
            string plano = plan.Text;
            string farm = farmacia.Text;
            string prod = produto.Text;

            bd.Inserir(cod, name, rg, tel, plano, farm, prod);//Inserindo no BD

            //Limpando os campos
            codigoo.Text = "";
            nomee.Text = "";
            rgg.Text = "";
            telefone.Text = "";
            plan.Text = "";
            farmacia.Text = "";
            produto.Text = "";
        }//fim do botão cadastrar

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

    }//Fim da classe
}//Fim do projeto
