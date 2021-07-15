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
    public partial class Fm_RadioButton : Form
    {
        /*
         * Aula 82 Radio Button e Group Box
         * Somente podemos escolher uma opçõa dentro do formulario exceto se estiver dentro do group box
         * 
         */
        public Fm_RadioButton()
        {
            InitializeComponent();
        }

        private void Btn_Selecionado_Click(object sender, EventArgs e)
        {
            string txt;
            txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            textBox1.Text = txt;
            MessageBox.Show(txt);
        }

        private void Btn_SelecionadoModo2_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (RadioButton rb in groupBox1.Controls)
            {
                if(rb.Checked)
                {
                    txt = rb.Text;
                }
            }
            textBox1.Text = txt;
            MessageBox.Show(txt);
        }
    }
}
