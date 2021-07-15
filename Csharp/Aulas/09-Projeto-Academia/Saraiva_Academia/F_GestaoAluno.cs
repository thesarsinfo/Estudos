using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Saraiva_Academia
{
    public partial class F_GestaoAlunos : Form        
    {
        string queryDGV;
        string queryTurmas;
        string turmaAtual = "";
        string idSelecionado = "";
        string turma = "";
        int linha = 0;
        public F_GestaoAlunos()
        {
            InitializeComponent();
        }

        private void F_GestaoAlunos_Load(object sender, EventArgs e)
        {
            queryDGV = 
            @"
                SELECT 
                    N_IdAluno as 'ID',
                    T_NomeAluno as 'Aluno'
                FROM
                    tb_alunos
            ";
            dgv_Alunos.DataSource = Banco.Dql(queryDGV);
            dgv_Alunos.Columns[0].Width = 40;
            dgv_Alunos.Columns[1].Width = 120;
            //Carregar dados no textbox e combobox
            tb_Nome.Text = dgv_Alunos.Rows[dgv_Alunos.SelectedRows[0].Index].Cells[1].Value.ToString();
            // Em sql o operador de concat é o || para concatenar duas querys do SQLITE verifique o doc do SQLSERVER e mysql CONCAT
            queryTurmas =
                @"
                    SELECT
                        N_IdTurma,
                        ('Vagas: ')|| (
                                            (N_MaximoAlunos - (
                                                                    SELECT
                                                                        count(Alunos.N_IdAluno)
                                                                    FROM
                                                                        tb_alunos as Alunos
                                                                    WHERE
                                                                        Alunos.T_Status = 'A' and Alunos.N_IdTurma = tb_turmas.N_IdTurma
                                                                )
                                        ) || ' / Turma: ' || T_DescricaoTurma
                        ) as 'Turma'
                    FROM
                        tb_turmas
                    ORDER BY
                        N_IdTurma        
                ";
            cb_Turmas.Items.Clear();
            cb_Turmas.DataSource = Banco.Dql(queryTurmas);
            cb_Turmas.DisplayMember = "Turma";
            cb_Turmas.ValueMember = "N_IdTurma";
            //carregar status combobox
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cb_Status.DataSource = new BindingSource(status, null);
            cb_Status.DisplayMember = "Value";
            cb_Status.ValueMember = "Key";
            turma = cb_Turmas.Text;
            turmaAtual = cb_Turmas.Text;
            idSelecionado = dgv_Alunos.Rows[0].Cells[0].Value.ToString();


        }

        private void btn_SalvarEdicoes_Click(object sender, EventArgs e)
        {
            turma = cb_Turmas.Text;
            if (turmaAtual != turma)
            {
                string[] t = turma.Split(' ');
                int vagas = int.Parse(t[1]);
                if (vagas < 1)
                {
                    MessageBox.Show("Não há vagas na turma selecionada, selecione outra turma!");
                    cb_Turmas.Focus();
                    return;
                }
                //linha = dgv_Alunos.SelectedRows[0].Index;
                string queryAtualizarAluno = String.Format
                    (@"
                        UPDATE
                            tb_alunos
                        SET
                            T_NomeAluno = '{0}',
                            T_Telefone = '{1}',
                            T_Status = '{2}',
                            N_IdTurma = {3}
                        WHERE
                            N_IdAluno = {4}"
                        ,tb_Nome.Text
                        ,mtb_Telefone.Text
                        ,cb_Status.SelectedValue
                        ,cb_Turmas.SelectedValue
                        ,idSelecionado
                    );
                Banco.Dml(queryAtualizarAluno);
                //dgv_Alunos[1, linha].Value = tb_Nome.Text;
            }
        }

        private void btn_ExcluirAluno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclução", "Excluir?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(pb_FotoAluno.ImageLocation))//verifica se a imagem existe
                {
                    File.Delete(pb_FotoAluno.ImageLocation);
                }
                string queryExcluirAluno = String.Format(@"
                    DELETE
                    FROM
                        tb_alunos
                    WHERE
                         N_IdAluno={0}", idSelecionado);
                Banco.Dml(queryExcluirAluno);
                dgv_Alunos.Rows.Remove(dgv_Alunos.CurrentRow);
                MessageBox.Show("Turma excluida com sucesso");
            }
        }

        private void btn_Financeiro_Click(object sender, EventArgs e)
        {

        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_Alunos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgvAlunos = (DataGridView)sender;
            if(dgvAlunos.SelectedRows.Count > 0)
            {
                idSelecionado = dgvAlunos.Rows[0].Cells[0].Value.ToString(); // evita erro se não houver nenhum cadastros
                tb_Nome.Text = dgvAlunos.Rows[dgvAlunos.SelectedRows[0].Index].Cells[1].Value.ToString();
                idSelecionado = dgvAlunos.Rows[dgvAlunos.SelectedRows[0].Index].Cells[0].Value.ToString();
                string dgvQueryCampos = String.Format
                    (@"
                        SELECT
                            N_IdAluno,
                            T_NomeAluno,
                            T_Telefone,
                            T_Status,
                            N_IdTurma,
                            T_CaminhoFoto
                        FROM
                            tb_alunos
                        WHERE
                            N_IdAluno = {0}", idSelecionado
                    );
                DataTable dataTable =  Banco.Dql(dgvQueryCampos);
                tb_Nome.Text = dataTable.Rows[0].Field<string>("T_NomeAluno");
                mtb_Telefone.Text = dataTable.Rows[0].Field<string>("T_Telefone");
                cb_Status.SelectedValue = dataTable.Rows[0].Field<string>("T_Status");
                cb_Turmas.SelectedValue = dataTable.Rows[0].Field<Int64>("N_IdTurma").ToString();
                pb_FotoAluno.ImageLocation = dataTable.Rows[0].Field<string>("T_CaminhoFoto");
                turmaAtual = cb_Turmas.Text;

            }
        }
    }
}
