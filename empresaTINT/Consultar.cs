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
    public partial class Consultar : Form
    {

        DAO consul;
        public Consultar()
        {
            consul= new DAO();
            InitializeComponent();
            ConfigurarDataGrid();//configuro a estrutura da coluna e linha
            NomeColunas();// nomeando as colunas
            AdicionarDados();//adicionando os dados para visualização
        }//fim do construtor

        private void label1_Click(object sender, EventArgs e)
        {

        }//fim do titulo consultar

        private void button1_Click(object sender, EventArgs e)
        {

        }//fim do botão consultar

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa endereço

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa telefone

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa nome

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa codigo

        private void label5_Click(object sender, EventArgs e)
        {

        }// fim do telefone

        private void label4_Click(object sender, EventArgs e)
        {

        }// fim do endereço

        private void label3_Click(object sender, EventArgs e)
        {

        }//fim do nome

        private void label2_Click(object sender, EventArgs e)
        {

        }//fim do  codigo

        private void Voltar_Click(object sender, EventArgs e)
        {
          this.Close();
  
        }//voltar botão

        private void Consultar_Load(object sender, EventArgs e)
        {
            
        }//consultar botão

        public void NomeColunas() 
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Endereço";

        }//fim do NomeColunas

        public void ConfigurarDataGrid() 
        { 
            dataGridView1.AllowUserToAddRows= false;//não pode adicionar linha o ususario
            dataGridView1.AllowUserToDeleteRows = false;//não pode apagar linha o ususario
            dataGridView1.AllowUserToResizeColumns = false;//não pode redimencionar colunas 
            dataGridView1.AllowUserToResizeRows = false;// não pode redimencionar linhas
            dataGridView1.ColumnCount = 4; // quantidade de colunas 
        }//fim do ConfigurarDataGrid

        public void AdicionarDados()
        {
            consul.PreencherVetor();//Preencher os vetores c/ dados do banco
            for (int i=0;i < consul.QuantidadeDeDados();i++)//para qunado preencher todos os dados
            {
                dataGridView1.Rows.Add(consul.codigo[i], consul.nome[i], consul.telefone[i], consul.endereco[i]);//colocando para preencher//nomes da classe DAO;nomne dos vetores
            }//fim do for 
        }//fim do AdicionarDados


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do dataGridView
    }
}
