
namespace Saraiva_Academia
{
    partial class F_NovoAluno
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
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Turma = new System.Windows.Forms.TextBox();
            this.btn_SelecionaTurma = new System.Windows.Forms.Button();
            this.btn_SelecionaPlano = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Plano = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pb_Foto = new System.Windows.Forms.PictureBox();
            this.btn_Foto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Nome
            // 
            this.tb_Nome.Enabled = false;
            this.tb_Nome.Location = new System.Drawing.Point(26, 31);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(339, 20);
            this.tb_Nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Status";
            // 
            // cb_Status
            // 
            this.cb_Status.Enabled = false;
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Location = new System.Drawing.Point(26, 83);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(142, 21);
            this.cb_Status.TabIndex = 2;
            // 
            // mtb_Telefone
            // 
            this.mtb_Telefone.Enabled = false;
            this.mtb_Telefone.Location = new System.Drawing.Point(385, 30);
            this.mtb_Telefone.Mask = "(00) 0-0000-0000";
            this.mtb_Telefone.Name = "mtb_Telefone";
            this.mtb_Telefone.Size = new System.Drawing.Size(140, 20);
            this.mtb_Telefone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Turma";
            // 
            // tb_Turma
            // 
            this.tb_Turma.Location = new System.Drawing.Point(187, 85);
            this.tb_Turma.Name = "tb_Turma";
            this.tb_Turma.ReadOnly = true;
            this.tb_Turma.Size = new System.Drawing.Size(302, 20);
            this.tb_Turma.TabIndex = 10;
            this.tb_Turma.TabStop = false;
            this.tb_Turma.Tag = "4";
            // 
            // btn_SelecionaTurma
            // 
            this.btn_SelecionaTurma.Location = new System.Drawing.Point(492, 85);
            this.btn_SelecionaTurma.Name = "btn_SelecionaTurma";
            this.btn_SelecionaTurma.Size = new System.Drawing.Size(33, 20);
            this.btn_SelecionaTurma.TabIndex = 3;
            this.btn_SelecionaTurma.Text = " ...";
            this.btn_SelecionaTurma.UseVisualStyleBackColor = true;
            this.btn_SelecionaTurma.Click += new System.EventHandler(this.btn_SelecionaTurma_Click);
            // 
            // btn_SelecionaPlano
            // 
            this.btn_SelecionaPlano.Location = new System.Drawing.Point(267, 140);
            this.btn_SelecionaPlano.Name = "btn_SelecionaPlano";
            this.btn_SelecionaPlano.Size = new System.Drawing.Size(33, 20);
            this.btn_SelecionaPlano.TabIndex = 4;
            this.btn_SelecionaPlano.Text = " ...";
            this.btn_SelecionaPlano.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Plano";
            // 
            // tb_Plano
            // 
            this.tb_Plano.Location = new System.Drawing.Point(26, 140);
            this.tb_Plano.Name = "tb_Plano";
            this.tb_Plano.ReadOnly = true;
            this.tb_Plano.Size = new System.Drawing.Size(247, 20);
            this.tb_Plano.TabIndex = 13;
            this.tb_Plano.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Gravar);
            this.panel1.Controls.Add(this.btn_Novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 30);
            this.panel1.TabIndex = 16;
            this.panel1.TabStop = true;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(547, 4);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(100, 23);
            this.btn_Fechar.TabIndex = 8;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(300, 4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 23);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Enabled = false;
            this.btn_Gravar.Location = new System.Drawing.Point(175, 4);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(100, 23);
            this.btn_Gravar.TabIndex = 6;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(50, 4);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(100, 23);
            this.btn_Novo.TabIndex = 5;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // pb_Foto
            // 
            this.pb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Foto.Location = new System.Drawing.Point(562, 12);
            this.pb_Foto.Name = "pb_Foto";
            this.pb_Foto.Size = new System.Drawing.Size(85, 113);
            this.pb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Foto.TabIndex = 25;
            this.pb_Foto.TabStop = false;
            // 
            // btn_Foto
            // 
            this.btn_Foto.Location = new System.Drawing.Point(562, 138);
            this.btn_Foto.Name = "btn_Foto";
            this.btn_Foto.Size = new System.Drawing.Size(85, 23);
            this.btn_Foto.TabIndex = 26;
            this.btn_Foto.Text = "Foto";
            this.btn_Foto.UseVisualStyleBackColor = true;
            this.btn_Foto.Click += new System.EventHandler(this.btn_Foto_Click);
            // 
            // F_NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 207);
            this.Controls.Add(this.btn_Foto);
            this.Controls.Add(this.pb_Foto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_SelecionaPlano);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Plano);
            this.Controls.Add(this.btn_SelecionaTurma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Turma);
            this.Controls.Add(this.mtb_Telefone);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Novo Aluno";
            this.Load += new System.EventHandler(this.F_NovoAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.MaskedTextBox mtb_Telefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SelecionaTurma;
        private System.Windows.Forms.Button btn_SelecionaPlano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Plano;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Novo;
        public System.Windows.Forms.TextBox tb_Turma;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pb_Foto;
        private System.Windows.Forms.Button btn_Foto;
    }
}