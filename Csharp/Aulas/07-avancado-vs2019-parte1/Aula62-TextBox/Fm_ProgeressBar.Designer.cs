
namespace Aula62_TextBox
{
    partial class Fm_ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Btn_DefinirValor = new System.Windows.Forms.Button();
            this.Tb_DefinirValor = new System.Windows.Forms.TextBox();
            this.Btn_Preencher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 171);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(501, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // Btn_DefinirValor
            // 
            this.Btn_DefinirValor.Location = new System.Drawing.Point(13, 70);
            this.Btn_DefinirValor.Name = "Btn_DefinirValor";
            this.Btn_DefinirValor.Size = new System.Drawing.Size(100, 23);
            this.Btn_DefinirValor.TabIndex = 1;
            this.Btn_DefinirValor.Text = "Definit Valor";
            this.Btn_DefinirValor.UseVisualStyleBackColor = true;
            this.Btn_DefinirValor.Click += new System.EventHandler(this.Btn_DefinirValor_Click);
            // 
            // Tb_DefinirValor
            // 
            this.Tb_DefinirValor.Location = new System.Drawing.Point(13, 34);
            this.Tb_DefinirValor.Name = "Tb_DefinirValor";
            this.Tb_DefinirValor.Size = new System.Drawing.Size(100, 23);
            this.Tb_DefinirValor.TabIndex = 2;
            this.Tb_DefinirValor.Text = "0";
            // 
            // Btn_Preencher
            // 
            this.Btn_Preencher.Location = new System.Drawing.Point(13, 140);
            this.Btn_Preencher.Name = "Btn_Preencher";
            this.Btn_Preencher.Size = new System.Drawing.Size(100, 23);
            this.Btn_Preencher.TabIndex = 3;
            this.Btn_Preencher.Text = "Preencher";
            this.Btn_Preencher.UseVisualStyleBackColor = true;
            this.Btn_Preencher.Click += new System.EventHandler(this.Btn_Preencher_Click);
            // 
            // Fm_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 377);
            this.Controls.Add(this.Btn_Preencher);
            this.Controls.Add(this.Tb_DefinirValor);
            this.Controls.Add(this.Btn_DefinirValor);
            this.Controls.Add(this.progressBar1);
            this.Name = "Fm_ProgressBar";
            this.Text = "Progress Bar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Btn_DefinirValor;
        private System.Windows.Forms.TextBox Tb_DefinirValor;
        private System.Windows.Forms.Button Btn_Preencher;
    }
}