using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKS
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {

        }

        private void Botao_Adicionar_Click(object sender, EventArgs e)
        {
            if (id_produto.Text == "") 
            {
                MessageBox.Show("ID do Produto Vazio!");
                id_produto.Focus();
                return;
            }

            Produto_Grid.DataPropertyName = id_produto.Text;

            id_produto.Clear();
            desc_produto.Clear();
            quantidade.Clear();
            id_produto.Focus();

        }

        private void botao_prompt_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid_Estoque.ClearSelection();
            id_produto.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
