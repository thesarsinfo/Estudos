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
    public partial class F_SelecionarTurma : Form
    {
        F_NovoAluno f_NovoAluno;
        public F_SelecionarTurma(F_NovoAluno formNovoAluno)
        {
            InitializeComponent();
            f_NovoAluno = formNovoAluno;
            
        }

        private void F_SelecionarTurma_Load(object sender, EventArgs e)
        {
            string queryTurmas = String.Format
                (@"
                    SELECT
                        Turmas.N_IdTurma as 'ID',
                        Turmas.T_DescricaoTurma as 'Turma',
                        Horarios.T_DescricaoHorario as 'Horario',
                        Professores.T_NomeProfessor as 'Professor',
                        Turmas.N_MaximoAlunos as 'Max Alunos',
                        (
                            SELECT
                                count(N_IdAluno)
                            FROM 
                                tb_alunos as Alunos
                            WHERE
                                Alunos.N_IdTurma = Turmas.N_IdTurma and Alunos.T_Status = 'A'
                        ) as 'Qtde. Alunos'
                    FROM
                        tb_turmas as Turmas
                    INNER JOIN
                        tb_professores as Professores on  Professores.N_IdProfessor = Turmas.N_IdProfessor,
                        tb_horarios as Horarios on Horarios.N_IdHorario = Turmas.N_IdHorario            
                ");
            dgv_SelecionarTurma.DataSource = Banco.Dql(queryTurmas);
        }

        private void dgv_SelecionarTurma_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgvSelecionarTurma = (DataGridView)sender;
            int maximoAlunos = 0;
            int quantidadeAluno = 0;
            maximoAlunos = Int32.Parse(dgvSelecionarTurma.SelectedRows[0].Cells[4].Value.ToString());
            quantidadeAluno = Int32.Parse(dgvSelecionarTurma.SelectedRows[0].Cells[5].Value.ToString());
            if (quantidadeAluno >= maximoAlunos)
            {
                MessageBox.Show("Não há vagas nesse turma");
            }
            else
            {
                f_NovoAluno.tb_Turma.Text = dgvSelecionarTurma.Rows[dgvSelecionarTurma.SelectedRows[0].Index].Cells[1].Value.ToString(); //Descrição da Turma
                f_NovoAluno.tb_Turma.Tag = dgvSelecionarTurma.Rows[dgvSelecionarTurma.SelectedRows[0].Index].Cells[0].Value.ToString(); //Id da Turma
                Close();
            }



        }
    }
}
