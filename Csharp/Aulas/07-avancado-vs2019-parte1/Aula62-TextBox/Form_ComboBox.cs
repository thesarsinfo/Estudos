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
    public partial class Form_ComboBox : Form
    {
        public Form_ComboBox()
        {
            InitializeComponent();
        }

        private void Btn_MostrarSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Cbx_Transporte.Text);
        }

        private void Btn_LimparElementos_Click(object sender, EventArgs e)
        {
            Cbx_Transporte.Items.Clear();
        }

        private void Btn_Resetar_Click(object sender, EventArgs e)
        {
            Cbx_Transporte.Items.Clear();
            Cbx_Transporte.Items.Add("Carro");
            Cbx_Transporte.Items.Add("Avião");
            Cbx_Transporte.Items.Add("Navio");
            Cbx_Transporte.Items.Add("Ônibus");
            Cbx_Transporte.Items.Add("Trem");

        }

        private void Cbx_Transporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tb_Transportes.Text = Cbx_Transporte.Text;
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            
            if(Tb_Transportes.Text != "")
            {
                if (Cbx_Transporte.FindString(Tb_Transportes.Text) < 0)
                {
                    Cbx_Transporte.Items.Add(Tb_Transportes.Text);
                    Tb_Transportes.Clear();
                    Tb_Transportes.Focus();
                }
                else
                {
                    MessageBox.Show("Esse modal de transporte já existe");
                }
            }
        }
    }
}
