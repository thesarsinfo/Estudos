using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Aula60
{
    partial class FormPrincipal
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
            this.btnEstudos = new System.Windows.Forms.Button();
            this.lbEstudos = new System.Windows.Forms.Label();
            this.tbEstudos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEstudos1
            // 
            this.btnEstudos.Location = new System.Drawing.Point(550, 550);
            this.btnEstudos.Size = new System.Drawing.Size(200, 30);
            this.btnEstudos.Name = "btnEstudos";
            this.btnEstudos.Text = "OK";
            this.btnEstudos.TabIndex = 1;
            this.btnEstudos.UseVisualStyleBackColor = true; 
            this.btnEstudos.Font = new  System.Drawing.Font
            (
               "Microsoft Sans Serif", 20F,System.Drawing.FontStyle.Bold,
               System.Drawing.GraphicsUnit.World, ((byte)(0))
            );
            this.btnEstudos.ForeColor = System.Drawing.Color.Red;
            this.btnEstudos.BackColor = System.Drawing.Color.Black;
            //Evento
            this.btnEstudos.Click += new System.EventHandler(this.btnEstudos_Click);
            //
            // lbEstudos
            //      
           
            this.lbEstudos.Location = new System.Drawing.Point(420, 500);
            this.lbEstudos.Size = new System.Drawing.Size(142, 18);
            this.lbEstudos.AutoSize = true;
            this.lbEstudos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstudos.Name = "lbEstudos";
            this.lbEstudos.Text = "Saraiva para estudos:";
            this.lbEstudos.TabIndex = 2;     
            // 
            // TextBox tbEstudos
            // 
            this.tbEstudos.Location = new System.Drawing.Point(590, 500);
            this.tbEstudos.Name = "tbEstudos";
            this.tbEstudos.Size = new System.Drawing.Size(100, 25);
            this.tbEstudos.TabIndex = 3; 
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnEstudos);
            this.Controls.Add(this.lbEstudos);
            this.Controls.Add(this.tbEstudos);
            this.Name = "FormPrincipal";
            this.Text = "Saraiva Estudos em curso de CSharp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstudos;
        private System.Windows.Forms.Label lbEstudos;
        private System.Windows.Forms.TextBox tbEstudos;
    }
}

