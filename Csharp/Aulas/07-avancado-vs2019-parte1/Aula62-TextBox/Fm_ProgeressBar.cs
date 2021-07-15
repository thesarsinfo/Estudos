using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Aula62_TextBox
{
    public partial class Fm_ProgressBar : Form
    {
        /*
         * Aula 81 ProgressBar e sleepling Treding
         * importamos a biblioteca  System.Threading
         * e usamos uma propriedades de maximo e minimo
         */
        public Fm_ProgressBar()
        {
            InitializeComponent();
        }

        private void Btn_DefinirValor_Click(object sender, EventArgs e)
        {
            if (int.Parse(Tb_DefinirValor.Text) >= progressBar1.Minimum && 
                int.Parse(Tb_DefinirValor.Text) <= progressBar1.Maximum)
            {
                progressBar1.Value = int.Parse(Tb_DefinirValor.Text);
            }
            else
            {
                MessageBox.Show("Valor acima do maximo ou minimo permitido");
            }
        }

        private void Btn_Preencher_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 0; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(200);
            }
        }
    }
}
