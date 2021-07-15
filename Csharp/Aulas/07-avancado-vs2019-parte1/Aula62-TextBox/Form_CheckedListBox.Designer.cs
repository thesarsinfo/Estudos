
namespace Aula62_TextBox
{
    partial class Form_CheckedListBox
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
            this.CLB_Transportes = new System.Windows.Forms.CheckedListBox();
            this.Btn_MostrarSelecionados = new System.Windows.Forms.Button();
            this.Btn_LimparListas = new System.Windows.Forms.Button();
            this.Btn_ResetarLista = new System.Windows.Forms.Button();
            this.Btn_AdicionarNovoTransporte = new System.Windows.Forms.Button();
            this.TB_NovoTransporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CLB_Transportes
            // 
            this.CLB_Transportes.FormattingEnabled = true;
            this.CLB_Transportes.Items.AddRange(new object[] {
            "Carro",
            "Aviao",
            "Navio",
            "Ônibus",
            "Trem"});
            this.CLB_Transportes.Location = new System.Drawing.Point(12, 12);
            this.CLB_Transportes.Name = "CLB_Transportes";
            this.CLB_Transportes.Size = new System.Drawing.Size(120, 238);
            this.CLB_Transportes.TabIndex = 0;
            // 
            // Btn_MostrarSelecionados
            // 
            this.Btn_MostrarSelecionados.Location = new System.Drawing.Point(138, 12);
            this.Btn_MostrarSelecionados.Name = "Btn_MostrarSelecionados";
            this.Btn_MostrarSelecionados.Size = new System.Drawing.Size(133, 23);
            this.Btn_MostrarSelecionados.TabIndex = 1;
            this.Btn_MostrarSelecionados.Text = "Mostrar Selecionados";
            this.Btn_MostrarSelecionados.UseVisualStyleBackColor = true;
            this.Btn_MostrarSelecionados.Click += new System.EventHandler(this.Btn_MostrarSelecionados_Click);
            // 
            // Btn_LimparListas
            // 
            this.Btn_LimparListas.Location = new System.Drawing.Point(138, 42);
            this.Btn_LimparListas.Name = "Btn_LimparListas";
            this.Btn_LimparListas.Size = new System.Drawing.Size(133, 23);
            this.Btn_LimparListas.TabIndex = 2;
            this.Btn_LimparListas.Text = "Limpar Lista";
            this.Btn_LimparListas.UseVisualStyleBackColor = true;
            this.Btn_LimparListas.Click += new System.EventHandler(this.Btn_LimparListas_Click);
            // 
            // Btn_ResetarLista
            // 
            this.Btn_ResetarLista.Location = new System.Drawing.Point(138, 72);
            this.Btn_ResetarLista.Name = "Btn_ResetarLista";
            this.Btn_ResetarLista.Size = new System.Drawing.Size(133, 23);
            this.Btn_ResetarLista.TabIndex = 3;
            this.Btn_ResetarLista.Text = "Resetar Lista";
            this.Btn_ResetarLista.UseVisualStyleBackColor = true;
            this.Btn_ResetarLista.Click += new System.EventHandler(this.Btn_ResetarLista_Click);
            // 
            // Btn_AdicionarNovoTransporte
            // 
            this.Btn_AdicionarNovoTransporte.Location = new System.Drawing.Point(91, 264);
            this.Btn_AdicionarNovoTransporte.Name = "Btn_AdicionarNovoTransporte";
            this.Btn_AdicionarNovoTransporte.Size = new System.Drawing.Size(193, 23);
            this.Btn_AdicionarNovoTransporte.TabIndex = 4;
            this.Btn_AdicionarNovoTransporte.Text = "Adicionar Novo Transporte";
            this.Btn_AdicionarNovoTransporte.UseVisualStyleBackColor = true;
            this.Btn_AdicionarNovoTransporte.Click += new System.EventHandler(this.Btn_AdicionarNovoTransporte_Click);
            // 
            // TB_NovoTransporte
            // 
            this.TB_NovoTransporte.Location = new System.Drawing.Point(138, 223);
            this.TB_NovoTransporte.Name = "TB_NovoTransporte";
            this.TB_NovoTransporte.Size = new System.Drawing.Size(146, 23);
            this.TB_NovoTransporte.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_NovoTransporte);
            this.Controls.Add(this.Btn_AdicionarNovoTransporte);
            this.Controls.Add(this.Btn_ResetarLista);
            this.Controls.Add(this.Btn_LimparListas);
            this.Controls.Add(this.Btn_MostrarSelecionados);
            this.Controls.Add(this.CLB_Transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checked List Box";
            this.Load += new System.EventHandler(this.Form_CheckedListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CLB_Transportes;
        private System.Windows.Forms.Button Btn_MostrarSelecionados;
        private System.Windows.Forms.Button Btn_LimparListas;
        private System.Windows.Forms.Button Btn_ResetarLista;
        private System.Windows.Forms.Button Btn_AdicionarNovoTransporte;
        private System.Windows.Forms.TextBox TB_NovoTransporte;
        private System.Windows.Forms.Label label1;
    }
}