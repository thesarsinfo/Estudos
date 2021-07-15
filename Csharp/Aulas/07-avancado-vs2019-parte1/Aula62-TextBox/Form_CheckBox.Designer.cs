
namespace Aula62_TextBox
{
    partial class Form_CheckBox
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
            this.CB_Carro = new System.Windows.Forms.CheckBox();
            this.CB_Aviao = new System.Windows.Forms.CheckBox();
            this.CB_Navio = new System.Windows.Forms.CheckBox();
            this.CB_Onibus = new System.Windows.Forms.CheckBox();
            this.Btn_Transportes_Marcados = new System.Windows.Forms.Button();
            this.CB_Patinete = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Carro
            // 
            this.CB_Carro.AutoSize = true;
            this.CB_Carro.Location = new System.Drawing.Point(29, 29);
            this.CB_Carro.Name = "CB_Carro";
            this.CB_Carro.Size = new System.Drawing.Size(55, 19);
            this.CB_Carro.TabIndex = 0;
            this.CB_Carro.Text = "Carro";
            this.CB_Carro.UseVisualStyleBackColor = true;
            // 
            // CB_Aviao
            // 
            this.CB_Aviao.AutoSize = true;
            this.CB_Aviao.Location = new System.Drawing.Point(29, 55);
            this.CB_Aviao.Name = "CB_Aviao";
            this.CB_Aviao.Size = new System.Drawing.Size(56, 19);
            this.CB_Aviao.TabIndex = 1;
            this.CB_Aviao.Text = "Aviao";
            this.CB_Aviao.UseVisualStyleBackColor = true;
            // 
            // CB_Navio
            // 
            this.CB_Navio.AutoSize = true;
            this.CB_Navio.Location = new System.Drawing.Point(29, 80);
            this.CB_Navio.Name = "CB_Navio";
            this.CB_Navio.Size = new System.Drawing.Size(57, 19);
            this.CB_Navio.TabIndex = 2;
            this.CB_Navio.Text = "Navio";
            this.CB_Navio.UseVisualStyleBackColor = true;
            // 
            // CB_Onibus
            // 
            this.CB_Onibus.AutoSize = true;
            this.CB_Onibus.Location = new System.Drawing.Point(29, 106);
            this.CB_Onibus.Name = "CB_Onibus";
            this.CB_Onibus.Size = new System.Drawing.Size(64, 19);
            this.CB_Onibus.TabIndex = 3;
            this.CB_Onibus.Text = "Ônibus";
            this.CB_Onibus.UseVisualStyleBackColor = true;
            // 
            // Btn_Transportes_Marcados
            // 
            this.Btn_Transportes_Marcados.Location = new System.Drawing.Point(132, 29);
            this.Btn_Transportes_Marcados.Name = "Btn_Transportes_Marcados";
            this.Btn_Transportes_Marcados.Size = new System.Drawing.Size(270, 23);
            this.Btn_Transportes_Marcados.TabIndex = 4;
            this.Btn_Transportes_Marcados.Text = "Transportes Marcados";
            this.Btn_Transportes_Marcados.UseVisualStyleBackColor = true;
            this.Btn_Transportes_Marcados.Click += new System.EventHandler(this.Btn_Transportes_Marcados_Click);
            // 
            // CB_Patinete
            // 
            this.CB_Patinete.AutoSize = true;
            this.CB_Patinete.Location = new System.Drawing.Point(29, 160);
            this.CB_Patinete.Name = "CB_Patinete";
            this.CB_Patinete.Size = new System.Drawing.Size(69, 19);
            this.CB_Patinete.TabIndex = 5;
            this.CB_Patinete.Text = "Patinete";
            this.CB_Patinete.UseVisualStyleBackColor = true;
            this.CB_Patinete.CheckedChanged += new System.EventHandler(this.CB_Patinete_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Abri o Form Filho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 191);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CB_Patinete);
            this.Controls.Add(this.Btn_Transportes_Marcados);
            this.Controls.Add(this.CB_Onibus);
            this.Controls.Add(this.CB_Navio);
            this.Controls.Add(this.CB_Aviao);
            this.Controls.Add(this.CB_Carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.Load += new System.EventHandler(this.Form_CheckBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Transportes_Marcados;
        private System.Windows.Forms.CheckBox CB_Patinete;
        public System.Windows.Forms.CheckBox CB_Carro;
        public System.Windows.Forms.CheckBox CB_Aviao;
        public System.Windows.Forms.CheckBox CB_Navio;
        public System.Windows.Forms.CheckBox CB_Onibus;
        private System.Windows.Forms.Button button1;
    }
}