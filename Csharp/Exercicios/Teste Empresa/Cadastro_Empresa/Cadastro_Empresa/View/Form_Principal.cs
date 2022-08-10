using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Cadastro_Empresa
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        public void Btn_Cadastro_Empresa_Click(object sender, EventArgs e)
        {
            Form_Cadastro_Empresa cadastro_Empresa = new Form_Cadastro_Empresa();
            cadastro_Empresa.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        
    }
}
