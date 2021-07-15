
namespace Saraiva_Academia
{
    partial class F_NovoUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Nome = new System.Windows.Forms.TextBox();
            this.Tb_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_Senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_Status = new System.Windows.Forms.ComboBox();
            this.Nud_Nivel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_NovoUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Nivel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Tb_Nome
            // 
            this.Tb_Nome.Location = new System.Drawing.Point(16, 29);
            this.Tb_Nome.Name = "Tb_Nome";
            this.Tb_Nome.Size = new System.Drawing.Size(295, 20);
            this.Tb_Nome.TabIndex = 1;
            // 
            // Tb_Username
            // 
            this.Tb_Username.Location = new System.Drawing.Point(16, 70);
            this.Tb_Username.Name = "Tb_Username";
            this.Tb_Username.Size = new System.Drawing.Size(144, 20);
            this.Tb_Username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // Tb_Senha
            // 
            this.Tb_Senha.Location = new System.Drawing.Point(182, 70);
            this.Tb_Senha.Name = "Tb_Senha";
            this.Tb_Senha.PasswordChar = '*';
            this.Tb_Senha.Size = new System.Drawing.Size(129, 20);
            this.Tb_Senha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // Cb_Status
            // 
            this.Cb_Status.FormattingEnabled = true;
            this.Cb_Status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.Cb_Status.Location = new System.Drawing.Point(16, 121);
            this.Cb_Status.Name = "Cb_Status";
            this.Cb_Status.Size = new System.Drawing.Size(141, 21);
            this.Cb_Status.TabIndex = 6;
            // 
            // Nud_Nivel
            // 
            this.Nud_Nivel.Location = new System.Drawing.Point(182, 121);
            this.Nud_Nivel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Nud_Nivel.Name = "Nud_Nivel";
            this.Nud_Nivel.Size = new System.Drawing.Size(129, 20);
            this.Nud_Nivel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nível";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "A = Ativo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "B = Bloqueado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "D = Desligado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Fechar);
            this.panel1.Controls.Add(this.Btn_Cancelar);
            this.panel1.Controls.Add(this.Btn_Salvar);
            this.panel1.Controls.Add(this.Btn_NovoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 29);
            this.panel1.TabIndex = 13;
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Fechar.Location = new System.Drawing.Point(291, 3);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fechar.TabIndex = 3;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancelar.Location = new System.Drawing.Point(185, 3);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 2;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salvar.Location = new System.Drawing.Point(104, 3);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salvar.TabIndex = 1;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_NovoUsuario
            // 
            this.Btn_NovoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NovoUsuario.Location = new System.Drawing.Point(3, 3);
            this.Btn_NovoUsuario.Name = "Btn_NovoUsuario";
            this.Btn_NovoUsuario.Size = new System.Drawing.Size(98, 23);
            this.Btn_NovoUsuario.TabIndex = 0;
            this.Btn_NovoUsuario.Text = "Novo Usuário";
            this.Btn_NovoUsuario.UseVisualStyleBackColor = true;
            this.Btn_NovoUsuario.Click += new System.EventHandler(this.Btn_NovoUsuario_Click);
            // 
            // F_NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 238);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nud_Nivel);
            this.Controls.Add(this.Cb_Status);
            this.Controls.Add(this.Tb_Senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_Nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Nome;
        private System.Windows.Forms.TextBox Tb_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cb_Status;
        private System.Windows.Forms.NumericUpDown Nud_Nivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_NovoUsuario;
    }
}