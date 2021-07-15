
namespace Aula62_TextBox
{
    partial class Fm_TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Componentes = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Tb_NomeNovaTab = new System.Windows.Forms.TextBox();
            this.Btn_NovaTab = new System.Windows.Forms.Button();
            this.Btn_RemoverTabAtual = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Btn_PosicionarTab = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Tab_Componentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_Componentes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 321);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_Componentes
            // 
            this.Tab_Componentes.Controls.Add(this.button1);
            this.Tab_Componentes.Controls.Add(this.label1);
            this.Tab_Componentes.Controls.Add(this.textBox1);
            this.Tab_Componentes.Location = new System.Drawing.Point(4, 24);
            this.Tab_Componentes.Name = "Tab_Componentes";
            this.Tab_Componentes.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Componentes.Size = new System.Drawing.Size(659, 293);
            this.Tab_Componentes.TabIndex = 0;
            this.Tab_Componentes.Text = "Componentes";
            this.Tab_Componentes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Tb_NomeNovaTab
            // 
            this.Tb_NomeNovaTab.Location = new System.Drawing.Point(12, 13);
            this.Tb_NomeNovaTab.Name = "Tb_NomeNovaTab";
            this.Tb_NomeNovaTab.Size = new System.Drawing.Size(100, 23);
            this.Tb_NomeNovaTab.TabIndex = 1;
            // 
            // Btn_NovaTab
            // 
            this.Btn_NovaTab.Location = new System.Drawing.Point(119, 12);
            this.Btn_NovaTab.Name = "Btn_NovaTab";
            this.Btn_NovaTab.Size = new System.Drawing.Size(138, 23);
            this.Btn_NovaTab.TabIndex = 2;
            this.Btn_NovaTab.Text = "Nova Tab";
            this.Btn_NovaTab.UseVisualStyleBackColor = true;
            this.Btn_NovaTab.Click += new System.EventHandler(this.Btn_NovaTab_Click);
            // 
            // Btn_RemoverTabAtual
            // 
            this.Btn_RemoverTabAtual.Location = new System.Drawing.Point(264, 11);
            this.Btn_RemoverTabAtual.Name = "Btn_RemoverTabAtual";
            this.Btn_RemoverTabAtual.Size = new System.Drawing.Size(156, 23);
            this.Btn_RemoverTabAtual.TabIndex = 3;
            this.Btn_RemoverTabAtual.Text = "Remover Tab Atual";
            this.Btn_RemoverTabAtual.UseVisualStyleBackColor = true;
            this.Btn_RemoverTabAtual.Click += new System.EventHandler(this.Btn_RemoverTabAtual_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 4;
            // 
            // Btn_PosicionarTab
            // 
            this.Btn_PosicionarTab.Location = new System.Drawing.Point(139, 43);
            this.Btn_PosicionarTab.Name = "Btn_PosicionarTab";
            this.Btn_PosicionarTab.Size = new System.Drawing.Size(118, 23);
            this.Btn_PosicionarTab.TabIndex = 5;
            this.Btn_PosicionarTab.Text = "Posicionar na Tab";
            this.Btn_PosicionarTab.UseVisualStyleBackColor = true;
            this.Btn_PosicionarTab.Click += new System.EventHandler(this.Btn_PosicionarTab_Click);
            // 
            // Fm_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 405);
            this.Controls.Add(this.Btn_PosicionarTab);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Btn_RemoverTabAtual);
            this.Controls.Add(this.Btn_NovaTab);
            this.Controls.Add(this.Tb_NomeNovaTab);
            this.Controls.Add(this.tabControl1);
            this.Name = "Fm_TabControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tab Control";
            this.Load += new System.EventHandler(this.Fm_TabControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tab_Componentes.ResumeLayout(false);
            this.Tab_Componentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_Componentes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Tb_NomeNovaTab;
        private System.Windows.Forms.Button Btn_NovaTab;
        private System.Windows.Forms.Button Btn_RemoverTabAtual;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Btn_PosicionarTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}