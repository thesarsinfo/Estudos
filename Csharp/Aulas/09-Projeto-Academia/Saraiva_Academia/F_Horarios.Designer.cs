
namespace Saraiva_Academia
{
    partial class Horários
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Mtb_descricaoHorario = new System.Windows.Forms.MaskedTextBox();
            this.Tb_IdHorario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_Horarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_ExcluirHorario = new System.Windows.Forms.Button();
            this.Btn_SalvarHorario = new System.Windows.Forms.Button();
            this.Btn_NovoHorario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // Mtb_descricaoHorario
            // 
            this.Mtb_descricaoHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_descricaoHorario.Location = new System.Drawing.Point(139, 32);
            this.Mtb_descricaoHorario.Mask = "99:99 - 99:99";
            this.Mtb_descricaoHorario.Name = "Mtb_descricaoHorario";
            this.Mtb_descricaoHorario.Size = new System.Drawing.Size(100, 26);
            this.Mtb_descricaoHorario.TabIndex = 1;
            // 
            // Tb_IdHorario
            // 
            this.Tb_IdHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_IdHorario.Location = new System.Drawing.Point(29, 31);
            this.Tb_IdHorario.Name = "Tb_IdHorario";
            this.Tb_IdHorario.ReadOnly = true;
            this.Tb_IdHorario.Size = new System.Drawing.Size(100, 26);
            this.Tb_IdHorario.TabIndex = 2;
            this.Tb_IdHorario.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horário";
            // 
            // Dgv_Horarios
            // 
            this.Dgv_Horarios.AllowUserToAddRows = false;
            this.Dgv_Horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Horarios.EnableHeadersVisualStyles = false;
            this.Dgv_Horarios.Location = new System.Drawing.Point(29, 84);
            this.Dgv_Horarios.MultiSelect = false;
            this.Dgv_Horarios.Name = "Dgv_Horarios";
            this.Dgv_Horarios.ReadOnly = true;
            this.Dgv_Horarios.RowHeadersVisible = false;
            this.Dgv_Horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Horarios.Size = new System.Drawing.Size(404, 325);
            this.Dgv_Horarios.TabIndex = 4;
            this.Dgv_Horarios.SelectionChanged += new System.EventHandler(this.Dgv_Horarios_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Fechar);
            this.panel1.Controls.Add(this.Btn_ExcluirHorario);
            this.panel1.Controls.Add(this.Btn_SalvarHorario);
            this.panel1.Controls.Add(this.Btn_NovoHorario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 30);
            this.panel1.TabIndex = 5;
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Fechar.Location = new System.Drawing.Point(349, -2);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fechar.TabIndex = 3;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Btn_ExcluirHorario
            // 
            this.Btn_ExcluirHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExcluirHorario.Location = new System.Drawing.Point(250, -1);
            this.Btn_ExcluirHorario.Name = "Btn_ExcluirHorario";
            this.Btn_ExcluirHorario.Size = new System.Drawing.Size(84, 23);
            this.Btn_ExcluirHorario.TabIndex = 2;
            this.Btn_ExcluirHorario.Text = "Excluir Horário";
            this.Btn_ExcluirHorario.UseVisualStyleBackColor = true;
            this.Btn_ExcluirHorario.Click += new System.EventHandler(this.Btn_ExcluirHorario_Click);
            // 
            // Btn_SalvarHorario
            // 
            this.Btn_SalvarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SalvarHorario.Location = new System.Drawing.Point(139, -1);
            this.Btn_SalvarHorario.Name = "Btn_SalvarHorario";
            this.Btn_SalvarHorario.Size = new System.Drawing.Size(90, 23);
            this.Btn_SalvarHorario.TabIndex = 1;
            this.Btn_SalvarHorario.Text = "Salvar Horário";
            this.Btn_SalvarHorario.UseVisualStyleBackColor = true;
            this.Btn_SalvarHorario.Click += new System.EventHandler(this.Btn_SalvarHorario_Click);
            // 
            // Btn_NovoHorario
            // 
            this.Btn_NovoHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NovoHorario.Location = new System.Drawing.Point(29, -1);
            this.Btn_NovoHorario.Name = "Btn_NovoHorario";
            this.Btn_NovoHorario.Size = new System.Drawing.Size(85, 23);
            this.Btn_NovoHorario.TabIndex = 0;
            this.Btn_NovoHorario.Text = "Novo Horário";
            this.Btn_NovoHorario.UseVisualStyleBackColor = true;
            this.Btn_NovoHorario.Click += new System.EventHandler(this.Btn_NovoHorario_Click);
            // 
            // Horários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_Horarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_IdHorario);
            this.Controls.Add(this.Mtb_descricaoHorario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Horários";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Horarios";
            this.Load += new System.EventHandler(this.Horários_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Mtb_descricaoHorario;
        private System.Windows.Forms.TextBox Tb_IdHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_Horarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Button Btn_ExcluirHorario;
        private System.Windows.Forms.Button Btn_SalvarHorario;
        private System.Windows.Forms.Button Btn_NovoHorario;
    }
}