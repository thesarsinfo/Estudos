namespace Cadastro_Empresa
{
    partial class Form_Cadastro_Empresa
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
            this.Cb_Estado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_NomeFantasia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MTb_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.Btn_NovaEmpresa = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_SalvarEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UF:";
            // 
            // Cb_Estado
            // 
            this.Cb_Estado.FormattingEnabled = true;
            this.Cb_Estado.Location = new System.Drawing.Point(91, 39);
            this.Cb_Estado.Name = "Cb_Estado";
            this.Cb_Estado.Size = new System.Drawing.Size(46, 21);
            this.Cb_Estado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Fantasia:";
            // 
            // Tb_NomeFantasia
            // 
            this.Tb_NomeFantasia.Location = new System.Drawing.Point(91, 75);
            this.Tb_NomeFantasia.Name = "Tb_NomeFantasia";
            this.Tb_NomeFantasia.Size = new System.Drawing.Size(158, 20);
            this.Tb_NomeFantasia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CNPJ:";
            // 
            // MTb_CNPJ
            // 
            this.MTb_CNPJ.Location = new System.Drawing.Point(92, 109);
            this.MTb_CNPJ.Mask = "00,000,0000/0000-00";
            this.MTb_CNPJ.Name = "MTb_CNPJ";
            this.MTb_CNPJ.Size = new System.Drawing.Size(157, 20);
            this.MTb_CNPJ.TabIndex = 5;
            this.MTb_CNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Btn_NovaEmpresa
            // 
            this.Btn_NovaEmpresa.Location = new System.Drawing.Point(297, 39);
            this.Btn_NovaEmpresa.Name = "Btn_NovaEmpresa";
            this.Btn_NovaEmpresa.Size = new System.Drawing.Size(103, 23);
            this.Btn_NovaEmpresa.TabIndex = 6;
            this.Btn_NovaEmpresa.Text = "Nova Empresa";
            this.Btn_NovaEmpresa.UseVisualStyleBackColor = true;
            this.Btn_NovaEmpresa.Click += new System.EventHandler(this.Btn_NovaEmpresa_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(297, 75);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(103, 23);
            this.Btn_Limpar.TabIndex = 7;
            this.Btn_Limpar.Text = "Limpar Campos";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_SalvarEmpresa
            // 
            this.Btn_SalvarEmpresa.Location = new System.Drawing.Point(297, 109);
            this.Btn_SalvarEmpresa.Name = "Btn_SalvarEmpresa";
            this.Btn_SalvarEmpresa.Size = new System.Drawing.Size(103, 23);
            this.Btn_SalvarEmpresa.TabIndex = 10;
            this.Btn_SalvarEmpresa.Text = "Salvar Empresa";
            this.Btn_SalvarEmpresa.UseVisualStyleBackColor = true;
            this.Btn_SalvarEmpresa.Click += new System.EventHandler(this.Btn_SalvarEmpresa_Click);
            // 
            // Form_Cadastro_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 168);
            this.Controls.Add(this.Btn_SalvarEmpresa);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_NovaEmpresa);
            this.Controls.Add(this.MTb_CNPJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_NomeFantasia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_Estado);
            this.Controls.Add(this.label1);
            this.Name = "Form_Cadastro_Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Cadastro_Empresa";
            this.Load += new System.EventHandler(this.Form_Cadastro_Empresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Cb_Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Tb_NomeFantasia;
        public System.Windows.Forms.MaskedTextBox MTb_CNPJ;
        public System.Windows.Forms.Button Btn_NovaEmpresa;
        public System.Windows.Forms.Button Btn_Limpar;
        public System.Windows.Forms.Button Btn_SalvarEmpresa;
    }
}