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
    public partial class F_Login : Form
    {
        F_Principal f_Principal;
        DataTable dataTable = new DataTable();
        public F_Login(F_Principal form)
        {
            InitializeComponent();
            f_Principal = form;
        }

        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            string username = Tb_Username.Text;
            string senha = Tb_Senha.Text;
            if(Tb_Username.Text == "" || Tb_Senha.Text == "")
            {
                MessageBox.Show("Usuario ou senha inválidos");
                Tb_Username.Focus();
                return;
            }
            //Sempre faça o filtro de verificação de duplicidade dentro do cadastro do usuário
            //Podemos usar o nome e o id do usuario como chave Primária para evita duplicidades de username
            string sql = "Select * FROM tb_usuarios WHERE T_Username='" + username+"'AND T_Senha ='"+senha+"'";
            dataTable = Banco.Dql(sql);
            if (dataTable.Rows.Count == 1)
            {
                //Duas maneiras diferentes de fazer a mesma coisa mas a 2 da menos manunteção
                //Integer no SQL é o Int64 aqui e temos que usar tostring();
            /*1*/f_Principal.La_Acesso.Text = dataTable.Rows[0].ItemArray[5].ToString();//Converter tipo Array em String
            /*2*/f_Principal.La_NomeUsuario.Text = dataTable.Rows[0].Field<string>("T_Nome_Usuario");
                f_Principal.Pb_LedLogado.Image = Properties.Resources.farolverdecircle;
                Globais.nivel = int.Parse(dataTable.Rows[0].Field<Int64>("N_Nivel_Usuario").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado ou senha correta");
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
