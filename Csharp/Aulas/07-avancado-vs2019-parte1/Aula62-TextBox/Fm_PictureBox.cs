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
    public partial class Fm_PictureBox : Form
    {
        public Fm_PictureBox()
        {
            InitializeComponent();
        }

        private void Fm_PictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.Canal;
            label2.Text = Properties.Resources.Label2;
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Teste;

        }
    }
}
