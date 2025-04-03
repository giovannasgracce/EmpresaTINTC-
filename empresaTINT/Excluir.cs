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
    public partial class Excluir : Form
    {
        DAO exc;
        public Excluir()
        {
            exc = new DAO();
            InitializeComponent();
        }

        private void VoltarAtualizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

        private void ExcluirEscrever_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa codigo

        private void ExcluirNovo_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(ExcluirEscrever.Text);
            MessageBox.Show(exc.Excluir(codigo));
            this.Close();

        }//fim do botão excluir

        private void Excluir_Load(object sender, EventArgs e)
        {

        }
    }//fim da classe
}//fim do projeto

