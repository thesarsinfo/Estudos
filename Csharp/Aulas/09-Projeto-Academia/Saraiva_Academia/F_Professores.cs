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
    public partial class F_Professores : Form
    {
        public F_Professores()
        {
            InitializeComponent();
        }

        private void F_Professores_Load(object sender, EventArgs e)
        {
            string valorquery;
            valorquery = @"
                SELECT 
                    N_IdProfessor as 'ID',
                    T_NomeProfessor as 'Professor',
                    T_Telefone as 'Telefone'
                FROM
                    tb_professores
                ORDER BY    
                    Professor;
            ";
            Dgv_Professores.DataSource = Banco.Dql(valorquery);
            Dgv_Professores.Columns[0].Width = 70;
            Dgv_Professores.Columns[1].Width = 180;
            Dgv_Professores.Columns[2].Width = 100;
        }

        private void Dgv_Professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int contLinhas = dataGridView.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string valorId = Dgv_Professores.SelectedRows[0].Cells[0].Value.ToString();
                string valorQuery = @"
                        SELECT
                            N_IdProfessor as 'ID do professor',
                            T_NomeProfessor as 'Nome do professor',
                            T_Telefone as 'Telefone'
                        FROM                            
                            tb_professores
                        WHERE
                            N_IdProfessor=" + valorId;
                dataTable = Banco.Dql(valorQuery);
                //Carrega os campos
                Tb_IdProfessor.Text = dataTable.Rows[0].Field<Int64>("ID do professor").ToString();
                Tb_Professor.Text = dataTable.Rows[0].Field<string>("Nome do professor");
                Mtb_Telefone.Text = dataTable.Rows[0].Field<string>("Telefone");

            }
        }

        private void Btn_FecharJanela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_NovoProfessor_Click(object sender, EventArgs e)
        {
            Tb_IdProfessor.Clear();
            Tb_Professor.Clear();
            Mtb_Telefone.Clear();
            Tb_Professor.Focus();
        }

        private void Btn_SalvarAlteracoes_Click(object sender, EventArgs e)
        {
            string valorQuery, visualizarQuery;
            if (Tb_IdProfessor.Text == "")
            {
                valorQuery = "INSERT INTO tb_professores (T_NomeProfessor,T_Telefone) VALUES('"+Tb_Professor.Text+"','"+Mtb_Telefone.Text+"')";
            }
            else
            {
                valorQuery = "UPDATE tb_professores SET T_NomeProfessor='" + Tb_Professor.Text + "', T_Telefone='" + Mtb_Telefone.Text + "' WHERE N_IdProfessor='"+Tb_IdProfessor.Text+ "'";
            }
            Banco.Dml(valorQuery);
            visualizarQuery = @"
                SELECT 
                    N_IdProfessor as 'ID',
                    T_NomeProfessor as 'Professor',
                    T_Telefone as 'Telefone'
                FROM
                    tb_professores
                ORDER BY    
                    Professor;
            ";
            Dgv_Professores.DataSource = Banco.Dql(visualizarQuery);
        }

        private void Btn_ExcluirProfessor_Click(object sender, EventArgs e)
        {
            string valorQuery;
            if(Tb_IdProfessor.Text == "")
            {
                MessageBox.Show("Nenhum professor selecionado");
                return;
            }
            DialogResult resposta = MessageBox.Show("Deseja excluir o professor da database:", "Excluir", MessageBoxButtons.YesNo);
            if(DialogResult.Yes == resposta )
            {
                valorQuery = "Delete FROM tb_professores WHERE N_IdProfessor=" + Tb_IdProfessor.Text;
                Banco.Dml(valorQuery);
                Dgv_Professores.Rows.Remove(Dgv_Professores.CurrentRow);
            }
        }
    }
}
