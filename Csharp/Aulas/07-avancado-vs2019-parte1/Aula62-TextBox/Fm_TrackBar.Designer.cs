
namespace Aula62_TextBox
{
    partial class Fm_TrackBar
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Tb_Valor = new System.Windows.Forms.TextBox();
            this.Btn_Definir = new System.Windows.Forms.Button();
            this.La_Valor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(274, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Tb_Valor
            // 
            this.Tb_Valor.Location = new System.Drawing.Point(12, 105);
            this.Tb_Valor.Name = "Tb_Valor";
            this.Tb_Valor.Size = new System.Drawing.Size(100, 23);
            this.Tb_Valor.TabIndex = 1;
            // 
            // Btn_Definir
            // 
            this.Btn_Definir.Location = new System.Drawing.Point(118, 105);
            this.Btn_Definir.Name = "Btn_Definir";
            this.Btn_Definir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Definir.TabIndex = 2;
            this.Btn_Definir.Text = "Definir";
            this.Btn_Definir.UseVisualStyleBackColor = true;
            this.Btn_Definir.Click += new System.EventHandler(this.Btn_Definir_Click);
            // 
            // La_Valor
            // 
            this.La_Valor.AutoSize = true;
            this.La_Valor.Location = new System.Drawing.Point(12, 159);
            this.La_Valor.Name = "La_Valor";
            this.La_Valor.Size = new System.Drawing.Size(38, 15);
            this.La_Valor.TabIndex = 3;
            this.La_Valor.Text = "label1";
            // 
            // Fm_TrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 328);
            this.Controls.Add(this.La_Valor);
            this.Controls.Add(this.Btn_Definir);
            this.Controls.Add(this.Tb_Valor);
            this.Controls.Add(this.trackBar1);
            this.Name = "Fm_TrackBar";
            this.Text = "Fm_TrackBar";
            this.Load += new System.EventHandler(this.Fm_TrackBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox Tb_Valor;
        private System.Windows.Forms.Button Btn_Definir;
        private System.Windows.Forms.Label La_Valor;
    }
}