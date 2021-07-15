
namespace Saraiva_Academia
{
    partial class F_GestaoTurmas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_ImprimirTurma = new System.Windows.Forms.Button();
            this.Btn_ExcluirTurma = new System.Windows.Forms.Button();
            this.Btn_SalvarEdicoes = new System.Windows.Forms.Button();
            this.Btn_NovaTurma = new System.Windows.Forms.Button();
            this.dgv_Turmas = new System.Windows.Forms.DataGridView();
            this.Cb_Professor = new System.Windows.Forms.ComboBox();
            this.nud_MaximoAlunos = new System.Windows.Forms.NumericUpDown();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.cb_Horario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_DescricaoTurma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Vagas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaximoAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Fechar);
            this.panel1.Controls.Add(this.Btn_ImprimirTurma);
            this.panel1.Controls.Add(this.Btn_ExcluirTurma);
            this.panel1.Controls.Add(this.Btn_SalvarEdicoes);
            this.panel1.Controls.Add(this.Btn_NovaTurma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 31);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Fechar.Location = new System.Drawing.Point(650, 0);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(150, 23);
            this.Btn_Fechar.TabIndex = 9;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Btn_ImprimirTurma
            // 
            this.Btn_ImprimirTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ImprimirTurma.Location = new System.Drawing.Point(494, 0);
            this.Btn_ImprimirTurma.Name = "Btn_ImprimirTurma";
            this.Btn_ImprimirTurma.Size = new System.Drawing.Size(150, 23);
            this.Btn_ImprimirTurma.TabIndex = 8;
            this.Btn_ImprimirTurma.Text = "Imprimir Turma";
            this.Btn_ImprimirTurma.UseVisualStyleBackColor = true;
            this.Btn_ImprimirTurma.Click += new System.EventHandler(this.Btn_ImprimirTurma_Click);
            // 
            // Btn_ExcluirTurma
            // 
            this.Btn_ExcluirTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExcluirTurma.Location = new System.Drawing.Point(338, 0);
            this.Btn_ExcluirTurma.Name = "Btn_ExcluirTurma";
            this.Btn_ExcluirTurma.Size = new System.Drawing.Size(150, 23);
            this.Btn_ExcluirTurma.TabIndex = 7;
            this.Btn_ExcluirTurma.Text = "Excluir Turma";
            this.Btn_ExcluirTurma.UseVisualStyleBackColor = true;
            this.Btn_ExcluirTurma.Click += new System.EventHandler(this.Btn_ExcluirTurma_Click);
            // 
            // Btn_SalvarEdicoes
            // 
            this.Btn_SalvarEdicoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SalvarEdicoes.Location = new System.Drawing.Point(182, 0);
            this.Btn_SalvarEdicoes.Name = "Btn_SalvarEdicoes";
            this.Btn_SalvarEdicoes.Size = new System.Drawing.Size(150, 23);
            this.Btn_SalvarEdicoes.TabIndex = 6;
            this.Btn_SalvarEdicoes.Text = "Salvar Edições";
            this.Btn_SalvarEdicoes.UseVisualStyleBackColor = true;
            this.Btn_SalvarEdicoes.Click += new System.EventHandler(this.Btn_SalvarEdicoes_Click);
            // 
            // Btn_NovaTurma
            // 
            this.Btn_NovaTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NovaTurma.Location = new System.Drawing.Point(26, 0);
            this.Btn_NovaTurma.Name = "Btn_NovaTurma";
            this.Btn_NovaTurma.Size = new System.Drawing.Size(150, 23);
            this.Btn_NovaTurma.TabIndex = 5;
            this.Btn_NovaTurma.Text = "Nova Turma";
            this.Btn_NovaTurma.UseVisualStyleBackColor = true;
            this.Btn_NovaTurma.Click += new System.EventHandler(this.Btn_NovaTurma_Click);
            // 
            // dgv_Turmas
            // 
            this.dgv_Turmas.AllowUserToAddRows = false;
            this.dgv_Turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Turmas.EnableHeadersVisualStyles = false;
            this.dgv_Turmas.Location = new System.Drawing.Point(0, -1);
            this.dgv_Turmas.MultiSelect = false;
            this.dgv_Turmas.Name = "dgv_Turmas";
            this.dgv_Turmas.ReadOnly = true;
            this.dgv_Turmas.RowHeadersVisible = false;
            this.dgv_Turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Turmas.Size = new System.Drawing.Size(488, 414);
            this.dgv_Turmas.TabIndex = 0;
            this.dgv_Turmas.SelectionChanged += new System.EventHandler(this.dgv_Turmas_SelectionChanged);
            // 
            // Cb_Professor
            // 
            this.Cb_Professor.FormattingEnabled = true;
            this.Cb_Professor.Location = new System.Drawing.Point(490, 78);
            this.Cb_Professor.Name = "Cb_Professor";
            this.Cb_Professor.Size = new System.Drawing.Size(306, 21);
            this.Cb_Professor.TabIndex = 2;
            this.Cb_Professor.SelectedIndexChanged += new System.EventHandler(this.Cb_Professor_SelectedIndexChanged);
            // 
            // nud_MaximoAlunos
            // 
            this.nud_MaximoAlunos.Location = new System.Drawing.Point(491, 140);
            this.nud_MaximoAlunos.Name = "nud_MaximoAlunos";
            this.nud_MaximoAlunos.Size = new System.Drawing.Size(149, 20);
            this.nud_MaximoAlunos.TabIndex = 3;
            this.nud_MaximoAlunos.ValueChanged += new System.EventHandler(this.nud_MaximoAlunos_ValueChanged);
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Location = new System.Drawing.Point(646, 139);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(150, 21);
            this.cb_Status.TabIndex = 4;
            this.cb_Status.SelectedIndexChanged += new System.EventHandler(this.cb_Status_SelectedIndexChanged);
            // 
            // cb_Horario
            // 
            this.cb_Horario.FormattingEnabled = true;
            this.cb_Horario.Location = new System.Drawing.Point(491, 204);
            this.cb_Horario.Name = "cb_Horario";
            this.cb_Horario.Size = new System.Drawing.Size(305, 21);
            this.cb_Horario.TabIndex = 5;
            this.cb_Horario.SelectedIndexChanged += new System.EventHandler(this.cb_Horario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Máximo de alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Horário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descrição da Turma";
            // 
            // tb_DescricaoTurma
            // 
            this.tb_DescricaoTurma.Location = new System.Drawing.Point(490, 25);
            this.tb_DescricaoTurma.Name = "tb_DescricaoTurma";
            this.tb_DescricaoTurma.Size = new System.Drawing.Size(306, 20);
            this.tb_DescricaoTurma.TabIndex = 1;
            this.tb_DescricaoTurma.TextChanged += new System.EventHandler(this.tb_DescricaoTurma_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vagas restantes";
            // 
            // tb_Vagas
            // 
            this.tb_Vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_Vagas.Location = new System.Drawing.Point(494, 249);
            this.tb_Vagas.Name = "tb_Vagas";
            this.tb_Vagas.ReadOnly = true;
            this.tb_Vagas.Size = new System.Drawing.Size(83, 20);
            this.tb_Vagas.TabIndex = 12;
            this.tb_Vagas.TabStop = false;
            // 
            // F_GestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.tb_Vagas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_DescricaoTurma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Horario);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.nud_MaximoAlunos);
            this.Controls.Add(this.Cb_Professor);
            this.Controls.Add(this.dgv_Turmas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Turmas";
            this.Load += new System.EventHandler(this.F_GestaoTurmas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaximoAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Button Btn_ImprimirTurma;
        private System.Windows.Forms.Button Btn_ExcluirTurma;
        private System.Windows.Forms.Button Btn_SalvarEdicoes;
        private System.Windows.Forms.Button Btn_NovaTurma;
        private System.Windows.Forms.DataGridView dgv_Turmas;
        private System.Windows.Forms.ComboBox Cb_Professor;
        private System.Windows.Forms.NumericUpDown nud_MaximoAlunos;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.ComboBox cb_Horario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_DescricaoTurma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Vagas;
    }
}