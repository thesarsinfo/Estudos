
namespace Aula62_TextBox
{
    partial class Fm_TreeView
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Hrv");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Fit");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Honda", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Golf");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Gol Quadrado");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Volksvagem", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            this.Tv_Marcas = new System.Windows.Forms.TreeView();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.Btn_Remover = new System.Windows.Forms.Button();
            this.Tb_Carro = new System.Windows.Forms.TextBox();
            this.Tb_Tag = new System.Windows.Forms.TextBox();
            this.Btn_RemoverSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tv_Marcas
            // 
            this.Tv_Marcas.Location = new System.Drawing.Point(12, 12);
            this.Tv_Marcas.Name = "Tv_Marcas";
            treeNode13.Name = "hrv";
            treeNode13.Tag = "https://www.google.com/HRV";
            treeNode13.Text = "Hrv";
            treeNode14.Name = "fit";
            treeNode14.Text = "Fit";
            treeNode15.Name = "honda";
            treeNode15.Text = "Honda";
            treeNode16.Name = "golf";
            treeNode16.Text = "Golf";
            treeNode17.Name = "golQuadrado";
            treeNode17.Text = "Gol Quadrado";
            treeNode18.Name = "volksvagem";
            treeNode18.Text = "Volksvagem";
            this.Tv_Marcas.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode18});
            this.Tv_Marcas.Size = new System.Drawing.Size(189, 277);
            this.Tv_Marcas.TabIndex = 0;
            this.Tv_Marcas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tv_Marcas_AfterSelect);
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.Location = new System.Drawing.Point(208, 12);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(117, 23);
            this.Btn_Adicionar.TabIndex = 1;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = true;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // Btn_Remover
            // 
            this.Btn_Remover.Location = new System.Drawing.Point(208, 42);
            this.Btn_Remover.Name = "Btn_Remover";
            this.Btn_Remover.Size = new System.Drawing.Size(117, 23);
            this.Btn_Remover.TabIndex = 2;
            this.Btn_Remover.Text = "Remover";
            this.Btn_Remover.UseVisualStyleBackColor = true;
            this.Btn_Remover.Click += new System.EventHandler(this.Btn_Remover_Click);
            // 
            // Tb_Carro
            // 
            this.Tb_Carro.Location = new System.Drawing.Point(208, 83);
            this.Tb_Carro.Name = "Tb_Carro";
            this.Tb_Carro.Size = new System.Drawing.Size(117, 23);
            this.Tb_Carro.TabIndex = 3;
            // 
            // Tb_Tag
            // 
            this.Tb_Tag.Location = new System.Drawing.Point(208, 113);
            this.Tb_Tag.Name = "Tb_Tag";
            this.Tb_Tag.Size = new System.Drawing.Size(117, 23);
            this.Tb_Tag.TabIndex = 4;
            // 
            // Btn_RemoverSelecionado
            // 
            this.Btn_RemoverSelecionado.Location = new System.Drawing.Point(332, 41);
            this.Btn_RemoverSelecionado.Name = "Btn_RemoverSelecionado";
            this.Btn_RemoverSelecionado.Size = new System.Drawing.Size(156, 23);
            this.Btn_RemoverSelecionado.TabIndex = 5;
            this.Btn_RemoverSelecionado.Text = "Remover Selecionado";
            this.Btn_RemoverSelecionado.UseVisualStyleBackColor = true;
            this.Btn_RemoverSelecionado.Click += new System.EventHandler(this.Btn_RemoverSelecionado_Click);
            // 
            // Fm_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_RemoverSelecionado);
            this.Controls.Add(this.Tb_Tag);
            this.Controls.Add(this.Tb_Carro);
            this.Controls.Add(this.Btn_Remover);
            this.Controls.Add(this.Btn_Adicionar);
            this.Controls.Add(this.Tv_Marcas);
            this.Name = "Fm_TreeView";
            this.Text = "Fm_TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView Tv_Marcas;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.Button Btn_Remover;
        private System.Windows.Forms.TextBox Tb_Carro;
        private System.Windows.Forms.TextBox Tb_Tag;
        private System.Windows.Forms.Button Btn_RemoverSelecionado;
    }
}