
namespace Aula62_TextBox
{
    partial class Form_ComboBox
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
            this.Cbx_Transporte = new System.Windows.Forms.ComboBox();
            this.Btn_MostrarSelecionado = new System.Windows.Forms.Button();
            this.Btn_LimparElementos = new System.Windows.Forms.Button();
            this.Btn_Resetar = new System.Windows.Forms.Button();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.Tb_Transportes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cbx_Transporte
            // 
            this.Cbx_Transporte.FormattingEnabled = true;
            this.Cbx_Transporte.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.Cbx_Transporte.Location = new System.Drawing.Point(12, 12);
            this.Cbx_Transporte.Name = "Cbx_Transporte";
            this.Cbx_Transporte.Size = new System.Drawing.Size(185, 23);
            this.Cbx_Transporte.TabIndex = 0;
            this.Cbx_Transporte.SelectedIndexChanged += new System.EventHandler(this.Cbx_Transporte_SelectedIndexChanged);
            // 
            // Btn_MostrarSelecionado
            // 
            this.Btn_MostrarSelecionado.Location = new System.Drawing.Point(203, 11);
            this.Btn_MostrarSelecionado.Name = "Btn_MostrarSelecionado";
            this.Btn_MostrarSelecionado.Size = new System.Drawing.Size(153, 23);
            this.Btn_MostrarSelecionado.TabIndex = 1;
            this.Btn_MostrarSelecionado.Text = "Mostrar o Selecionado";
            this.Btn_MostrarSelecionado.UseVisualStyleBackColor = true;
            this.Btn_MostrarSelecionado.Click += new System.EventHandler(this.Btn_MostrarSelecionado_Click);
            // 
            // Btn_LimparElementos
            // 
            this.Btn_LimparElementos.Location = new System.Drawing.Point(203, 41);
            this.Btn_LimparElementos.Name = "Btn_LimparElementos";
            this.Btn_LimparElementos.Size = new System.Drawing.Size(153, 23);
            this.Btn_LimparElementos.TabIndex = 2;
            this.Btn_LimparElementos.Text = "Limpar Elementos";
            this.Btn_LimparElementos.UseVisualStyleBackColor = true;
            this.Btn_LimparElementos.Click += new System.EventHandler(this.Btn_LimparElementos_Click);
            // 
            // Btn_Resetar
            // 
            this.Btn_Resetar.Location = new System.Drawing.Point(203, 71);
            this.Btn_Resetar.Name = "Btn_Resetar";
            this.Btn_Resetar.Size = new System.Drawing.Size(153, 23);
            this.Btn_Resetar.TabIndex = 3;
            this.Btn_Resetar.Text = "Resetar";
            this.Btn_Resetar.UseVisualStyleBackColor = true;
            this.Btn_Resetar.Click += new System.EventHandler(this.Btn_Resetar_Click);
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.Location = new System.Drawing.Point(203, 153);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(153, 23);
            this.Btn_Adicionar.TabIndex = 4;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = true;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // Tb_Transportes
            // 
            this.Tb_Transportes.Location = new System.Drawing.Point(203, 124);
            this.Tb_Transportes.Name = "Tb_Transportes";
            this.Tb_Transportes.Size = new System.Drawing.Size(153, 23);
            this.Tb_Transportes.TabIndex = 5;
            // 
            // Form_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 310);
            this.Controls.Add(this.Tb_Transportes);
            this.Controls.Add(this.Btn_Adicionar);
            this.Controls.Add(this.Btn_Resetar);
            this.Controls.Add(this.Btn_LimparElementos);
            this.Controls.Add(this.Btn_MostrarSelecionado);
            this.Controls.Add(this.Cbx_Transporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbx_Transporte;
        private System.Windows.Forms.Button Btn_MostrarSelecionado;
        private System.Windows.Forms.Button Btn_LimparElementos;
        private System.Windows.Forms.Button Btn_Resetar;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.TextBox Tb_Transportes;
    }
}