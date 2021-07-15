
namespace Aula62_TextBox
{
    partial class Fm_NumericUpDown
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Tb_Valor = new System.Windows.Forms.TextBox();
            this.Btn_DefinirValor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Tb_Valor
            // 
            this.Tb_Valor.Location = new System.Drawing.Point(195, 12);
            this.Tb_Valor.Name = "Tb_Valor";
            this.Tb_Valor.Size = new System.Drawing.Size(100, 23);
            this.Tb_Valor.TabIndex = 1;
            this.Tb_Valor.Text = "0";
            this.Tb_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_DefinirValor
            // 
            this.Btn_DefinirValor.Location = new System.Drawing.Point(366, 12);
            this.Btn_DefinirValor.Name = "Btn_DefinirValor";
            this.Btn_DefinirValor.Size = new System.Drawing.Size(75, 23);
            this.Btn_DefinirValor.TabIndex = 2;
            this.Btn_DefinirValor.Text = "Definir Valor";
            this.Btn_DefinirValor.UseVisualStyleBackColor = true;
            this.Btn_DefinirValor.Click += new System.EventHandler(this.Btn_DefinirValor_Click);
            // 
            // Fm_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 273);
            this.Controls.Add(this.Btn_DefinirValor);
            this.Controls.Add(this.Tb_Valor);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Fm_NumericUpDown";
            this.Text = "Fm_NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox Tb_Valor;
        private System.Windows.Forms.Button Btn_DefinirValor;
    }
}