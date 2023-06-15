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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Botao_Venda_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            venda.ShowDialog();
        }

        private void Botao_Compra_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            compra.ShowDialog();
        }

        private void Botao_Estoque_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.ShowDialog();
        }

        private void Botao_Produto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.ShowDialog();
        }
    }
}
