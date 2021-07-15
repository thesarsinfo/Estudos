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
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);// como o f_frincipal é um Form só basta passar o comando this
            //this é o proprio f-Principal
            f_Login.ShowDialog();
        }
        private void AbreFormulario(int nivel, Form form)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Você não possui o privilegio contate o administrador do programa");
                }
            }
            else
            {
                MessageBox.Show("É necessário estar logado no programa");
            }
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            La_Acesso.Text = "0";
            La_NomeUsuario.Text = "- - -";
            Pb_LedLogado.Image = Properties.Resources.farolvermelhocircle;
            Globais.nivel = 0;
            Globais.logado = false;
            
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AbreFormulario(3,);
            
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            AbreFormulario(2, f_NovoUsuario);            
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
            AbreFormulario(2, f_GestaoUsuarios);            
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoAluno f_NovoAluno = new F_NovoAluno();
            AbreFormulario(1, f_NovoAluno);
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Horários f_Horarios = new Horários();
            AbreFormulario(2, f_Horarios);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Professores f_Professores = new F_Professores();
            AbreFormulario(2,f_Professores);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();
            AbreFormulario(2, f_GestaoTurmas);
        }

        private void gestãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoAlunos f_GestaoAlunos = new F_GestaoAlunos();
            AbreFormulario(2, f_GestaoAlunos);
        }
    }
}
