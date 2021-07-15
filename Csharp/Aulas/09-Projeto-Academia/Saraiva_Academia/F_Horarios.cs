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
    public partial class Horários : Form
    {
        public Horários()
        {
            InitializeComponent();
        }

        private void Horários_Load(object sender, EventArgs e)
        {
            string visualizarQuery = @"
                SELECT
                    N_IdHorario  as 'ID',
                    T_DescricaoHorario as 'Horário'
                FROM
                    tb_horarios
                ORDER BY
                    T_DescricaoHorario
                ";
            Dgv_Horarios.DataSource = Banco.Dql(visualizarQuery);
            Dgv_Horarios.Columns[0].Width = 60;
            Dgv_Horarios.Columns[1].Width = 170;

        }

        private void Dgv_Horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string valorId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string valorQuery = @"
                    SELECT
                        *
                    FROM
                        tb_horarios
                    WHERE
                        N_IdHorario=" +valorId;
                dataTable = Banco.Dql(valorQuery);
                Tb_IdHorario.Text = dataTable.Rows[0].Field<Int64>("N_IdHorario").ToString();
                Mtb_descricaoHorario.Text = dataTable.Rows[0].Field<string>("T_DescricaoHorario");
            }
            
        }

        private void Btn_NovoHorario_Click(object sender, EventArgs e)
        {
            Tb_IdHorario.Clear();
            Mtb_descricaoHorario.Clear();
            Mtb_descricaoHorario.Focus();
        }

        private void Btn_SalvarHorario_Click(object sender, EventArgs e)
        {
            string valorQuery;
            if (Tb_IdHorario.Text == "")
            {
                valorQuery = "INSERT INTO tb_horarios (T_DescricaoHorario) VALUES('" + Mtb_descricaoHorario.Text + "')";

            }
            else
            {
                valorQuery = "UPDATE tb_horarios SET T_DescricaoHorario='" + Mtb_descricaoHorario.Text + "' WHERE N_IdHorario=" + Tb_IdHorario.Text;
            }
            
            Banco.Dml(valorQuery);
            string visualizarQuery = @"
                SELECT
                    N_IdHorario  as 'ID',
                    T_DescricaoHorario as 'Horário'
                FROM
                    tb_horarios
                ORDER BY
                    T_DescricaoHorario
                ";
            Dgv_Horarios.DataSource = Banco.Dql(visualizarQuery);

        }

        private void Btn_ExcluirHorario_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirmar a excluir", "Excluir?", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                string valorQuery = "DELETE FROM tb_horarios WHERE N_IdHorario=" + Tb_IdHorario.Text;
                Banco.Dml(valorQuery);
                Dgv_Horarios.Rows.Remove(Dgv_Horarios.CurrentRow);
            }
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
