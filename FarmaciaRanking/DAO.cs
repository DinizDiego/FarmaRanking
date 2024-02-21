using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FarmaciaRanking
{
    class DAO
    {
        MySqlConnection conexao;
        public string dados;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=Farmaciati18n;Uid=root;Password=");
            try
            {
                conexao.Open();
                MessageBox.Show("Conectado com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + "\n\nAlgo deu errado");
                conexao.Close();
            }//Fim do catch
        }//Fim do construtor

        public void inserir(int codigo, string nome, string rg, string telefone, bool plan, bool farmacia, string produto)
        {
            dados = "('" + codigo + "','" + nome + "','" + rg + "','" + telefone + "','" + plan + "','" + farmacia + "','" + produto + "')"; 

        }//fim do método

    }//Fim da classe
}//Fim do projeto
