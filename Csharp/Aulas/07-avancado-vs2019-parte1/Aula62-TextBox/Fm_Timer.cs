using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula62_TextBox
{
    public partial class Fm_Timer : Form
    {
        int num, posX, posY;
        
        public Fm_Timer()
        {
            InitializeComponent();
        }

        private void Fm_Timer_Load(object sender, EventArgs e)
        {
            num = 0;
            posX = Img_Carro.Location.X;
            posY = Img_Carro.Location.Y;

        }

        private void Btn_Iniciar_T1_Click(object sender, EventArgs e)
        {
           // timer1.Interval = 1500;
            timer1.Start();
        }

        private void Btn_Parar_T1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void Btn_Reiniciar_T1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
            timer1.Start();
        }

        private void Btn_IniciarCarro_Click(object sender, EventArgs e)
        {
            Tim_Carro.Start();
        }

        private void Btn_PararCarro_Click(object sender, EventArgs e)
        {
            Tim_Carro.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Tim_Carro_Tick(object sender, EventArgs e)
        {

            posX++;
            Img_Carro.Location = new Point(posX, posY);
            posX = Img_Carro.Location.X;
        }
    }
}
