using System;
using System.Collections.Generic;
using System.Drawing;
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
        public string sql;
        public int[] codigo;
        public string[] nome;
        public string[] rg;
        public string[] telefone;
        public string[] plan;
        public string[] farmacia;
        public string[] produto;
        public string[] codigoProduto;
        public string[] nomeProduto;
        public int[] quantidade;
        public int[] custo;
        public int i;
        public int contador;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=FarmaRanking;Uid=root;Password=");
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

        public void Inserir(int codigo, string nome, string rg, string telefone, string plan, string farmacia, string produto)
        {
            dados = "('" + codigo + "','" + nome + "','" + rg + "','" + telefone + "','" + plan + "','" + farmacia + "','" + produto + "')";
            sql = "insert into pessoa(codigo, nome, rg, telefone, plan, farmacia, produto) values" + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + " dado inserido!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do método

        public void PreencherVetor()
        {
            string query = "select * from pessoa";

            //Instanciar os vetores
            this.codigo = new int[100];
            this.nome = new string[100];
            this.rg = new string[100];
            this.telefone = new string[100];
            this.plan = new string[100];
            this.farmacia = new string[100];
            this.produto = new string[100];

            //Preencher com valores genéricos
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                nome[i] = "";
                rg[i] = "";
                telefone[i] = "";
                plan[i] = "";
                farmacia[i] = "";
                produto[i] = "";
            }//fim do for

            //Criar o comando de consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Listar todos os dados que estão no banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;//Utilizar novamente o contar i
            contador = 0;//Contar quantos dados eu tenho no banco
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = "" + leitura["nome"];
                rg[i] = "" + leitura["RG"];
                telefone[i] = "" + leitura["telefone"];
                plan[i] = "" + leitura["Plano de Sáude"];
                farmacia[i] = "" + leitura["Farmácia"];
                produto[i] = "" + leitura["Produto(s)"];
                i++;//Mudando o contador
                contador++;//Contar quantos dados tem no banco
            }//fim do while

            //Encerrar o banco
            leitura.Close();
        }//fim do método

        public int RetornarContagem()
        {
            return contador;
        }//fim do método

        public int SelecionarPorCodigo(int id)
        {
            PreencherVetor();

            for (int i = 0; i < RetornarContagem(); i++)
            {
                if (codigo[i] == id)
                {
                    return i;
                }//fim do if
            }//fim do for
            return -1;//Flag
        }//fim do método

        public void InserirProduto(int codigo, string nome, int quantidade, int custo)
        {
            dados = "('" + codigo + "','" + nome + "','" + quantidade + "','" + custo + "')";
            sql = "insert into pessoa(codigo, nome, quantidade, custo) values" + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + " dado inserido!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do método

        public void PreencherVetorProduto()
        {
            string query = "select * from pessoa";

            //Instanciar os vetores
            this.codigo = new int[100];
            this.nome = new string[100];
            this.quantidade = new int[100];
            this.custo = new int[100];

            //Preencher com valores genéricos
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                nome[i] = "";
                quantidade[i] = 0;
                custo[i] = 0;
            }//fim do for

            //Criar o comando de consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Listar todos os dados que estão no banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;//Utilizar novamente o contar i
            contador = 0;//Contar quantos dados eu tenho no banco
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = "" + leitura["nome"];
                quantidade[i] = Convert.ToInt32(leitura["quantidade"]);
                custo[i] = Convert.ToInt32(leitura["custo"]);
                i++;//Mudando o contador
                contador++;//Contar quantos dados tem no banco
            }//fim do while

            //Encerrar o banco
            leitura.Close();
        }//fim do método

    }//Fim da classe
}//Fim do projeto
