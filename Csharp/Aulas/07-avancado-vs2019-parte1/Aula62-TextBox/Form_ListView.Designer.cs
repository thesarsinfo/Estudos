
namespace Aula62_TextBox
{
    partial class Form_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "250,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39,90"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Gabinete",
            "10",
            "360,00"}, -1);
            this.Lv_Produtos = new System.Windows.Forms.ListView();
            this.Col_Id = new System.Windows.Forms.ColumnHeader();
            this.Col_Produto = new System.Windows.Forms.ColumnHeader();
            this.Col_Quantidade = new System.Windows.Forms.ColumnHeader();
            this.Col_Preco = new System.Windows.Forms.ColumnHeader();
            this.Tb_Id = new System.Windows.Forms.TextBox();
            this.Tb_Produto = new System.Windows.Forms.TextBox();
            this.Tb_Quantidade = new System.Windows.Forms.TextBox();
            this.Tb_Preco = new System.Windows.Forms.TextBox();
            this.La_Id = new System.Windows.Forms.Label();
            this.La_Produto = new System.Windows.Forms.Label();
            this.La_Quantidade = new System.Windows.Forms.Label();
            this.La_Preco = new System.Windows.Forms.Label();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.Btn_Remover = new System.Windows.Forms.Button();
            this.Btn_Obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lv_Produtos
            // 
            this.Lv_Produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Id,
            this.Col_Produto,
            this.Col_Quantidade,
            this.Col_Preco});
            this.Lv_Produtos.FullRowSelect = true;
            this.Lv_Produtos.HideSelection = false;
            this.Lv_Produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.Lv_Produtos.Location = new System.Drawing.Point(13, 13);
            this.Lv_Produtos.MultiSelect = false;
            this.Lv_Produtos.Name = "Lv_Produtos";
            this.Lv_Produtos.Size = new System.Drawing.Size(458, 159);
            this.Lv_Produtos.TabIndex = 0;
            this.Lv_Produtos.UseCompatibleStateImageBehavior = false;
            this.Lv_Produtos.View = System.Windows.Forms.View.Details;
            this.Lv_Produtos.SelectedIndexChanged += new System.EventHandler(this.Lv_Produtos_SelectedIndexChanged);
            // 
            // Col_Id
            // 
            this.Col_Id.Text = "ID";
            this.Col_Id.Width = 40;
            // 
            // Col_Produto
            // 
            this.Col_Produto.Text = "Produto";
            this.Col_Produto.Width = 250;
            // 
            // Col_Quantidade
            // 
            this.Col_Quantidade.Text = "Quantidade";
            this.Col_Quantidade.Width = 80;
            // 
            // Col_Preco
            // 
            this.Col_Preco.Text = "Preço";
            this.Col_Preco.Width = 80;
            // 
            // Tb_Id
            // 
            this.Tb_Id.Location = new System.Drawing.Point(13, 206);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.Size = new System.Drawing.Size(43, 23);
            this.Tb_Id.TabIndex = 1;
            // 
            // Tb_Produto
            // 
            this.Tb_Produto.Location = new System.Drawing.Point(62, 206);
            this.Tb_Produto.Name = "Tb_Produto";
            this.Tb_Produto.Size = new System.Drawing.Size(229, 23);
            this.Tb_Produto.TabIndex = 2;
            // 
            // Tb_Quantidade
            // 
            this.Tb_Quantidade.Location = new System.Drawing.Point(298, 205);
            this.Tb_Quantidade.Name = "Tb_Quantidade";
            this.Tb_Quantidade.Size = new System.Drawing.Size(81, 23);
            this.Tb_Quantidade.TabIndex = 3;
            // 
            // Tb_Preco
            // 
            this.Tb_Preco.Location = new System.Drawing.Point(386, 206);
            this.Tb_Preco.Name = "Tb_Preco";
            this.Tb_Preco.Size = new System.Drawing.Size(81, 23);
            this.Tb_Preco.TabIndex = 4;
            // 
            // La_Id
            // 
            this.La_Id.AutoSize = true;
            this.La_Id.Location = new System.Drawing.Point(13, 185);
            this.La_Id.Name = "La_Id";
            this.La_Id.Size = new System.Drawing.Size(18, 15);
            this.La_Id.TabIndex = 5;
            this.La_Id.Text = "ID";
            // 
            // La_Produto
            // 
            this.La_Produto.AutoSize = true;
            this.La_Produto.Location = new System.Drawing.Point(58, 184);
            this.La_Produto.Name = "La_Produto";
            this.La_Produto.Size = new System.Drawing.Size(50, 15);
            this.La_Produto.TabIndex = 6;
            this.La_Produto.Text = "Produto";
            // 
            // La_Quantidade
            // 
            this.La_Quantidade.AutoSize = true;
            this.La_Quantidade.Location = new System.Drawing.Point(298, 187);
            this.La_Quantidade.Name = "La_Quantidade";
            this.La_Quantidade.Size = new System.Drawing.Size(69, 15);
            this.La_Quantidade.TabIndex = 7;
            this.La_Quantidade.Text = "Quantidade";
            // 
            // La_Preco
            // 
            this.La_Preco.AutoSize = true;
            this.La_Preco.Location = new System.Drawing.Point(386, 185);
            this.La_Preco.Name = "La_Preco";
            this.La_Preco.Size = new System.Drawing.Size(37, 15);
            this.La_Preco.TabIndex = 8;
            this.La_Preco.Text = "Preço";
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.Location = new System.Drawing.Point(12, 253);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Adicionar.TabIndex = 9;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = true;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // Btn_Remover
            // 
            this.Btn_Remover.Location = new System.Drawing.Point(12, 295);
            this.Btn_Remover.Name = "Btn_Remover";
            this.Btn_Remover.Size = new System.Drawing.Size(75, 23);
            this.Btn_Remover.TabIndex = 10;
            this.Btn_Remover.Text = "Remover";
            this.Btn_Remover.UseVisualStyleBackColor = true;
            this.Btn_Remover.Click += new System.EventHandler(this.Btn_Remover_Click);
            // 
            // Btn_Obter
            // 
            this.Btn_Obter.Location = new System.Drawing.Point(12, 334);
            this.Btn_Obter.Name = "Btn_Obter";
            this.Btn_Obter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Obter.TabIndex = 11;
            this.Btn_Obter.Text = "Obter";
            this.Btn_Obter.UseVisualStyleBackColor = true;
            this.Btn_Obter.Click += new System.EventHandler(this.Btn_Obter_Click);
            // 
            // Form_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.Btn_Obter);
            this.Controls.Add(this.Btn_Remover);
            this.Controls.Add(this.Btn_Adicionar);
            this.Controls.Add(this.La_Preco);
            this.Controls.Add(this.La_Quantidade);
            this.Controls.Add(this.La_Produto);
            this.Controls.Add(this.La_Id);
            this.Controls.Add(this.Tb_Preco);
            this.Controls.Add(this.Tb_Quantidade);
            this.Controls.Add(this.Tb_Produto);
            this.Controls.Add(this.Tb_Id);
            this.Controls.Add(this.Lv_Produtos);
            this.Name = "Form_ListView";
            this.Text = "Form_ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lv_Produtos;
        private System.Windows.Forms.ColumnHeader Col_Id;
        private System.Windows.Forms.ColumnHeader Col_Produto;
        private System.Windows.Forms.ColumnHeader Col_Quantidade;
        private System.Windows.Forms.ColumnHeader Col_Preco;
        private System.Windows.Forms.TextBox Tb_Id;
        private System.Windows.Forms.TextBox Tb_Produto;
        private System.Windows.Forms.TextBox Tb_Quantidade;
        private System.Windows.Forms.TextBox Tb_Preco;
        private System.Windows.Forms.Label La_Id;
        private System.Windows.Forms.Label La_Produto;
        private System.Windows.Forms.Label La_Quantidade;
        private System.Windows.Forms.Label La_Preco;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.Button Btn_Remover;
        private System.Windows.Forms.Button Btn_Obter;
    }
}