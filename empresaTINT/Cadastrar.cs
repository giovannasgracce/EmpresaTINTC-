using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;//para usar o banco
using MySql.Data.MySqlClient;//para usar o banco

namespace empresaTINT
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }// fim do campo endereço

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciando a classe DAO
            DAO inserir= new DAO(); // chamando a classe DAO 
            //Coelntando os dados dos campos
            int codigo = Convert.ToInt32(textBox1.Text);
            string nome = textBox2.Text;
            string telefone = textBox3.Text;
            string endereco = textBox4.Text;

            //chamando o método Inserir
            MessageBox.Show(inserir.Inserir(codigo,nome,telefone,endereco ));
            this.Close();//Fechar a janela cadastrar
        }// fim do botão cadastrar

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();   
    
        }// fim do botão voltar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa codigo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa endereço
    }//fim da classe
}//fim do projeto
