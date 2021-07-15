
namespace Aula62_TextBox
{
    partial class Form_ListBox
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
            this.Lb_Carros = new System.Windows.Forms.ListBox();
            this.La_Carro = new System.Windows.Forms.Label();
            this.Tb_Carro = new System.Windows.Forms.TextBox();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.Btn_Remover = new System.Windows.Forms.Button();
            this.Btn_Obter = new System.Windows.Forms.Button();
            this.Btn_LimparTudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Carros
            // 
            this.Lb_Carros.FormattingEnabled = true;
            this.Lb_Carros.ItemHeight = 15;
            this.Lb_Carros.Location = new System.Drawing.Point(12, 12);
            this.Lb_Carros.Name = "Lb_Carros";
            this.Lb_Carros.Size = new System.Drawing.Size(211, 274);
            this.Lb_Carros.TabIndex = 0;
            // 
            // La_Carro
            // 
            this.La_Carro.AutoSize = true;
            this.La_Carro.Location = new System.Drawing.Point(230, 13);
            this.La_Carro.Name = "La_Carro";
            this.La_Carro.Size = new System.Drawing.Size(36, 15);
            this.La_Carro.TabIndex = 1;
            this.La_Carro.Text = "Carro";
            // 
            // Tb_Carro
            // 
            this.Tb_Carro.Location = new System.Drawing.Point(230, 32);
            this.Tb_Carro.Name = "Tb_Carro";
            this.Tb_Carro.Size = new System.Drawing.Size(100, 23);
            this.Tb_Carro.TabIndex = 2;
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.Location = new System.Drawing.Point(230, 71);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Adicionar.TabIndex = 3;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = true;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // Btn_Remover
            // 
            this.Btn_Remover.Location = new System.Drawing.Point(230, 110);
            this.Btn_Remover.Name = "Btn_Remover";
            this.Btn_Remover.Size = new System.Drawing.Size(75, 23);
            this.Btn_Remover.TabIndex = 4;
            this.Btn_Remover.Text = "Remover";
            this.Btn_Remover.UseVisualStyleBackColor = true;
            this.Btn_Remover.Click += new System.EventHandler(this.Btn_Remover_Click);
            // 
            // Btn_Obter
            // 
            this.Btn_Obter.Location = new System.Drawing.Point(230, 156);
            this.Btn_Obter.Name = "Btn_Obter";
            this.Btn_Obter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Obter.TabIndex = 5;
            this.Btn_Obter.Text = "Obter";
            this.Btn_Obter.UseVisualStyleBackColor = true;
            this.Btn_Obter.Click += new System.EventHandler(this.Btn_Obter_Click);
            // 
            // Btn_LimparTudo
            // 
            this.Btn_LimparTudo.Location = new System.Drawing.Point(230, 186);
            this.Btn_LimparTudo.Name = "Btn_LimparTudo";
            this.Btn_LimparTudo.Size = new System.Drawing.Size(75, 23);
            this.Btn_LimparTudo.TabIndex = 6;
            this.Btn_LimparTudo.Text = "Limpar Tudo";
            this.Btn_LimparTudo.UseVisualStyleBackColor = true;
            this.Btn_LimparTudo.Click += new System.EventHandler(this.Btn_LimparTudo_Click);
            // 
            // Form_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_LimparTudo);
            this.Controls.Add(this.Btn_Obter);
            this.Controls.Add(this.Btn_Remover);
            this.Controls.Add(this.Btn_Adicionar);
            this.Controls.Add(this.Tb_Carro);
            this.Controls.Add(this.La_Carro);
            this.Controls.Add(this.Lb_Carros);
            this.Name = "Form_ListBox";
            this.Text = "Form_ListBox";
            this.Load += new System.EventHandler(this.Form_ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_Carros;
        private System.Windows.Forms.Label La_Carro;
        private System.Windows.Forms.TextBox Tb_Carro;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.Button Btn_Remover;
        private System.Windows.Forms.Button Btn_Obter;
        private System.Windows.Forms.Button Btn_LimparTudo;
    }
}