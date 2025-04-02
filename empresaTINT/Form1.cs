using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresaTINT
{
    public partial class Form1 : Form
    {
        public Form1()//construtor
        {
            InitializeComponent();
            DAO conexao = new DAO();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }//fim do form load

        private void label1_Click(object sender, EventArgs e)
        {

        }//fim do titulo

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();
        }//fim do botão cadastrar

        private void Consultar_Click(object sender, EventArgs e)
        {
            Consultar con = new Consultar();
            con.ShowDialog();
        }//fim do botão consultar

        private void Atualizar_Click(object sender, EventArgs e)
        {
            Atualizar atul = new Atualizar();
            atul.ShowDialog();
        }//fim do botão Atualizar

        private void Excluir_Click(object sender, EventArgs e)
        {
            Excluir exc = new Excluir();
            exc.ShowDialog();
        }//fim do botão Excluir
    }//fim da classe
}//fim do projeto
