namespace MKS
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Botao_Venda = new System.Windows.Forms.Button();
            this.Botao_Compra = new System.Windows.Forms.Button();
            this.Botao_Estoque = new System.Windows.Forms.Button();
            this.Botao_Produto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Botao_Venda
            // 
            this.Botao_Venda.Location = new System.Drawing.Point(63, 52);
            this.Botao_Venda.Name = "Botao_Venda";
            this.Botao_Venda.Size = new System.Drawing.Size(199, 92);
            this.Botao_Venda.TabIndex = 0;
            this.Botao_Venda.Text = "Vendas";
            this.Botao_Venda.UseVisualStyleBackColor = true;
            this.Botao_Venda.Click += new System.EventHandler(this.Botao_Venda_Click);
            // 
            // Botao_Compra
            // 
            this.Botao_Compra.Location = new System.Drawing.Point(331, 52);
            this.Botao_Compra.Name = "Botao_Compra";
            this.Botao_Compra.Size = new System.Drawing.Size(199, 92);
            this.Botao_Compra.TabIndex = 1;
            this.Botao_Compra.Text = "Compras";
            this.Botao_Compra.UseVisualStyleBackColor = true;
            this.Botao_Compra.Click += new System.EventHandler(this.Botao_Compra_Click);
            // 
            // Botao_Estoque
            // 
            this.Botao_Estoque.Location = new System.Drawing.Point(63, 195);
            this.Botao_Estoque.Name = "Botao_Estoque";
            this.Botao_Estoque.Size = new System.Drawing.Size(199, 92);
            this.Botao_Estoque.TabIndex = 2;
            this.Botao_Estoque.Text = "Movimentação de Estoque";
            this.Botao_Estoque.UseVisualStyleBackColor = true;
            this.Botao_Estoque.Click += new System.EventHandler(this.Botao_Estoque_Click);
            // 
            // Botao_Produto
            // 
            this.Botao_Produto.Location = new System.Drawing.Point(331, 195);
            this.Botao_Produto.Name = "Botao_Produto";
            this.Botao_Produto.Size = new System.Drawing.Size(199, 92);
            this.Botao_Produto.TabIndex = 3;
            this.Botao_Produto.Text = "Produtos";
            this.Botao_Produto.UseVisualStyleBackColor = true;
            this.Botao_Produto.Click += new System.EventHandler(this.Botao_Produto_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 345);
            this.Controls.Add(this.Botao_Produto);
            this.Controls.Add(this.Botao_Estoque);
            this.Controls.Add(this.Botao_Compra);
            this.Controls.Add(this.Botao_Venda);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Botao_Venda;
        private System.Windows.Forms.Button Botao_Compra;
        private System.Windows.Forms.Button Botao_Estoque;
        private System.Windows.Forms.Button Botao_Produto;
    }
}

