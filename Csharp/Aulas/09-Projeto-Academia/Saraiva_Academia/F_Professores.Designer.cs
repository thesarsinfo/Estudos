
namespace Saraiva_Academia
{
    partial class F_Professores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_FecharJanela = new System.Windows.Forms.Button();
            this.Btn_ExcluirProfessor = new System.Windows.Forms.Button();
            this.Btn_SalvarAlteracoes = new System.Windows.Forms.Button();
            this.Btn_NovoProfessor = new System.Windows.Forms.Button();
            this.Dgv_Professores = new System.Windows.Forms.DataGridView();
            this.Tb_IdProfessor = new System.Windows.Forms.TextBox();
            this.Tb_Professor = new System.Windows.Forms.TextBox();
            this.Mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Professores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_FecharJanela);
            this.panel1.Controls.Add(this.Btn_ExcluirProfessor);
            this.panel1.Controls.Add(this.Btn_SalvarAlteracoes);
            this.panel1.Controls.Add(this.Btn_NovoProfessor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 29);
            this.panel1.TabIndex = 0;
            // 
            // Btn_FecharJanela
            // 
            this.Btn_FecharJanela.Location = new System.Drawing.Point(383, 0);
            this.Btn_FecharJanela.Name = "Btn_FecharJanela";
            this.Btn_FecharJanela.Size = new System.Drawing.Size(115, 23);
            this.Btn_FecharJanela.TabIndex = 3;
            this.Btn_FecharJanela.TabStop = false;
            this.Btn_FecharJanela.Text = "Fechar Janela";
            this.Btn_FecharJanela.UseVisualStyleBackColor = true;
            this.Btn_FecharJanela.Click += new System.EventHandler(this.Btn_FecharJanela_Click);
            // 
            // Btn_ExcluirProfessor
            // 
            this.Btn_ExcluirProfessor.Location = new System.Drawing.Point(253, 0);
            this.Btn_ExcluirProfessor.Name = "Btn_ExcluirProfessor";
            this.Btn_ExcluirProfessor.Size = new System.Drawing.Size(115, 23);
            this.Btn_ExcluirProfessor.TabIndex = 2;
            this.Btn_ExcluirProfessor.TabStop = false;
            this.Btn_ExcluirProfessor.Text = "Excluir Professor";
            this.Btn_ExcluirProfessor.UseVisualStyleBackColor = true;
            this.Btn_ExcluirProfessor.Click += new System.EventHandler(this.Btn_ExcluirProfessor_Click);
            // 
            // Btn_SalvarAlteracoes
            // 
            this.Btn_SalvarAlteracoes.Location = new System.Drawing.Point(122, 0);
            this.Btn_SalvarAlteracoes.Name = "Btn_SalvarAlteracoes";
            this.Btn_SalvarAlteracoes.Size = new System.Drawing.Size(115, 23);
            this.Btn_SalvarAlteracoes.TabIndex = 1;
            this.Btn_SalvarAlteracoes.TabStop = false;
            this.Btn_SalvarAlteracoes.Text = "Salvar Alterações";
            this.Btn_SalvarAlteracoes.UseVisualStyleBackColor = true;
            this.Btn_SalvarAlteracoes.Click += new System.EventHandler(this.Btn_SalvarAlteracoes_Click);
            // 
            // Btn_NovoProfessor
            // 
            this.Btn_NovoProfessor.Location = new System.Drawing.Point(13, 0);
            this.Btn_NovoProfessor.Name = "Btn_NovoProfessor";
            this.Btn_NovoProfessor.Size = new System.Drawing.Size(88, 23);
            this.Btn_NovoProfessor.TabIndex = 0;
            this.Btn_NovoProfessor.Text = "Novo Professor";
            this.Btn_NovoProfessor.UseVisualStyleBackColor = true;
            this.Btn_NovoProfessor.Click += new System.EventHandler(this.Btn_NovoProfessor_Click);
            // 
            // Dgv_Professores
            // 
            this.Dgv_Professores.AllowUserToAddRows = false;
            this.Dgv_Professores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Professores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Professores.EnableHeadersVisualStyles = false;
            this.Dgv_Professores.Location = new System.Drawing.Point(12, 70);
            this.Dgv_Professores.MultiSelect = false;
            this.Dgv_Professores.Name = "Dgv_Professores";
            this.Dgv_Professores.ReadOnly = true;
            this.Dgv_Professores.RowHeadersVisible = false;
            this.Dgv_Professores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Professores.Size = new System.Drawing.Size(486, 345);
            this.Dgv_Professores.TabIndex = 1;
            this.Dgv_Professores.SelectionChanged += new System.EventHandler(this.Dgv_Professores_SelectionChanged);
            // 
            // Tb_IdProfessor
            // 
            this.Tb_IdProfessor.Location = new System.Drawing.Point(13, 44);
            this.Tb_IdProfessor.Name = "Tb_IdProfessor";
            this.Tb_IdProfessor.ReadOnly = true;
            this.Tb_IdProfessor.Size = new System.Drawing.Size(88, 20);
            this.Tb_IdProfessor.TabIndex = 2;
            // 
            // Tb_Professor
            // 
            this.Tb_Professor.Location = new System.Drawing.Point(122, 43);
            this.Tb_Professor.Name = "Tb_Professor";
            this.Tb_Professor.Size = new System.Drawing.Size(246, 20);
            this.Tb_Professor.TabIndex = 3;
            // 
            // Mtb_Telefone
            // 
            this.Mtb_Telefone.Location = new System.Drawing.Point(383, 43);
            this.Mtb_Telefone.Mask = "(00)00000-0000";
            this.Mtb_Telefone.Name = "Mtb_Telefone";
            this.Mtb_Telefone.Size = new System.Drawing.Size(115, 20);
            this.Mtb_Telefone.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefone:";
            // 
            // F_Professores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mtb_Telefone);
            this.Controls.Add(this.Tb_Professor);
            this.Controls.Add(this.Tb_IdProfessor);
            this.Controls.Add(this.Dgv_Professores);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Professores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Professores";
            this.Load += new System.EventHandler(this.F_Professores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Professores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_FecharJanela;
        private System.Windows.Forms.Button Btn_ExcluirProfessor;
        private System.Windows.Forms.Button Btn_SalvarAlteracoes;
        private System.Windows.Forms.Button Btn_NovoProfessor;
        private System.Windows.Forms.DataGridView Dgv_Professores;
        private System.Windows.Forms.TextBox Tb_IdProfessor;
        private System.Windows.Forms.TextBox Tb_Professor;
        private System.Windows.Forms.MaskedTextBox Mtb_Telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}