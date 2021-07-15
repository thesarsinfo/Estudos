
namespace Saraiva_Academia
{
    partial class F_Login
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
            this.La_Username = new System.Windows.Forms.Label();
            this.Tb_Username = new System.Windows.Forms.TextBox();
            this.La_Senha = new System.Windows.Forms.Label();
            this.Tb_Senha = new System.Windows.Forms.TextBox();
            this.Btn_Logar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // La_Username
            // 
            this.La_Username.AutoSize = true;
            this.La_Username.Location = new System.Drawing.Point(16, 27);
            this.La_Username.Name = "La_Username";
            this.La_Username.Size = new System.Drawing.Size(55, 13);
            this.La_Username.TabIndex = 0;
            this.La_Username.Text = "Username";
            // 
            // Tb_Username
            // 
            this.Tb_Username.Location = new System.Drawing.Point(19, 43);
            this.Tb_Username.Name = "Tb_Username";
            this.Tb_Username.Size = new System.Drawing.Size(176, 20);
            this.Tb_Username.TabIndex = 1;
            this.Tb_Username.Text = "saraiva";
            // 
            // La_Senha
            // 
            this.La_Senha.AutoSize = true;
            this.La_Senha.Location = new System.Drawing.Point(16, 66);
            this.La_Senha.Name = "La_Senha";
            this.La_Senha.Size = new System.Drawing.Size(38, 13);
            this.La_Senha.TabIndex = 2;
            this.La_Senha.Text = "Senha";
            // 
            // Tb_Senha
            // 
            this.Tb_Senha.Location = new System.Drawing.Point(19, 82);
            this.Tb_Senha.Name = "Tb_Senha";
            this.Tb_Senha.PasswordChar = '*';
            this.Tb_Senha.Size = new System.Drawing.Size(176, 20);
            this.Tb_Senha.TabIndex = 3;
            this.Tb_Senha.Text = "123";
            // 
            // Btn_Logar
            // 
            this.Btn_Logar.Location = new System.Drawing.Point(19, 108);
            this.Btn_Logar.Name = "Btn_Logar";
            this.Btn_Logar.Size = new System.Drawing.Size(176, 23);
            this.Btn_Logar.TabIndex = 4;
            this.Btn_Logar.Text = "Logar";
            this.Btn_Logar.UseVisualStyleBackColor = true;
            this.Btn_Logar.Click += new System.EventHandler(this.Btn_Logar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(19, 137);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(176, 23);
            this.Btn_Cancelar.TabIndex = 5;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 223);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Logar);
            this.Controls.Add(this.Tb_Senha);
            this.Controls.Add(this.La_Senha);
            this.Controls.Add(this.Tb_Username);
            this.Controls.Add(this.La_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label La_Username;
        private System.Windows.Forms.TextBox Tb_Username;
        private System.Windows.Forms.Label La_Senha;
        private System.Windows.Forms.TextBox Tb_Senha;
        private System.Windows.Forms.Button Btn_Logar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}