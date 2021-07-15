using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saraiva_Academia
{
    public partial class F_NovoAluno : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        public F_NovoAluno()
        {
            InitializeComponent();
        }

        private void F_NovoAluno_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> statusAluno = new Dictionary<string, string>();
            statusAluno.Add("A", "Ativo");
            statusAluno.Add("B", "Bloqueado");
            statusAluno.Add("C", "Cancelado");
            cb_Status.DataSource = new BindingSource(statusAluno, null);
            cb_Status.DisplayMember = "Value";
            cb_Status.ValueMember = "Key";

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            tb_Nome.Clear();
            tb_Nome.Enabled = true;
            mtb_Telefone.Clear();
            mtb_Telefone.Enabled = true;
            cb_Status.SelectedIndex = 0;
            cb_Status.Enabled = true;
            tb_Turma.Clear();
            tb_Plano.Clear();
            tb_Nome.Focus();
            btn_Gravar.Enabled = true;
            btn_Cancelar.Enabled = true;
            btn_Novo.Enabled = false;
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (destinoCompleto == "")
            {
                if(MessageBox.Show("Sem foto selecionada, deseja continuar?", "ERRO",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pb_Foto.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("Erro ao localizar a foto, deseja continuar?", "Erro", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
                string queryInsertAluno = String.Format
                (@"
                    INSERT INTO
                        tb_alunos
                        (T_NomeAluno,T_Telefone,T_Status,N_IdTurma,T_CaminhoFoto)
                    VALUES ('{0}','{1}','{2}',{3},'{4}')"
                    , tb_Nome.Text, mtb_Telefone.Text, cb_Status.SelectedValue, tb_Turma.Tag.ToString(),destinoCompleto
                    //usamos tag porque vai ser carregado uam coleção de itens do database
                );
            Banco.Dml(queryInsertAluno);
            MessageBox.Show("Novo Aluno inserido");

            tb_Nome.Clear();
            tb_Nome.Enabled = false;
            mtb_Telefone.Clear();
            mtb_Telefone.Enabled = false;
            cb_Status.SelectedIndex = 0;
            cb_Status.Enabled = false;
            tb_Turma.Clear();
            tb_Plano.Clear();
            btn_Gravar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Novo.Enabled = true;
            pb_Foto.ImageLocation = "";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tb_Nome.Clear();
            tb_Nome.Enabled = false;
            mtb_Telefone.Clear();
            mtb_Telefone.Enabled = false;
            cb_Status.SelectedIndex = 0;
            cb_Status.Enabled = false;
            tb_Turma.Clear();
            tb_Plano.Clear();            
            btn_Gravar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Novo.Enabled = true;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_SelecionaTurma_Click(object sender, EventArgs e)
        {
            F_SelecionarTurma f_SelecionarTurma = new F_SelecionarTurma(this);
            f_SelecionarTurma.ShowDialog();

        }

        private void btn_Foto_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            pastaDestino = Globais.caminhoFotos;
            destinoCompleto = "";

            if (openFileDialog1.ShowDialog()== DialogResult.OK )
            {
                origemCompleto = openFileDialog1.FileName; //Retorna o camnho completo o path com nome do arquivo
                foto = openFileDialog1.SafeFileName;//Retorna o nome do arquivo e extensão
                destinoCompleto = pastaDestino + foto;
            }
            //Verificar se o arquivo exisate no destino para ver se sobrepoem ou nao
            if(File.Exists(destinoCompleto) )
            {
                if(MessageBox.Show("Arquivo já existe, deseja substiuir?","Subtituir", 
                   MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }               
            }
            pb_Foto.ImageLocation = origemCompleto;
        }
    }
}
