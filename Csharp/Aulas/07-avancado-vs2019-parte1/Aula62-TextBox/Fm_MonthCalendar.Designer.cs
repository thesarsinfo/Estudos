
namespace Aula62_TextBox
{
    partial class Fm_MonthCalendar
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
            this.Mc_Calendario = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_PegarData = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Mc_Calendario
            // 
            this.Mc_Calendario.Location = new System.Drawing.Point(18, 18);
            this.Mc_Calendario.MaxSelectionCount = 30;
            this.Mc_Calendario.Name = "Mc_Calendario";
            this.Mc_Calendario.TabIndex = 0;
            this.Mc_Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Mc_Calendario_DateChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(291, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            // 
            // Btn_PegarData
            // 
            this.Btn_PegarData.Location = new System.Drawing.Point(291, 123);
            this.Btn_PegarData.Name = "Btn_PegarData";
            this.Btn_PegarData.Size = new System.Drawing.Size(100, 23);
            this.Btn_PegarData.TabIndex = 3;
            this.Btn_PegarData.Text = "Pegar Data";
            this.Btn_PegarData.UseVisualStyleBackColor = true;
            this.Btn_PegarData.Click += new System.EventHandler(this.Btn_PegarData_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(291, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 4;
            // 
            // Fm_MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Btn_PegarData);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Mc_Calendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Fm_MonthCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Month Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Mc_Calendario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_PegarData;
        private System.Windows.Forms.TextBox textBox3;
    }
}