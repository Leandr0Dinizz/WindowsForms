using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_WindowsForm
{
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO(); // conectar a tela com a classe DAO

        }//fim do construtor

        private void label6_Click(object sender, EventArgs e)
        {

        }// fim código

        private void codigos_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do codigo

        private void nomes_TextChanged(object sender, EventArgs e)
        {

        }//fim do nome

        private void telefones_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do telefone

        private void cidades_TextChanged(object sender, EventArgs e)
        {

        }//fim cidades

        private void estados_TextChanged(object sender, EventArgs e)
        {

        }//fim estado

        private void cadastro_Click(object sender, EventArgs e)
        {

            int cod = Convert.ToInt32(codigos.Text);
            string name = nomes.Text;
            string tel = telefones.Text;
            string cid = cidades.Text;
            string est = estados.Text;
            bd.inserir(cod, name, tel, cid, est); // inserindo no BD
        }//fim botao cadastrar

        private void voltar_Click(object sender, EventArgs e)
        {

        }//fim do botao voltar

        private void codigo_Click(object sender, EventArgs e)
        {

        }
    }// fim da classe
}//fim do projeto
