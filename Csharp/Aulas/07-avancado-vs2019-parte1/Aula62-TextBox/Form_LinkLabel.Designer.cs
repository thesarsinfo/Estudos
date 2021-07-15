
namespace Aula62_TextBox
{
    partial class Form_LinkLabel
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
            this.Tb_Nome = new System.Windows.Forms.TextBox();
            this.LL_Canal = new System.Windows.Forms.LinkLabel();
            this.LL_Calculadora = new System.Windows.Forms.LinkLabel();
            this.LL_MultiplosLinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome";
            // 
            // Tb_Nome
            // 
            this.Tb_Nome.Location = new System.Drawing.Point(13, 32);
            this.Tb_Nome.Name = "Tb_Nome";
            this.Tb_Nome.Size = new System.Drawing.Size(178, 23);
            this.Tb_Nome.TabIndex = 1;
            // 
            // LL_Canal
            // 
            this.LL_Canal.AutoSize = true;
            this.LL_Canal.Location = new System.Drawing.Point(13, 62);
            this.LL_Canal.Name = "LL_Canal";
            this.LL_Canal.Size = new System.Drawing.Size(37, 15);
            this.LL_Canal.TabIndex = 2;
            this.LL_Canal.TabStop = true;
            this.LL_Canal.Text = "Canal";
            this.LL_Canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Canal_LinkClicked);
            // 
            // LL_Calculadora
            // 
            this.LL_Calculadora.AutoSize = true;
            this.LL_Calculadora.Location = new System.Drawing.Point(79, 62);
            this.LL_Calculadora.Name = "LL_Calculadora";
            this.LL_Calculadora.Size = new System.Drawing.Size(70, 15);
            this.LL_Calculadora.TabIndex = 3;
            this.LL_Calculadora.TabStop = true;
            this.LL_Calculadora.Text = "Calculadora";
            this.LL_Calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Calculadora_LinkClicked);
            // 
            // LL_MultiplosLinks
            // 
            this.LL_MultiplosLinks.AutoSize = true;
            this.LL_MultiplosLinks.Location = new System.Drawing.Point(13, 138);
            this.LL_MultiplosLinks.Name = "LL_MultiplosLinks";
            this.LL_MultiplosLinks.Size = new System.Drawing.Size(141, 15);
            this.LL_MultiplosLinks.TabIndex = 4;
            this.LL_MultiplosLinks.TabStop = true;
            this.LL_MultiplosLinks.Text = "Google - Canal - Youtube";
            this.LL_MultiplosLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_MultiplosLinks_LinkClicked);
            // 
            // Form_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 376);
            this.Controls.Add(this.LL_MultiplosLinks);
            this.Controls.Add(this.LL_Calculadora);
            this.Controls.Add(this.LL_Canal);
            this.Controls.Add(this.Tb_Nome);
            this.Controls.Add(this.label1);
            this.Name = "Form_LinkLabel";
            this.Text = "Link Label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Nome;
        private System.Windows.Forms.LinkLabel LL_Canal;
        private System.Windows.Forms.LinkLabel LL_Calculadora;
        private System.Windows.Forms.LinkLabel LL_MultiplosLinks;
    }
}