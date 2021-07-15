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
    /*
     * Aula 77 - MonthCalendar trabalha muito com range no estilo passagem de ida e volta ou seja um range
     * quando selecionamos ussando o arrasto o padrão é 7 dias mas pode muda-lo
     * */
    public partial class Fm_MonthCalendar : Form
    {
        public Fm_MonthCalendar()
        {
            InitializeComponent();
        }

        private void Btn_PegarData_Click(object sender, EventArgs e)
        {
            textBox1.Text = Mc_Calendario.SelectionStart.ToShortDateString();
            // o codigo acima pegar a data de start e converte para data com 4 digitos e string
            //Metoto tostring usa data e hora
            textBox2.Text = Mc_Calendario.SelectionEnd.ToShortDateString();
            textBox3.Text = Mc_Calendario.TodayDate.ToShortDateString();
        }

        private void Mc_Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = Mc_Calendario.SelectionStart.ToShortDateString();           
            textBox2.Text = Mc_Calendario.SelectionEnd.ToShortDateString();
            textBox3.Text = Mc_Calendario.TodayDate.ToShortDateString();
        }
    }
}
