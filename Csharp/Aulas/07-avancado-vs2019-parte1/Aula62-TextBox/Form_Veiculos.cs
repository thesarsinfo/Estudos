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
    public partial class Form_Veiculos : Form
    {
        public Form_Principal fp;
        public Form_Veiculos(String v, Form_Principal form_Principal)//parametro para passar dados
        {
            InitializeComponent();
            Tb_ListaVeiculos.Text = v;
            fp = form_Principal;
            form_Principal.num = 10;

        }

        private void Form_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.Tb_Veiculos.Text = Tb_ListaVeiculos.Text;
        }
    }
}
