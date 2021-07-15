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
    public partial class Fm_NumericUpDown : Form
    {
        /*
         * Aula 79 NumericUpDown serve para escolher numero usando uma seta
         * prop value = seta o padrao inicial
         * prop incremento define a quantidade de aumento devido ao clique de 1 a 1 ou 2 a 2 ou mais
         */
        public Fm_NumericUpDown()
        {
            InitializeComponent();
        }

        private void Btn_DefinirValor_Click(object sender, EventArgs e)
        {          
            
            if(Decimal.Parse(Tb_Valor.Text) >= numericUpDown1.Minimum &&
               Decimal.Parse(Tb_Valor.Text) <= numericUpDown1.Maximum)
            {
                numericUpDown1.Value = Decimal.Parse(Tb_Valor.Text);
            }
            else
            {
                MessageBox.Show("Valor acima do maximo ou minimo permeitido!");
            }
        }
    }
}
