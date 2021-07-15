
namespace Saraiva_Academia
{
    partial class F_GestaoAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Turmas = new System.Windows.Forms.ComboBox();
            this.btn_ImprimirCarteirinha = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SalvarEdicoes = new System.Windows.Forms.Button();
            this.btn_ExcluirAluno = new System.Windows.Forms.Button();
            this.btn_Financeiro = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.pb_FotoAluno = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Alunos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(406, 27);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(325, 20);
            this.tb_Nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // mtb_Telefone
            // 
            this.mtb_Telefone.Location = new System.Drawing.Point(406, 67);
            this.mtb_Telefone.Mask = "(00)0-0000-0000";
            this.mtb_Telefone.Name = "mtb_Telefone";
            this.mtb_Telefone.Size = new System.Drawing.Size(144, 20);
            this.mtb_Telefone.TabIndex = 4;
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Location = new System.Drawing.Point(557, 66);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(174, 21);
            this.cb_Status.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Turmas";
            // 
            // cb_Turmas
            // 
            this.cb_Turmas.FormattingEnabled = true;
            this.cb_Turmas.Location = new System.Drawing.Point(406, 108);
            this.cb_Turmas.Name = "cb_Turmas";
            this.cb_Turmas.Size = new System.Drawing.Size(325, 21);
            this.cb_Turmas.TabIndex = 7;
            // 
            // btn_ImprimirCarteirinha
            // 
            this.btn_ImprimirCarteirinha.Location = new System.Drawing.Point(406, 149);
            this.btn_ImprimirCarteirinha.Name = "btn_ImprimirCarteirinha";
            this.btn_ImprimirCarteirinha.Size = new System.Drawing.Size(325, 23);
            this.btn_ImprimirCarteirinha.TabIndex = 9;
            this.btn_ImprimirCarteirinha.Text = "Imprimir Carteirinha";
            this.btn_ImprimirCarteirinha.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_Financeiro);
            this.panel1.Controls.Add(this.btn_ExcluirAluno);
            this.panel1.Controls.Add(this.btn_SalvarEdicoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 34);
            this.panel1.TabIndex = 10;
            // 
            // btn_SalvarEdicoes
            // 
            this.btn_SalvarEdicoes.Location = new System.Drawing.Point(13, 4);
            this.btn_SalvarEdicoes.Name = "btn_SalvarEdicoes";
            this.btn_SalvarEdicoes.Size = new System.Drawing.Size(175, 23);
            this.btn_SalvarEdicoes.TabIndex = 0;
            this.btn_SalvarEdicoes.Text = "Salvar Edições";
            this.btn_SalvarEdicoes.UseVisualStyleBackColor = true;
            this.btn_SalvarEdicoes.Click += new System.EventHandler(this.btn_SalvarEdicoes_Click);
            // 
            // btn_ExcluirAluno
            // 
            this.btn_ExcluirAluno.Location = new System.Drawing.Point(194, 4);
            this.btn_ExcluirAluno.Name = "btn_ExcluirAluno";
            this.btn_ExcluirAluno.Size = new System.Drawing.Size(175, 23);
            this.btn_ExcluirAluno.TabIndex = 1;
            this.btn_ExcluirAluno.Text = "Excluir Aluno";
            this.btn_ExcluirAluno.UseVisualStyleBackColor = true;
            this.btn_ExcluirAluno.Click += new System.EventHandler(this.btn_ExcluirAluno_Click);
            // 
            // btn_Financeiro
            // 
            this.btn_Financeiro.Location = new System.Drawing.Point(375, 4);
            this.btn_Financeiro.Name = "btn_Financeiro";
            this.btn_Financeiro.Size = new System.Drawing.Size(175, 23);
            this.btn_Financeiro.TabIndex = 2;
            this.btn_Financeiro.Text = "Financeiro";
            this.btn_Financeiro.UseVisualStyleBackColor = true;
            this.btn_Financeiro.Click += new System.EventHandler(this.btn_Financeiro_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(556, 4);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(175, 23);
            this.btn_Fechar.TabIndex = 3;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // pb_FotoAluno
            // 
            this.pb_FotoAluno.Location = new System.Drawing.Point(406, 188);
            this.pb_FotoAluno.Name = "pb_FotoAluno";
            this.pb_FotoAluno.Size = new System.Drawing.Size(100, 133);
            this.pb_FotoAluno.TabIndex = 11;
            this.pb_FotoAluno.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Clique duplo para alterar foto";
            // 
            // dgv_Alunos
            // 
            this.dgv_Alunos.AllowUserToAddRows = false;
            this.dgv_Alunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Alunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alunos.EnableHeadersVisualStyles = false;
            this.dgv_Alunos.Location = new System.Drawing.Point(0, 0);
            this.dgv_Alunos.MultiSelect = false;
            this.dgv_Alunos.Name = "dgv_Alunos";
            this.dgv_Alunos.ReadOnly = true;
            this.dgv_Alunos.RowHeadersVisible = false;
            this.dgv_Alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Alunos.Size = new System.Drawing.Size(397, 414);
            this.dgv_Alunos.TabIndex = 13;
            this.dgv_Alunos.SelectionChanged += new System.EventHandler(this.dgv_Alunos_SelectionChanged);
            // 
            // F_GestaoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.dgv_Alunos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb_FotoAluno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ImprimirCarteirinha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Turmas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.mtb_Telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Alunos";
            this.Load += new System.EventHandler(this.F_GestaoAlunos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_FotoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_Telefone;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Turmas;
        private System.Windows.Forms.Button btn_ImprimirCarteirinha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Financeiro;
        private System.Windows.Forms.Button btn_ExcluirAluno;
        private System.Windows.Forms.Button btn_SalvarEdicoes;
        private System.Windows.Forms.PictureBox pb_FotoAluno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Alunos;
    }
}