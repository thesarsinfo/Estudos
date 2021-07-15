
namespace Saraiva_Academia
{
    partial class F_GestaoUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nud_Nivel = new System.Windows.Forms.NumericUpDown();
            this.Cb_Status = new System.Windows.Forms.ComboBox();
            this.Tb_Senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_ExcluirUsuario = new System.Windows.Forms.Button();
            this.Btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.Btn_FecharJanela = new System.Windows.Forms.Button();
            this.Btn_NovoUsuario = new System.Windows.Forms.Button();
            this.Dgv_Usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Nivel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "D = Desligado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "B = Bloqueado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "A = Ativo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nível";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Status";
            // 
            // Nud_Nivel
            // 
            this.Nud_Nivel.Location = new System.Drawing.Point(187, 173);
            this.Nud_Nivel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Nud_Nivel.Name = "Nud_Nivel";
            this.Nud_Nivel.Size = new System.Drawing.Size(129, 20);
            this.Nud_Nivel.TabIndex = 20;
            // 
            // Cb_Status
            // 
            this.Cb_Status.FormattingEnabled = true;
            this.Cb_Status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.Cb_Status.Location = new System.Drawing.Point(21, 173);
            this.Cb_Status.Name = "Cb_Status";
            this.Cb_Status.Size = new System.Drawing.Size(141, 21);
            this.Cb_Status.TabIndex = 19;
            // 
            // Tb_Senha
            // 
            this.Tb_Senha.Location = new System.Drawing.Point(187, 122);
            this.Tb_Senha.Name = "Tb_Senha";
            this.Tb_Senha.PasswordChar = '*';
            this.Tb_Senha.Size = new System.Drawing.Size(129, 20);
            this.Tb_Senha.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Senha";
            // 
            // Tb_Username
            // 
            this.Tb_Username.Location = new System.Drawing.Point(21, 122);
            this.Tb_Username.Name = "Tb_Username";
            this.Tb_Username.Size = new System.Drawing.Size(144, 20);
            this.Tb_Username.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username";
            // 
            // Tb_Nome
            // 
            this.Tb_Nome.Location = new System.Drawing.Point(21, 81);
            this.Tb_Nome.Name = "Tb_Nome";
            this.Tb_Nome.Size = new System.Drawing.Size(295, 20);
            this.Tb_Nome.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // Tb_Id
            // 
            this.Tb_Id.Location = new System.Drawing.Point(21, 41);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.ReadOnly = true;
            this.Tb_Id.Size = new System.Drawing.Size(144, 20);
            this.Tb_Id.TabIndex = 27;
            this.Tb_Id.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_ExcluirUsuario);
            this.panel1.Controls.Add(this.Btn_SalvarAlteracoes);
            this.panel1.Controls.Add(this.Btn_FecharJanela);
            this.panel1.Controls.Add(this.Btn_NovoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 27);
            this.panel1.TabIndex = 28;
            // 
            // Btn_ExcluirUsuario
            // 
            this.Btn_ExcluirUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExcluirUsuario.Location = new System.Drawing.Point(215, 0);
            this.Btn_ExcluirUsuario.Name = "Btn_ExcluirUsuario";
            this.Btn_ExcluirUsuario.Size = new System.Drawing.Size(101, 23);
            this.Btn_ExcluirUsuario.TabIndex = 31;
            this.Btn_ExcluirUsuario.Text = "Excluir Usuário";
            this.Btn_ExcluirUsuario.UseVisualStyleBackColor = true;
            this.Btn_ExcluirUsuario.Click += new System.EventHandler(this.Btn_ExcluirUsuario_Click);
            // 
            // Btn_SalvarAlteracoes
            // 
            this.Btn_SalvarAlteracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SalvarAlteracoes.Location = new System.Drawing.Point(104, 0);
            this.Btn_SalvarAlteracoes.Name = "Btn_SalvarAlteracoes";
            this.Btn_SalvarAlteracoes.Size = new System.Drawing.Size(101, 23);
            this.Btn_SalvarAlteracoes.TabIndex = 30;
            this.Btn_SalvarAlteracoes.Text = "Salvar Alterações";
            this.Btn_SalvarAlteracoes.UseVisualStyleBackColor = true;
            this.Btn_SalvarAlteracoes.Click += new System.EventHandler(this.Btn_SalvarAlteracoes_Click);
            // 
            // Btn_FecharJanela
            // 
            this.Btn_FecharJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_FecharJanela.Location = new System.Drawing.Point(322, 0);
            this.Btn_FecharJanela.Name = "Btn_FecharJanela";
            this.Btn_FecharJanela.Size = new System.Drawing.Size(85, 23);
            this.Btn_FecharJanela.TabIndex = 1;
            this.Btn_FecharJanela.Text = "Fechar Janela";
            this.Btn_FecharJanela.UseVisualStyleBackColor = true;
            this.Btn_FecharJanela.Click += new System.EventHandler(this.Btn_FecharJanela_Click);
            // 
            // Btn_NovoUsuario
            // 
            this.Btn_NovoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NovoUsuario.Location = new System.Drawing.Point(13, 0);
            this.Btn_NovoUsuario.Name = "Btn_NovoUsuario";
            this.Btn_NovoUsuario.Size = new System.Drawing.Size(85, 23);
            this.Btn_NovoUsuario.TabIndex = 0;
            this.Btn_NovoUsuario.Text = "Novo Usuário";
            this.Btn_NovoUsuario.UseVisualStyleBackColor = true;
            this.Btn_NovoUsuario.Click += new System.EventHandler(this.Btn_NovoUsuario_Click);
            // 
            // Dgv_Usuarios
            // 
            this.Dgv_Usuarios.AllowUserToAddRows = false;
            this.Dgv_Usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Usuarios.EnableHeadersVisualStyles = false;
            this.Dgv_Usuarios.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Usuarios.Location = new System.Drawing.Point(335, 26);
            this.Dgv_Usuarios.MultiSelect = false;
            this.Dgv_Usuarios.Name = "Dgv_Usuarios";
            this.Dgv_Usuarios.ReadOnly = true;
            this.Dgv_Usuarios.RowHeadersVisible = false;
            this.Dgv_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Usuarios.Size = new System.Drawing.Size(353, 168);
            this.Dgv_Usuarios.TabIndex = 29;
            this.Dgv_Usuarios.SelectionChanged += new System.EventHandler(this.Dgv_Usuarios_SelectionChanged);
            // 
            // F_GestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 264);
            this.Controls.Add(this.Dgv_Usuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tb_Id);
            this.Controls.Add(this.label9);
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
            this.Name = "F_GestaoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Usuarios";
            this.Load += new System.EventHandler(this.F_GestaoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Nud_Nivel;
        private System.Windows.Forms.ComboBox Cb_Status;
        private System.Windows.Forms.TextBox Tb_Senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_ExcluirUsuario;
        private System.Windows.Forms.Button Btn_SalvarAlteracoes;
        private System.Windows.Forms.Button Btn_FecharJanela;
        private System.Windows.Forms.Button Btn_NovoUsuario;
        private System.Windows.Forms.DataGridView Dgv_Usuarios;
    }
}