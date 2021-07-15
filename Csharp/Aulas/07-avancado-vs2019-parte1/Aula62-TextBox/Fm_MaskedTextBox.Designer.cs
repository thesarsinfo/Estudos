
namespace Aula62_TextBox
{
    partial class Fm_MaskedTextBox
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
            this.Mtb_Senha = new System.Windows.Forms.MaskedTextBox();
            this.La_Senha = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Btn_CPF = new System.Windows.Forms.Button();
            this.Cb_Mascara = new System.Windows.Forms.CheckBox();
            this.Cb_RevelarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Mtb_Senha
            // 
            this.Mtb_Senha.Location = new System.Drawing.Point(12, 49);
            this.Mtb_Senha.Name = "Mtb_Senha";
            this.Mtb_Senha.PasswordChar = '*';
            this.Mtb_Senha.RejectInputOnFirstFailure = true;
            this.Mtb_Senha.Size = new System.Drawing.Size(236, 23);
            this.Mtb_Senha.TabIndex = 0;
            // 
            // La_Senha
            // 
            this.La_Senha.AutoSize = true;
            this.La_Senha.Location = new System.Drawing.Point(13, 13);
            this.La_Senha.Name = "La_Senha";
            this.La_Senha.Size = new System.Drawing.Size(39, 15);
            this.La_Senha.TabIndex = 1;
            this.La_Senha.Text = "Senha";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(13, 108);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(105, 29);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Btn_CPF
            // 
            this.Btn_CPF.Location = new System.Drawing.Point(258, 112);
            this.Btn_CPF.Name = "Btn_CPF";
            this.Btn_CPF.Size = new System.Drawing.Size(75, 23);
            this.Btn_CPF.TabIndex = 3;
            this.Btn_CPF.Text = "button1";
            this.Btn_CPF.UseVisualStyleBackColor = true;
            this.Btn_CPF.Click += new System.EventHandler(this.Btn_CPF_Click);
            // 
            // Cb_Mascara
            // 
            this.Cb_Mascara.AutoSize = true;
            this.Cb_Mascara.Location = new System.Drawing.Point(141, 116);
            this.Cb_Mascara.Name = "Cb_Mascara";
            this.Cb_Mascara.Size = new System.Drawing.Size(104, 19);
            this.Cb_Mascara.TabIndex = 4;
            this.Cb_Mascara.Text = "Somente Texto";
            this.Cb_Mascara.UseVisualStyleBackColor = true;
            // 
            // Cb_RevelarSenha
            // 
            this.Cb_RevelarSenha.AutoSize = true;
            this.Cb_RevelarSenha.Location = new System.Drawing.Point(258, 49);
            this.Cb_RevelarSenha.Name = "Cb_RevelarSenha";
            this.Cb_RevelarSenha.Size = new System.Drawing.Size(99, 19);
            this.Cb_RevelarSenha.TabIndex = 5;
            this.Cb_RevelarSenha.Text = "Revelar Senha";
            this.Cb_RevelarSenha.UseVisualStyleBackColor = true;
            this.Cb_RevelarSenha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Fm_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cb_RevelarSenha);
            this.Controls.Add(this.Cb_Mascara);
            this.Controls.Add(this.Btn_CPF);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.La_Senha);
            this.Controls.Add(this.Mtb_Senha);
            this.Name = "Fm_MaskedTextBox";
            this.Text = "Fm_MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Mtb_Senha;
        private System.Windows.Forms.Label La_Senha;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button Btn_CPF;
        private System.Windows.Forms.CheckBox Cb_Mascara;
        private System.Windows.Forms.CheckBox Cb_RevelarSenha;
    }
}