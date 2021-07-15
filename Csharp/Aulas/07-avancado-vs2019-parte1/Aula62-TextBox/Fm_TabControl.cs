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
    public partial class Fm_TabControl : Form
    {
        public Fm_TabControl()
        {
            InitializeComponent();
        }

        private void Btn_NovaTab_Click(object sender, EventArgs e)
        {
            if(Tb_NomeNovaTab.Text != "")
            {
                /*
                 Para cria uma tab prescisamos 
                criar um componentes tab
                definir as propriedades do componentes
                adicionar elementos no tab control
                 
                 */
                TabPage pagina = new TabPage(); // criando elemento
                //definindo as propriedades principais
                pagina.Text = Tb_NomeNovaTab.Text;
                pagina.Name = Tb_NomeNovaTab.Text;
                pagina.TabIndex = tabControl1.TabPages.Count;

                tabControl1.TabPages.Add(pagina);
                Tb_NomeNovaTab.Clear();
                DefinirMaximo();
            }
            else
            {
                MessageBox.Show("Nome da Tab está vazia. Digite o nome da nova Tab");
                Tb_NomeNovaTab.Focus();
            }
        }

        private void Btn_RemoverTabAtual_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 0)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            else
            {
                MessageBox.Show("Não a tabs para remover!");
            }
            DefinirMaximo();
        }

        private void Btn_PosicionarTab_Click(object sender, EventArgs e)
        {
            //função inutil mas serve como outra forma de fazer sem usar a function DefinirMaximo;
            if (numericUpDown1.Value < tabControl1.TabPages.Count)
            {
                //Converto decimal do numericupdown para string e depois string para inteiro;
                tabControl1.SelectedIndex = Int32.Parse(numericUpDown1.Value.ToString());
            }
            else
            {
                MessageBox.Show("Tab Inexistente");
            }
        }
        private void DefinirMaximo()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count - 1;
        }

        private void Fm_TabControl_Load(object sender, EventArgs e)
        {
            DefinirMaximo();
        }
    }
}
