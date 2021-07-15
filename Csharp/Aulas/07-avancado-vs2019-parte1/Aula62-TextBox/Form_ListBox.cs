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
    public partial class Form_ListBox : Form
    {
        List<String> carros = new List<string>();
        public Form_ListBox()
        {
            InitializeComponent();
            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");
            carros.Add("Kombi");
            AtualizaCarros(Lb_Carros, carros);
        }

        private void Form_ListBox_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            if( Tb_Carro.Text == "")
            {
                MessageBox.Show("Digite um Carro");
                Tb_Carro.Focus();                
            }
            else
            {
                carros.Add(Tb_Carro.Text);
                Tb_Carro.Clear();
                Tb_Carro.Focus();
                AtualizaCarros(Lb_Carros, carros);


            }
        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            if (carros.Count == 0)
            {
                MessageBox.Show("Não Existe Elementos para remover");
            }
            else
            {
                if (Lb_Carros.SelectedIndex != -1)
                {
                    carros.RemoveAt(Lb_Carros.SelectedIndex);
                    AtualizaCarros(Lb_Carros, carros);
                }
                else
                {
                    MessageBox.Show("Selecione um carro para remover");
                }
            }
        }

        private void Btn_Obter_Click(object sender, EventArgs e)
        {

            Tb_Carro.Text = carros[Lb_Carros.SelectedIndex];
        }

        private void Btn_LimparTudo_Click(object sender, EventArgs e)
        {
            carros.Clear();
            AtualizaCarros(Lb_Carros,carros);           

        }
        private void AtualizaCarros(ListBox listBoxCarros , List<string> listaCarros)
        {
            listBoxCarros.DataSource = null;
            listBoxCarros.DataSource = listaCarros;
        }
    }
}
