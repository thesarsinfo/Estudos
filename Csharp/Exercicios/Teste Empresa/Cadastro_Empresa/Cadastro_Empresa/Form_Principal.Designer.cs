namespace Cadastro_Empresa
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Cadastro_Empresa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Cadastro_Empresa
            // 
            this.Btn_Cadastro_Empresa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Cadastro_Empresa.Location = new System.Drawing.Point(12, 209);
            this.Btn_Cadastro_Empresa.Name = "Btn_Cadastro_Empresa";
            this.Btn_Cadastro_Empresa.Size = new System.Drawing.Size(122, 80);
            this.Btn_Cadastro_Empresa.TabIndex = 0;
            this.Btn_Cadastro_Empresa.Text = "Cadastro Empresa";
            this.Btn_Cadastro_Empresa.UseVisualStyleBackColor = false;
            this.Btn_Cadastro_Empresa.Click += new System.EventHandler(this.Btn_Cadastro_Empresa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "testar conexão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Cadastro_Empresa);
            this.Name = "Form_Principal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Btn_Cadastro_Empresa;
        private System.Windows.Forms.Button button1;
    }
}

