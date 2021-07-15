
namespace Editor_de_Texto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Ms_Arquivo = new System.Windows.Forms.MenuStrip();
            this.Tsmi_Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Novo = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Imprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Colar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Desfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Refazer = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Formatar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Negrito = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Italico = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Sublinhado = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmic_Alinhamento = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmicc_Centralizar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmicc_AlinharEsquerda = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmicc_AlinharDireita = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmicc_Justificar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Novo = new System.Windows.Forms.ToolStripButton();
            this.Btn_Abrir = new System.Windows.Forms.ToolStripButton();
            this.Btn_Salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Copiar = new System.Windows.Forms.ToolStripButton();
            this.Btn_Colar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Negrito = new System.Windows.Forms.ToolStripButton();
            this.Btn_Italico = new System.Windows.Forms.ToolStripButton();
            this.Btn_Sublinhado = new System.Windows.Forms.ToolStripButton();
            this.Btn_Fonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_AlinharEsquerda = new System.Windows.Forms.ToolStripButton();
            this.Btn_Centralizar = new System.Windows.Forms.ToolStripButton();
            this.Btn_AlinharDireita = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Ms_Arquivo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(559, 398);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Ms_Arquivo
            // 
            this.Ms_Arquivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Arquivo,
            this.Tsmi_Editar,
            this.Tsmi_Formatar});
            this.Ms_Arquivo.Location = new System.Drawing.Point(0, 0);
            this.Ms_Arquivo.Name = "Ms_Arquivo";
            this.Ms_Arquivo.Size = new System.Drawing.Size(571, 24);
            this.Ms_Arquivo.TabIndex = 1;
            this.Ms_Arquivo.Text = "Arquivo";
            // 
            // Tsmi_Arquivo
            // 
            this.Tsmi_Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmic_Novo,
            this.Tsmic_Abrir,
            this.Tsmic_Salvar,
            this.Tsmic_Imprimir,
            this.Tsmic_Fechar});
            this.Tsmi_Arquivo.Name = "Tsmi_Arquivo";
            this.Tsmi_Arquivo.Size = new System.Drawing.Size(61, 20);
            this.Tsmi_Arquivo.Text = "Arquivo";
            // 
            // Tsmic_Novo
            // 
            this.Tsmic_Novo.Name = "Tsmic_Novo";
            this.Tsmic_Novo.Size = new System.Drawing.Size(120, 22);
            this.Tsmic_Novo.Text = "Novo";
            this.Tsmic_Novo.Click += new System.EventHandler(this.Tsmic_Novo_Click);
            // 
            // Tsmic_Abrir
            // 
            this.Tsmic_Abrir.Name = "Tsmic_Abrir";
            this.Tsmic_Abrir.Size = new System.Drawing.Size(120, 22);
            this.Tsmic_Abrir.Text = "Abrir";
            this.Tsmic_Abrir.Click += new System.EventHandler(this.Tsmic_Abrir_Click);
            // 
            // Tsmic_Salvar
            // 
            this.Tsmic_Salvar.Name = "Tsmic_Salvar";
            this.Tsmic_Salvar.Size = new System.Drawing.Size(120, 22);
            this.Tsmic_Salvar.Text = "Salvar";
            this.Tsmic_Salvar.Click += new System.EventHandler(this.Tsmic_Salvar_Click);
            // 
            // Tsmic_Imprimir
            // 
            this.Tsmic_Imprimir.Name = "Tsmic_Imprimir";
            this.Tsmic_Imprimir.Size = new System.Drawing.Size(120, 22);
            this.Tsmic_Imprimir.Text = "Imprimir";
            this.Tsmic_Imprimir.Click += new System.EventHandler(this.Tsmic_Imprimir_Click);
            // 
            // Tsmic_Fechar
            // 
            this.Tsmic_Fechar.Name = "Tsmic_Fechar";
            this.Tsmic_Fechar.Size = new System.Drawing.Size(120, 22);
            this.Tsmic_Fechar.Text = "Fechar";
            // 
            // Tsmi_Editar
            // 
            this.Tsmi_Editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmic_Copiar,
            this.Tsmic_Colar,
            this.Tsmic_Desfazer,
            this.Tsmic_Refazer});
            this.Tsmi_Editar.Name = "Tsmi_Editar";
            this.Tsmi_Editar.Size = new System.Drawing.Size(49, 20);
            this.Tsmi_Editar.Text = "Editar";
            // 
            // Tsmic_Copiar
            // 
            this.Tsmic_Copiar.Name = "Tsmic_Copiar";
            this.Tsmic_Copiar.Size = new System.Drawing.Size(118, 22);
            this.Tsmic_Copiar.Text = "Copiar";
            this.Tsmic_Copiar.Click += new System.EventHandler(this.Tsmic_Copiar_Click);
            // 
            // Tsmic_Colar
            // 
            this.Tsmic_Colar.Name = "Tsmic_Colar";
            this.Tsmic_Colar.Size = new System.Drawing.Size(118, 22);
            this.Tsmic_Colar.Text = "Colar";
            this.Tsmic_Colar.Click += new System.EventHandler(this.Tsmic_Colar_Click);
            // 
            // Tsmic_Desfazer
            // 
            this.Tsmic_Desfazer.Name = "Tsmic_Desfazer";
            this.Tsmic_Desfazer.Size = new System.Drawing.Size(118, 22);
            this.Tsmic_Desfazer.Text = "Desfazer";
            // 
            // Tsmic_Refazer
            // 
            this.Tsmic_Refazer.Name = "Tsmic_Refazer";
            this.Tsmic_Refazer.Size = new System.Drawing.Size(118, 22);
            this.Tsmic_Refazer.Text = "Refazer";
            // 
            // Tsmi_Formatar
            // 
            this.Tsmi_Formatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmic_Negrito,
            this.Tsmic_Italico,
            this.Tsmic_Sublinhado,
            this.Tsmic_Alinhamento});
            this.Tsmi_Formatar.Name = "Tsmi_Formatar";
            this.Tsmi_Formatar.Size = new System.Drawing.Size(67, 20);
            this.Tsmi_Formatar.Text = "Formatar";
            // 
            // Tsmic_Negrito
            // 
            this.Tsmic_Negrito.Name = "Tsmic_Negrito";
            this.Tsmic_Negrito.Size = new System.Drawing.Size(143, 22);
            this.Tsmic_Negrito.Text = "Negrito";
            this.Tsmic_Negrito.Click += new System.EventHandler(this.Tsmic_Negrito_Click);
            // 
            // Tsmic_Italico
            // 
            this.Tsmic_Italico.Name = "Tsmic_Italico";
            this.Tsmic_Italico.Size = new System.Drawing.Size(143, 22);
            this.Tsmic_Italico.Text = "Itálico";
            this.Tsmic_Italico.Click += new System.EventHandler(this.Tsmic_Italico_Click);
            // 
            // Tsmic_Sublinhado
            // 
            this.Tsmic_Sublinhado.Name = "Tsmic_Sublinhado";
            this.Tsmic_Sublinhado.Size = new System.Drawing.Size(143, 22);
            this.Tsmic_Sublinhado.Text = "Sublinhado";
            this.Tsmic_Sublinhado.Click += new System.EventHandler(this.Tsmic_Sublinhado_Click);
            // 
            // Tsmic_Alinhamento
            // 
            this.Tsmic_Alinhamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmicc_Centralizar,
            this.Tsmicc_AlinharEsquerda,
            this.Tsmicc_AlinharDireita,
            this.Tsmicc_Justificar});
            this.Tsmic_Alinhamento.Name = "Tsmic_Alinhamento";
            this.Tsmic_Alinhamento.Size = new System.Drawing.Size(143, 22);
            this.Tsmic_Alinhamento.Text = "Alinhamento";
            // 
            // Tsmicc_Centralizar
            // 
            this.Tsmicc_Centralizar.Name = "Tsmicc_Centralizar";
            this.Tsmicc_Centralizar.Size = new System.Drawing.Size(172, 22);
            this.Tsmicc_Centralizar.Text = "Centralizar";
            this.Tsmicc_Centralizar.Click += new System.EventHandler(this.Tsmicc_Centralizar_Click);
            // 
            // Tsmicc_AlinharEsquerda
            // 
            this.Tsmicc_AlinharEsquerda.Name = "Tsmicc_AlinharEsquerda";
            this.Tsmicc_AlinharEsquerda.Size = new System.Drawing.Size(172, 22);
            this.Tsmicc_AlinharEsquerda.Text = "Alinhar a Esquerda";
            this.Tsmicc_AlinharEsquerda.Click += new System.EventHandler(this.Tsmicc_AlinharEsquerda_Click);
            // 
            // Tsmicc_AlinharDireita
            // 
            this.Tsmicc_AlinharDireita.Name = "Tsmicc_AlinharDireita";
            this.Tsmicc_AlinharDireita.Size = new System.Drawing.Size(172, 22);
            this.Tsmicc_AlinharDireita.Text = "Alinhar a Direita";
            this.Tsmicc_AlinharDireita.Click += new System.EventHandler(this.Tsmicc_AlinharDireita_Click);
            // 
            // Tsmicc_Justificar
            // 
            this.Tsmicc_Justificar.Name = "Tsmicc_Justificar";
            this.Tsmicc_Justificar.Size = new System.Drawing.Size(172, 22);
            this.Tsmicc_Justificar.Text = "Justificar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Novo,
            this.Btn_Abrir,
            this.Btn_Salvar,
            this.toolStripSeparator1,
            this.Btn_Copiar,
            this.Btn_Colar,
            this.toolStripSeparator2,
            this.Btn_Negrito,
            this.Btn_Italico,
            this.Btn_Sublinhado,
            this.Btn_Fonte,
            this.toolStripSeparator3,
            this.Btn_AlinharEsquerda,
            this.Btn_Centralizar,
            this.Btn_AlinharDireita});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(571, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Novo.Image = global::Editor_de_Texto.Properties.Resources.Novo;
            this.Btn_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(23, 22);
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Abrir
            // 
            this.Btn_Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Abrir.Image = global::Editor_de_Texto.Properties.Resources.Abrir;
            this.Btn_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Abrir.Name = "Btn_Abrir";
            this.Btn_Abrir.Size = new System.Drawing.Size(23, 22);
            this.Btn_Abrir.Text = "Abrir";
            this.Btn_Abrir.Click += new System.EventHandler(this.Btn_Abrir_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Salvar.Image = global::Editor_de_Texto.Properties.Resources.Salvar;
            this.Btn_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(23, 22);
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn_Copiar
            // 
            this.Btn_Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Copiar.Image = global::Editor_de_Texto.Properties.Resources.Copiar;
            this.Btn_Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Copiar.Name = "Btn_Copiar";
            this.Btn_Copiar.Size = new System.Drawing.Size(23, 22);
            this.Btn_Copiar.Text = "Copiar";
            this.Btn_Copiar.Click += new System.EventHandler(this.Btn_Copiar_Click);
            // 
            // Btn_Colar
            // 
            this.Btn_Colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Colar.Image = global::Editor_de_Texto.Properties.Resources.Colar;
            this.Btn_Colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Colar.Name = "Btn_Colar";
            this.Btn_Colar.Size = new System.Drawing.Size(23, 22);
            this.Btn_Colar.Text = "Colar";
            this.Btn_Colar.Click += new System.EventHandler(this.Btn_Colar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn_Negrito
            // 
            this.Btn_Negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Negrito.Image = global::Editor_de_Texto.Properties.Resources.Negrito;
            this.Btn_Negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Negrito.Name = "Btn_Negrito";
            this.Btn_Negrito.Size = new System.Drawing.Size(23, 22);
            this.Btn_Negrito.Text = "Negrito";
            this.Btn_Negrito.Click += new System.EventHandler(this.Btn_Negrito_Click);
            // 
            // Btn_Italico
            // 
            this.Btn_Italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Italico.Image = global::Editor_de_Texto.Properties.Resources.Italico;
            this.Btn_Italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Italico.Name = "Btn_Italico";
            this.Btn_Italico.Size = new System.Drawing.Size(23, 22);
            this.Btn_Italico.Text = "Itálico";
            this.Btn_Italico.Click += new System.EventHandler(this.Btn_Italico_Click);
            // 
            // Btn_Sublinhado
            // 
            this.Btn_Sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Sublinhado.Image = global::Editor_de_Texto.Properties.Resources.Sublinhado;
            this.Btn_Sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Sublinhado.Name = "Btn_Sublinhado";
            this.Btn_Sublinhado.Size = new System.Drawing.Size(23, 22);
            this.Btn_Sublinhado.Text = "Sublinhado";
            this.Btn_Sublinhado.Click += new System.EventHandler(this.Btn_Sublinhado_Click);
            // 
            // Btn_Fonte
            // 
            this.Btn_Fonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Fonte.Image = global::Editor_de_Texto.Properties.Resources.Fonte;
            this.Btn_Fonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Fonte.Name = "Btn_Fonte";
            this.Btn_Fonte.Size = new System.Drawing.Size(23, 22);
            this.Btn_Fonte.Text = "Fonte";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn_AlinharEsquerda
            // 
            this.Btn_AlinharEsquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_AlinharEsquerda.Image = global::Editor_de_Texto.Properties.Resources.AlinharEsquerda;
            this.Btn_AlinharEsquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_AlinharEsquerda.Name = "Btn_AlinharEsquerda";
            this.Btn_AlinharEsquerda.Size = new System.Drawing.Size(23, 22);
            this.Btn_AlinharEsquerda.Text = "Alinhar a Esquerda";
            this.Btn_AlinharEsquerda.Click += new System.EventHandler(this.Btn_AlinharEsquerda_Click);
            // 
            // Btn_Centralizar
            // 
            this.Btn_Centralizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Centralizar.Image = global::Editor_de_Texto.Properties.Resources.Centralizar;
            this.Btn_Centralizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Centralizar.Name = "Btn_Centralizar";
            this.Btn_Centralizar.Size = new System.Drawing.Size(23, 22);
            this.Btn_Centralizar.Text = "Centralizar";
            this.Btn_Centralizar.Click += new System.EventHandler(this.Btn_Centralizar_Click);
            // 
            // Btn_AlinharDireita
            // 
            this.Btn_AlinharDireita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_AlinharDireita.Image = global::Editor_de_Texto.Properties.Resources.AlinharDireita;
            this.Btn_AlinharDireita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_AlinharDireita.Name = "Btn_AlinharDireita";
            this.Btn_AlinharDireita.Size = new System.Drawing.Size(23, 22);
            this.Btn_AlinharDireita.Text = "Alinhar a Direita";
            this.Btn_AlinharDireita.Click += new System.EventHandler(this.Btn_AlinharDireita_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "sara";
            this.saveFileDialog1.Filter = "(*.SARA)|*.SARA";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 449);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Ms_Arquivo);
            this.MainMenuStrip = this.Ms_Arquivo;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Texto - Saraiva Estudos";
            this.Ms_Arquivo.ResumeLayout(false);
            this.Ms_Arquivo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip Ms_Arquivo;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Arquivo;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Novo;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Abrir;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Salvar;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Imprimir;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Fechar;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Editar;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Copiar;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Colar;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Desfazer;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Refazer;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Formatar;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Negrito;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Italico;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Sublinhado;
        private System.Windows.Forms.ToolStripMenuItem Tsmic_Alinhamento;
        private System.Windows.Forms.ToolStripMenuItem Tsmicc_Centralizar;
        private System.Windows.Forms.ToolStripMenuItem Tsmicc_AlinharEsquerda;
        private System.Windows.Forms.ToolStripMenuItem Tsmicc_AlinharDireita;
        private System.Windows.Forms.ToolStripMenuItem Tsmicc_Justificar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Novo;
        private System.Windows.Forms.ToolStripButton Btn_Abrir;
        private System.Windows.Forms.ToolStripButton Btn_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Btn_Copiar;
        private System.Windows.Forms.ToolStripButton Btn_Colar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Btn_Negrito;
        private System.Windows.Forms.ToolStripButton Btn_Italico;
        private System.Windows.Forms.ToolStripButton Btn_Sublinhado;
        private System.Windows.Forms.ToolStripButton Btn_Fonte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Btn_AlinharEsquerda;
        private System.Windows.Forms.ToolStripButton Btn_Centralizar;
        private System.Windows.Forms.ToolStripButton Btn_AlinharDireita;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

