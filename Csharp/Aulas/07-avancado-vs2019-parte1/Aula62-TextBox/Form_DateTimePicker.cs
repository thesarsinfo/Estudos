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
    public partial class Form_DateTimePicker : Form
    {
        public Form_DateTimePicker()
        {
            InitializeComponent();
        }

        private void Btn_ObterData_Click(object sender, EventArgs e)
        {
            Tb_DataCompleta.Text = DTP_Data.Text;
            Tb_Dia.Text = DTP_Data.Value.Day.ToString();
            Tb_Mes.Text = DTP_Data.Value.Month.ToString();
            Tb_Ano.Text = DTP_Data.Value.Year.ToString();

        }

        private void Btn_SetarData_Click(object sender, EventArgs e)
        {
            int dia, mes, ano;
            

            dia = Int32.Parse(Tb_Dia.Text);
            mes = Int32.Parse(Tb_Mes.Text);
            ano = Int32.Parse(Tb_Ano.Text);
            DateTime data = new DateTime(ano,mes,dia);
            DTP_Data.Value = data;

        }

        private void Btn_Hoje_Click(object sender, EventArgs e)
        {
            DTP_Data.Value = DateTime.Today;
        }
    }
}
