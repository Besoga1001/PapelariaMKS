namespace MKS
{
    partial class Estoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.desc_produto = new System.Windows.Forms.TextBox();
            this.Botao_Adicionar = new System.Windows.Forms.Button();
            this.id_produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.quantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botao_prompt = new System.Windows.Forms.Button();
            this.grid_Estoque = new System.Windows.Forms.DataGridView();
            this.Produto_Grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // desc_produto
            // 
            this.desc_produto.Location = new System.Drawing.Point(118, 19);
            this.desc_produto.Name = "desc_produto";
            this.desc_produto.ReadOnly = true;
            this.desc_produto.Size = new System.Drawing.Size(218, 20);
            this.desc_produto.TabIndex = 0;
            // 
            // Botao_Adicionar
            // 
            this.Botao_Adicionar.Location = new System.Drawing.Point(12, 79);
            this.Botao_Adicionar.Name = "Botao_Adicionar";
            this.Botao_Adicionar.Size = new System.Drawing.Size(103, 27);
            this.Botao_Adicionar.TabIndex = 1;
            this.Botao_Adicionar.Text = "Adicionar Registro";
            this.Botao_Adicionar.UseVisualStyleBackColor = true;
            this.Botao_Adicionar.Click += new System.EventHandler(this.Botao_Adicionar_Click);
            // 
            // id_produto
            // 
            this.id_produto.Location = new System.Drawing.Point(89, 19);
            this.id_produto.Name = "id_produto";
            this.id_produto.Size = new System.Drawing.Size(23, 20);
            this.id_produto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Produto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpar Todos os Registros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantidade
            // 
            this.quantidade.AcceptsTab = true;
            this.quantidade.Location = new System.Drawing.Point(89, 45);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(71, 20);
            this.quantidade.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantidade";
            // 
            // botao_prompt
            // 
            this.botao_prompt.Location = new System.Drawing.Point(342, 19);
            this.botao_prompt.Name = "botao_prompt";
            this.botao_prompt.Size = new System.Drawing.Size(78, 21);
            this.botao_prompt.TabIndex = 9;
            this.botao_prompt.Text = "Prompt";
            this.botao_prompt.UseVisualStyleBackColor = true;
            this.botao_prompt.Click += new System.EventHandler(this.botao_prompt_Click);
            // 
            // grid_Estoque
            // 
            this.grid_Estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Estoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto_Grid,
            this.Desc_Grid,
            this.Quantidade_grid});
            this.grid_Estoque.Location = new System.Drawing.Point(12, 112);
            this.grid_Estoque.Name = "grid_Estoque";
            this.grid_Estoque.ReadOnly = true;
            this.grid_Estoque.Size = new System.Drawing.Size(408, 302);
            this.grid_Estoque.TabIndex = 10;
            this.grid_Estoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Produto_Grid
            // 
            this.Produto_Grid.HeaderText = "Produto";
            this.Produto_Grid.Name = "Produto_Grid";
            this.Produto_Grid.ReadOnly = true;
            this.Produto_Grid.Width = 60;
            // 
            // Desc_Grid
            // 
            this.Desc_Grid.HeaderText = "Descrição";
            this.Desc_Grid.Name = "Desc_Grid";
            this.Desc_Grid.ReadOnly = true;
            this.Desc_Grid.Width = 200;
            // 
            // Quantidade_grid
            // 
            this.Quantidade_grid.HeaderText = "Quantidade";
            this.Quantidade_grid.Name = "Quantidade_grid";
            this.Quantidade_grid.ReadOnly = true;
            this.Quantidade_grid.Width = 150;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 426);
            this.Controls.Add(this.grid_Estoque);
            this.Controls.Add(this.botao_prompt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_produto);
            this.Controls.Add(this.desc_produto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Botao_Adicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Estoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox desc_produto;
        private System.Windows.Forms.Button Botao_Adicionar;
        private System.Windows.Forms.TextBox id_produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botao_prompt;
        private System.Windows.Forms.DataGridView grid_Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade_grid;
    }
}