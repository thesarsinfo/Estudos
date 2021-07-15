
namespace Aula62_TextBox
{
    partial class Fm_Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fm_Timer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn_Iniciar_T1 = new System.Windows.Forms.Button();
            this.Btn_Parar_T1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Reiniciar_T1 = new System.Windows.Forms.Button();
            this.Img_Carro = new System.Windows.Forms.PictureBox();
            this.Btn_IniciarCarro = new System.Windows.Forms.Button();
            this.Tim_Carro = new System.Windows.Forms.Timer(this.components);
            this.Btn_PararCarro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Carro)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btn_Iniciar_T1
            // 
            this.Btn_Iniciar_T1.Location = new System.Drawing.Point(37, 28);
            this.Btn_Iniciar_T1.Name = "Btn_Iniciar_T1";
            this.Btn_Iniciar_T1.Size = new System.Drawing.Size(75, 23);
            this.Btn_Iniciar_T1.TabIndex = 0;
            this.Btn_Iniciar_T1.Text = "Iniciar";
            this.Btn_Iniciar_T1.UseVisualStyleBackColor = true;
            this.Btn_Iniciar_T1.Click += new System.EventHandler(this.Btn_Iniciar_T1_Click);
            // 
            // Btn_Parar_T1
            // 
            this.Btn_Parar_T1.Location = new System.Drawing.Point(148, 27);
            this.Btn_Parar_T1.Name = "Btn_Parar_T1";
            this.Btn_Parar_T1.Size = new System.Drawing.Size(75, 23);
            this.Btn_Parar_T1.TabIndex = 1;
            this.Btn_Parar_T1.Text = "Parar";
            this.Btn_Parar_T1.UseVisualStyleBackColor = true;
            this.Btn_Parar_T1.Click += new System.EventHandler(this.Btn_Parar_T1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Btn_Reiniciar_T1
            // 
            this.Btn_Reiniciar_T1.Location = new System.Drawing.Point(281, 26);
            this.Btn_Reiniciar_T1.Name = "Btn_Reiniciar_T1";
            this.Btn_Reiniciar_T1.Size = new System.Drawing.Size(75, 23);
            this.Btn_Reiniciar_T1.TabIndex = 3;
            this.Btn_Reiniciar_T1.Text = "reiniciar";
            this.Btn_Reiniciar_T1.UseVisualStyleBackColor = true;
            this.Btn_Reiniciar_T1.Click += new System.EventHandler(this.Btn_Reiniciar_T1_Click);
            // 
            // Img_Carro
            // 
            this.Img_Carro.Image = ((System.Drawing.Image)(resources.GetObject("Img_Carro.Image")));
            this.Img_Carro.Location = new System.Drawing.Point(12, 122);
            this.Img_Carro.Name = "Img_Carro";
            this.Img_Carro.Size = new System.Drawing.Size(200, 200);
            this.Img_Carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Carro.TabIndex = 4;
            this.Img_Carro.TabStop = false;
            this.Img_Carro.WaitOnLoad = true;
            this.Img_Carro.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Btn_IniciarCarro
            // 
            this.Btn_IniciarCarro.Location = new System.Drawing.Point(37, 95);
            this.Btn_IniciarCarro.Name = "Btn_IniciarCarro";
            this.Btn_IniciarCarro.Size = new System.Drawing.Size(75, 23);
            this.Btn_IniciarCarro.TabIndex = 5;
            this.Btn_IniciarCarro.Text = "Iniciar Carro";
            this.Btn_IniciarCarro.UseVisualStyleBackColor = true;
            this.Btn_IniciarCarro.Click += new System.EventHandler(this.Btn_IniciarCarro_Click);
            // 
            // Tim_Carro
            // 
            this.Tim_Carro.Tick += new System.EventHandler(this.Tim_Carro_Tick);
            // 
            // Btn_PararCarro
            // 
            this.Btn_PararCarro.Location = new System.Drawing.Point(148, 95);
            this.Btn_PararCarro.Name = "Btn_PararCarro";
            this.Btn_PararCarro.Size = new System.Drawing.Size(75, 23);
            this.Btn_PararCarro.TabIndex = 6;
            this.Btn_PararCarro.Text = "Parar Carro";
            this.Btn_PararCarro.UseVisualStyleBackColor = true;
            this.Btn_PararCarro.Click += new System.EventHandler(this.Btn_PararCarro_Click);
            // 
            // Fm_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 1517);
            this.Controls.Add(this.Btn_PararCarro);
            this.Controls.Add(this.Btn_IniciarCarro);
            this.Controls.Add(this.Img_Carro);
            this.Controls.Add(this.Btn_Reiniciar_T1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Parar_T1);
            this.Controls.Add(this.Btn_Iniciar_T1);
            this.Name = "Fm_Timer";
            this.Text = "Fm_Timer";
            this.Load += new System.EventHandler(this.Fm_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_Iniciar_T1;
        private System.Windows.Forms.Button Btn_Parar_T1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Reiniciar_T1;
        private System.Windows.Forms.PictureBox Img_Carro;
        private System.Windows.Forms.Button Btn_IniciarCarro;
        private System.Windows.Forms.Timer Tim_Carro;
        private System.Windows.Forms.Button Btn_PararCarro;
    }
}