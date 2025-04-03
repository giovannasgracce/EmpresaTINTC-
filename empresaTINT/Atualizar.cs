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
    public partial class Atualizar : Form
    {
        DAO atu;
        public Atualizar()
        {
            atu = new DAO();
            InitializeComponent();
            textBox1.ReadOnly= false;//bloqueia o 1 e libera os outros
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void VoltarAtualizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

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

        private void AtualizarNovo_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);//pegar oq os usuarios digitou
            string nome =textBox2.Text;
            string telefone = textBox3.Text;
            string endereco = textBox4.Text;

            atu.Atualizar(codigo, "nome", nome);
            atu.Atualizar(codigo, "telefone", telefone);
            atu.Atualizar(codigo, "endereco", endereco);
            MessageBox.Show("Dados atualizados com sucesso!!");
            this.Close();
           
        }//fim do botão atualizar

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox2.Text = "Preencha o código";
                textBox3.Text = "Preencha o código";
                textBox4.Text = "Preencha o código";
            }
            else
            {


                int codigo = Convert.ToInt32(textBox1.Text);//Coletando o código

                textBox2.Text = atu.RetornarNome(codigo);//Preenchendo o campo nome
                textBox3.Text = atu.RetornarTelefone(codigo);//Preenchendo o campo telefone
                textBox4.Text = atu.RetornarEndereco(codigo);//Preenchendo o campo endereco
                textBox1.ReadOnly = true;// deixa apenas leitura
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
        }//botão de busca
    }//fim da classe
}//fim do projeto

