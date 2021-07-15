using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saraiva_Academia
{
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.T_Nome_Usuario = Tb_Nome.Text;
            usuario.T_Username = Tb_Username.Text;
            usuario.T_Senha = Tb_Senha.Text;
            usuario.T_Situacao_Usuario = Cb_Status.Text;
            usuario.N_Nivel_Usuario = Convert.ToInt32(Math.Round(Nud_Nivel.Value,0));
            Banco.NovoUsuario(usuario);

        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Tb_Nome.Clear();
            Tb_Username.Clear();
            Tb_Senha.Clear();
            Cb_Status.Text = "";
            Nud_Nivel.Value = 0;
            Tb_Nome.Focus();
        }

        private void Btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            Tb_Nome.Clear();
            Tb_Username.Clear();
            Tb_Senha.Clear();
            Cb_Status.Text = "";
            Nud_Nivel.Value = 0;
            Tb_Nome.Focus();
        }
    }
}
