using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Aula 66
 O conjunto checkbox é muito assimilado e muito usado ao evento de checkedchanged 
Usamos lista para diminuir o codigo e fica mais simples.
 
 */
namespace Aula62_TextBox
{
    public partial class Form_CheckBox : Form
    {
        List<CheckBox> transportes= new List<CheckBox>();
        public Form_CheckBox()
        {
            InitializeComponent();
            transportes.Add(CB_Carro);
            transportes.Add(CB_Aviao);
            transportes.Add(CB_Navio);
            transportes.Add(CB_Onibus);
            transportes.Add(CB_Patinete);

        }

        private void Btn_Transportes_Marcados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach(CheckBox transp in transportes)
            {
                if (transp.Checked)
                {
                    txt += transp.Text + ", ";
                }
            }
            MessageBox.Show(txt);
        }

        private void CB_Patinete_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_Patinete.Checked)
            {
                MessageBox.Show("Patinete Marcada");
            }
        }

        private void Form_CheckBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_FilhoCheckBox form_FilhoCheckBox = new Form_FilhoCheckBox();
            form_FilhoCheckBox.ShowDialog();
        }
    }
}
