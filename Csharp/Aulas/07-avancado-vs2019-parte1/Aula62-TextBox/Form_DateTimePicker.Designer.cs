
namespace Aula62_TextBox
{
    partial class Form_DateTimePicker
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
            this.DTP_Data = new System.Windows.Forms.DateTimePicker();
            this.Btn_ObterData = new System.Windows.Forms.Button();
            this.Tb_DataCompleta = new System.Windows.Forms.TextBox();
            this.Tb_Dia = new System.Windows.Forms.TextBox();
            this.Tb_Mes = new System.Windows.Forms.TextBox();
            this.Tb_Ano = new System.Windows.Forms.TextBox();
            this.Btn_SetarData = new System.Windows.Forms.Button();
            this.Btn_Hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DTP_Data
            // 
            this.DTP_Data.Location = new System.Drawing.Point(12, 40);
            this.DTP_Data.Name = "DTP_Data";
            this.DTP_Data.Size = new System.Drawing.Size(312, 23);
            this.DTP_Data.TabIndex = 0;
            // 
            // Btn_ObterData
            // 
            this.Btn_ObterData.Location = new System.Drawing.Point(336, 39);
            this.Btn_ObterData.Name = "Btn_ObterData";
            this.Btn_ObterData.Size = new System.Drawing.Size(157, 23);
            this.Btn_ObterData.TabIndex = 1;
            this.Btn_ObterData.Text = "Obter Data";
            this.Btn_ObterData.UseVisualStyleBackColor = true;
            this.Btn_ObterData.Click += new System.EventHandler(this.Btn_ObterData_Click);
            // 
            // Tb_DataCompleta
            // 
            this.Tb_DataCompleta.Location = new System.Drawing.Point(13, 93);
            this.Tb_DataCompleta.Name = "Tb_DataCompleta";
            this.Tb_DataCompleta.Size = new System.Drawing.Size(311, 23);
            this.Tb_DataCompleta.TabIndex = 2;
            // 
            // Tb_Dia
            // 
            this.Tb_Dia.Location = new System.Drawing.Point(12, 138);
            this.Tb_Dia.Name = "Tb_Dia";
            this.Tb_Dia.Size = new System.Drawing.Size(100, 23);
            this.Tb_Dia.TabIndex = 3;
            // 
            // Tb_Mes
            // 
            this.Tb_Mes.Location = new System.Drawing.Point(118, 138);
            this.Tb_Mes.Name = "Tb_Mes";
            this.Tb_Mes.Size = new System.Drawing.Size(100, 23);
            this.Tb_Mes.TabIndex = 4;
            // 
            // Tb_Ano
            // 
            this.Tb_Ano.Location = new System.Drawing.Point(224, 138);
            this.Tb_Ano.Name = "Tb_Ano";
            this.Tb_Ano.Size = new System.Drawing.Size(100, 23);
            this.Tb_Ano.TabIndex = 5;
            // 
            // Btn_SetarData
            // 
            this.Btn_SetarData.Location = new System.Drawing.Point(340, 136);
            this.Btn_SetarData.Name = "Btn_SetarData";
            this.Btn_SetarData.Size = new System.Drawing.Size(165, 24);
            this.Btn_SetarData.TabIndex = 9;
            this.Btn_SetarData.Text = "Setar Data";
            this.Btn_SetarData.UseVisualStyleBackColor = true;
            this.Btn_SetarData.Click += new System.EventHandler(this.Btn_SetarData_Click);
            // 
            // Btn_Hoje
            // 
            this.Btn_Hoje.Location = new System.Drawing.Point(336, 180);
            this.Btn_Hoje.Name = "Btn_Hoje";
            this.Btn_Hoje.Size = new System.Drawing.Size(169, 23);
            this.Btn_Hoje.TabIndex = 10;
            this.Btn_Hoje.Text = "Hoje";
            this.Btn_Hoje.UseVisualStyleBackColor = true;
            this.Btn_Hoje.Click += new System.EventHandler(this.Btn_Hoje_Click);
            // 
            // Form_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.Btn_Hoje);
            this.Controls.Add(this.Btn_SetarData);
            this.Controls.Add(this.Tb_Ano);
            this.Controls.Add(this.Tb_Mes);
            this.Controls.Add(this.Tb_Dia);
            this.Controls.Add(this.Tb_DataCompleta);
            this.Controls.Add(this.Btn_ObterData);
            this.Controls.Add(this.DTP_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_DateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Time Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_Data;
        private System.Windows.Forms.Button Btn_ObterData;
        private System.Windows.Forms.TextBox Tb_DataCompleta;
        private System.Windows.Forms.TextBox Tb_Dia;
        private System.Windows.Forms.TextBox Tb_Mes;
        private System.Windows.Forms.TextBox Tb_Ano;
        private System.Windows.Forms.Button Btn_SetarData;
        private System.Windows.Forms.Button Btn_Hoje;
    }
}