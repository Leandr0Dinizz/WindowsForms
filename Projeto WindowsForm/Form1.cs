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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();
        }// fim cadastrar

        private void consultar_Click(object sender, EventArgs e)
        {

        }// fim consultar

        private void atualizar_Click(object sender, EventArgs e)
        {

        }// fim atualizar

        private void excluir_Click(object sender, EventArgs e)
        {

        }// fim excluir
    }
}
