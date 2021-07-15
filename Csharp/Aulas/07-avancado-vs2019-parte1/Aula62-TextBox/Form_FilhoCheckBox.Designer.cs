
namespace Aula62_TextBox
{
    partial class Form_FilhoCheckBox
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
            this.CB_Onibus = new System.Windows.Forms.CheckBox();
            this.CB_Navio = new System.Windows.Forms.CheckBox();
            this.CB_Aviao = new System.Windows.Forms.CheckBox();
            this.CB_Carro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CB_Onibus
            // 
            this.CB_Onibus.AutoSize = true;
            this.CB_Onibus.Location = new System.Drawing.Point(41, 115);
            this.CB_Onibus.Name = "CB_Onibus";
            this.CB_Onibus.Size = new System.Drawing.Size(64, 19);
            this.CB_Onibus.TabIndex = 7;
            this.CB_Onibus.Text = "Ônibus";
            this.CB_Onibus.UseVisualStyleBackColor = true;
            this.CB_Onibus.CheckedChanged += new System.EventHandler(this.CB_Onibus_CheckedChanged);
            // 
            // CB_Navio
            // 
            this.CB_Navio.AutoSize = true;
            this.CB_Navio.Location = new System.Drawing.Point(41, 89);
            this.CB_Navio.Name = "CB_Navio";
            this.CB_Navio.Size = new System.Drawing.Size(57, 19);
            this.CB_Navio.TabIndex = 6;
            this.CB_Navio.Text = "Navio";
            this.CB_Navio.UseVisualStyleBackColor = true;
            this.CB_Navio.CheckedChanged += new System.EventHandler(this.CB_Navio_CheckedChanged);
            // 
            // CB_Aviao
            // 
            this.CB_Aviao.AutoSize = true;
            this.CB_Aviao.Location = new System.Drawing.Point(41, 64);
            this.CB_Aviao.Name = "CB_Aviao";
            this.CB_Aviao.Size = new System.Drawing.Size(56, 19);
            this.CB_Aviao.TabIndex = 5;
            this.CB_Aviao.Text = "Aviao";
            this.CB_Aviao.UseVisualStyleBackColor = true;
            this.CB_Aviao.CheckedChanged += new System.EventHandler(this.CB_Aviao_CheckedChanged);
            // 
            // CB_Carro
            // 
            this.CB_Carro.AutoSize = true;
            this.CB_Carro.Location = new System.Drawing.Point(41, 38);
            this.CB_Carro.Name = "CB_Carro";
            this.CB_Carro.Size = new System.Drawing.Size(55, 19);
            this.CB_Carro.TabIndex = 4;
            this.CB_Carro.Text = "Carro";
            this.CB_Carro.UseVisualStyleBackColor = true;
            this.CB_Carro.CheckedChanged += new System.EventHandler(this.CB_Carro_CheckedChanged);
            // 
            // Form_FilhoCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 182);
            this.Controls.Add(this.CB_Onibus);
            this.Controls.Add(this.CB_Navio);
            this.Controls.Add(this.CB_Aviao);
            this.Controls.Add(this.CB_Carro);
            this.Name = "Form_FilhoCheckBox";
            this.Text = "Form_FilhoCheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Onibus;
        private System.Windows.Forms.CheckBox CB_Navio;
        private System.Windows.Forms.CheckBox CB_Aviao;
        private System.Windows.Forms.CheckBox CB_Carro;
    }
}