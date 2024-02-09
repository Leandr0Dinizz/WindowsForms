using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Projeto_WindowsForm
{
    internal class DAO
    {


        MySqlConnection conexao;
        public string dados;
        public string sql;

        public DAO()
        {

            conexao = new MySqlConnection("server=localhost;Database=ti18n;Uid=root;password=");
            try
            {
                conexao.Open();
                MessageBox.Show("Conectado com sucesso!");//TEMPORARIAMENTE
            }   
            catch (Exception erro)
            {


                MessageBox.Show(erro + "\nAlgo deu errado!");
                conexao.Close();
            }//fim do catch


        }// fim da DAO

        public void inserir(int codigo, string nome, string telefone, string cidade, string estado)
        {

            dados = "('" + codigo + "','" + nome + "','" + telefone + "','" + cidade + "','" + estado + "')";
            sql = "insert into pessoa(codigo, nome, telefone, cidade, estado) values " + dados;

            MySqlCommand conn = new MySqlCommand(sql, conexao);//prepara o comando no banco
            MessageBox.Show("1 Dado Inserido" + conn.ExecuteNonQuery());


        }//fim do inserir

    }//fim da classe
}// fim do projeto
