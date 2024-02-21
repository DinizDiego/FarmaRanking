using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaRanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//fim do construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }//faz o carregamento de conteúdos da minha tela

        private void cadastrarCliente_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Aparecer a tela cadastrar
        }//fim do método cadastrar
    }//fim da classe
}//fim do projeto
