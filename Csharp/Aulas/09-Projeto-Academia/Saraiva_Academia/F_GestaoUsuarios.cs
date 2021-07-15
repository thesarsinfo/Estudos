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
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void Btn_FecharJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            Dgv_Usuarios.DataSource = Banco.ObterUsuariosIdNome();
            Dgv_Usuarios.Columns[0].Width = 85;
            Dgv_Usuarios.Columns[1].Width = 190;

        }

        private void Dgv_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            //Aula 108 O sender é um objeto generico que representa a estrutura completa do datagridview
            // e sua associação depende do evento relacionado
            DataGridView dataGridView = (DataGridView)sender;
            int contlinhas = Dgv_Usuarios.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string verificaId = Dgv_Usuarios.SelectedRows[0].Cells[0].Value.ToString();
                dataTable = Banco.ObterDadosUsuarios(verificaId);
                Tb_Id.Text = dataTable.Rows[0].Field<Int64>("N_Id_Usuario").ToString();
                Tb_Nome.Text = dataTable.Rows[0].Field<string>("T_Nome_Usuario").ToString();
                Tb_Username.Text = dataTable.Rows[0].Field<string>("T_Username").ToString();
                Tb_Senha.Text = dataTable.Rows[0].Field<string>("T_Senha").ToString();
                Cb_Status.Text = dataTable.Rows[0].Field<string>("T_Situacao_Usuario").ToString();
                Nud_Nivel.Value = dataTable.Rows[0].Field<Int64>("N_Nivel_Usuario");

            }

        }

        private void Btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            Dgv_Usuarios.DataSource = Banco.ObterUsuariosIdNome();            
        }

        private void Btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            int linha = Dgv_Usuarios.SelectedRows[0].Index;
            Usuario usuario = new Usuario();
            usuario.N_Id_Usuario = Convert.ToInt32(Tb_Id.Text);
            usuario.T_Nome_Usuario = Tb_Nome.Text;
            usuario.T_Senha = Tb_Senha.Text;
            usuario.T_Situacao_Usuario = Cb_Status.Text;
            usuario.N_Nivel_Usuario =int.Parse( Nud_Nivel.Value.ToString());

            Banco.AtualizarUsuario(usuario);
            /* Modos abaixo são para apenas carregar e colacar o curso na linha certa
             * porem é um metodo que demora muito para carregar se estiver com milhoes de usuarios
             * vamos usar algo mais rapido
            Dgv_Usuarios.DataSource = Banco.ObterUsuariosIdNome();//mostrar a atualização
            Dgv_Usuarios.CurrentCell = Dgv_Usuarios[0, linha];

           */
            // Dgv_Usuarios[0, linha].Value = Tb_Id.Text; Id nunca é alterado
            Dgv_Usuarios[1, linha].Value = Tb_Nome.Text;
        }

        private void Btn_ExcluirUsuario_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma a exclusão do usuario?","Excluir?" ,MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                Banco.ExcluirUsuario(Tb_Id.Text);
                Dgv_Usuarios.Rows.Remove(Dgv_Usuarios.CurrentRow);
            }
            else
            {

            }
        }
    }
}
