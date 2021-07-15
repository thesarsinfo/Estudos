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
    public partial class Fm_TrackBar : Form
    {
        public Fm_TrackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            /*
             Aula 90 - Componente TrackBar
            O evento mais padrao é o Scroll e das propriedades é o máximo e mínimo.
             
             */
            Tb_Valor.Text = trackBar1.Value.ToString();
            La_Valor.Text = trackBar1.Value.ToString();

        }

        private void Btn_Definir_Click(object sender, EventArgs e)
        {
            if (int.Parse(Tb_Valor.Text) >= trackBar1.Minimum && int.Parse(Tb_Valor.Text) <= trackBar1.Maximum)
            {
                trackBar1.Value = int.Parse(Tb_Valor.Text);
            }
            else
            {
                MessageBox.Show("Valores fora do range permitido");
            }
        }

        private void Fm_TrackBar_Load(object sender, EventArgs e)
        {
            Tb_Valor.Text = trackBar1.Value.ToString();
            La_Valor.Text = trackBar1.Value.ToString();
        }
    }
}
