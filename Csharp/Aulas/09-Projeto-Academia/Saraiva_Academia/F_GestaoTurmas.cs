using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Saraiva_Academia
{
    public partial class F_GestaoTurmas : Form
    {
        string idSelecionado;
        int modo = 0; //0 = Modo Padrao 1 = Modo Edição, 2 = Modo de Inserção
        string valorQueryDgv;

        public F_GestaoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
            /*
             * Aula 114 
             * Para popular o combobox vamos trbalhar com propriedade DisplayName e Value member
             * para isso necessita de atenção para pq vamos trabalhar com IDs.
             * 
             */
            string valorQueryProfessores, valorQueryHorarios; 
            valorQueryDgv =
            @"
                SELECT
                    turmas.N_IdTurma as 'Id Turma',
                    turmas.T_DescricaoTurma as 'Descrição da Turma',
                    horarios.T_DescricaoHorario as 'Horario'                           
                FROM
                    tb_turmas as turmas
                INNER JOIN
                    tb_horarios as horarios on horarios.N_IdHorario = turmas.N_IdHorario
            ";
            dgv_Turmas.DataSource = Banco.Dql(valorQueryDgv);
            dgv_Turmas.Columns[0].Width = 40;
            dgv_Turmas.Columns[1].Width = 120;
            dgv_Turmas.Columns[2].Width = 85;

            //Aula 115 Popular ComboBox Professores


            valorQueryProfessores =
            @"
                SELECT
                    N_IdProfessor,
                    T_NomeProfessor
                FROM
                    tb_professores
                ORDER BY 
                    N_IdProfessor
            ";
            Cb_Professor.Items.Clear();
            Cb_Professor.DataSource = Banco.Dql(valorQueryProfessores);
            Cb_Professor.DisplayMember = "T_NomeProfessor";//vaoor mstrado na interface
            Cb_Professor.ValueMember = "N_IdProfessor"; //Usado em delete ou update valor real
            //Popular combobox Status (Ativa = A ,Paralisada = P, Cancelada = C)
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativa");
            status.Add("P", "Paralisada");
            status.Add("C", "Cancelada");
            cb_Status.Items.Clear();
            cb_Status.DataSource = new BindingSource(status, null);
            cb_Status.DisplayMember = "Value";
            cb_Status.ValueMember = "Key";
            //Popular combo box de horários
            valorQueryHorarios =
            @"
                SELECT
                    N_IdHorario,
                    T_DescricaoHorario
                FROM
                    tb_horarios
                ORDER BY 
                    T_DescricaoHorario
            ";
            cb_Horario.Items.Clear();
            cb_Horario.DataSource = Banco.Dql(valorQueryHorarios);
            cb_Horario.DisplayMember = "T_DescricaoHorario";//vaoor mstrado na interface
            cb_Horario.ValueMember = "N_IdHorario"; //Usado em delete ou update valor real

        }

        private void dgv_Turmas_SelectionChanged(object sender, EventArgs e)
        {
            string valorQuery;
            modo = 0;
            DataGridView dataGridView = (DataGridView)sender;
            int contLinhas = dataGridView.SelectedRows.Count;
            if(contLinhas > 0)
            {
                idSelecionado = dataGridView.Rows[dgv_Turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                valorQuery =
                @"
                    SELECT
                        T_DescricaoTurma ,
                        N_IdProfessor ,
                        N_IdHorario,
                        N_MaximoAlunos,
                        T_Status
                    FROM
                        tb_turmas 
                    WHERE
                        N_IdTurma=" + idSelecionado;
                DataTable dataTable = Banco.Dql(valorQuery);
                tb_DescricaoTurma.Text = dataTable.Rows[0].Field<string>("T_DescricaoTurma");
                Cb_Professor.SelectedValue = dataTable.Rows[0].Field<Int64>("N_IdProfessor").ToString();
                nud_MaximoAlunos.Value = dataTable.Rows[0].Field<Int64>("N_MaximoAlunos");
                cb_Status.SelectedValue = dataTable.Rows[0].Field<string>("T_Status");
                cb_Horario.SelectedValue = dataTable.Rows[0].Field<Int64>("N_IdHorario");
                tb_Vagas.Text = CalculaVagas();                

            }
        }
        private string CalculaVagas()
        {
            //Calculo de Vagas
            string queryVagas = String.Format
                (@"
                        SELECT 
                            count(N_IdAluno) as 'Cont. Vagas'
                        FROM
                            tb_alunos
                        WHERE
                            T_Status='A' and N_IdTurma={0}", idSelecionado
                );
            DataTable dataTable = Banco.Dql(queryVagas);
            int vagas = Int32.Parse(Math.Round(nud_MaximoAlunos.Value, 0).ToString());
            vagas -= Int32.Parse(dataTable.Rows[0].Field<Int64>("Cont. Vagas").ToString());
            tb_Vagas.Text = vagas.ToString();
            return vagas.ToString();
        }

        private void Btn_NovaTurma_Click(object sender, EventArgs e)
        {
            tb_DescricaoTurma.Clear();
            Cb_Professor.SelectedIndex = -1;
            nud_MaximoAlunos.Value = 0;
            cb_Status.SelectedIndex = -1;
            cb_Horario.SelectedIndex = -1;//-1 significa para aparecer nada.
            tb_DescricaoTurma.Focus();
            modo = 2;
        }

        private void Btn_SalvarEdicoes_Click(object sender, EventArgs e)
        {
            if (modo != 0)
            {

                string queryTurma = "";//É parametro e temos que inicializar
                string mensagem = "";
                if (modo == 1)
                {
                    queryTurma = String.Format(@"
                    UPDATE
                        tb_turmas
                    SET
                        T_DescricaoTurma='{0}',
                        N_IdProfessor={1},
                        N_IdHorario={2},
                        N_MaximoAlunos={3},
                        T_Status='{4}'
                    WHERE
                        N_IdTurma={5}", tb_DescricaoTurma.Text, Cb_Professor.SelectedValue, cb_Horario.SelectedValue,
                        Int32.Parse(Math.Round(nud_MaximoAlunos.Value, 0).ToString()), cb_Status.SelectedValue, idSelecionado);
                    mensagem = "Dados alterados com sucesso!";
                }
                else 
                {
                    queryTurma = String.Format
                        (@"
                            INSERT INTO
                                tb_turmas
                            (T_DescricaoTurma,N_IdProfessor,N_IdHorario,N_MaximoAlunos,T_Status)
                            VALUES('{0}',{1},{2},{3},'{4}')", tb_DescricaoTurma.Text ,Cb_Professor.SelectedValue ,cb_Horario.SelectedValue,
                            Int32.Parse(Math.Round(nud_MaximoAlunos.Value, 0).ToString()),cb_Status.SelectedValue
                        );
                    mensagem = "Dados inseridos com sucesso!";
                }
                int linha = dgv_Turmas.SelectedRows[0].Index;// para não recarregar o conteudo
                
                Banco.Dml(queryTurma);
                if (modo == 1)
                {
                    dgv_Turmas[1, linha].Value = tb_DescricaoTurma.Text;
                    dgv_Turmas[2, linha].Value = cb_Horario.Text;
                    tb_Vagas.Text = CalculaVagas();
                }
                else
                {
                    dgv_Turmas.DataSource = Banco.Dql(valorQueryDgv);
                }
                MessageBox.Show(mensagem);
            }
        }

        private void Btn_ExcluirTurma_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma a exclução", "Excluir?", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                string queryExcluirTurma = String.Format(@"
                    DELETE
                    FROM
                        tb_turmas
                    WHERE
                         N_IdTurma={0}",idSelecionado);
                Banco.Dml(queryExcluirTurma);
                dgv_Turmas.Rows.Remove(dgv_Turmas.CurrentRow);
                MessageBox.Show("Turma excluida com sucesso");
            }
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_DescricaoTurma_TextChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
            
        }

        private void Cb_Professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void nud_MaximoAlunos_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
            CalculaVagas();
        }

        private void cb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_Horario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void Btn_ImprimirTurma_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPdf = new FileStream(nomeArquivo, FileMode.Create);
            Document documento = new Document(PageSize.A4);
            PdfWriter escritorPdf = PdfWriter.GetInstance(documento, arquivoPdf);
            //Imagem
            //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logocfb.png");
            //logo.ScaleToFit(140f, 120f);
            //logo.Alignment = Element.ALIGN_LEFT; outra forma de posicionar.
            //logo.SetAbsolutePosition(100f, 700f); // X esq para direita Y = base ao topo 
            
            
            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Relatório de Turnas \n\n");
            
            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("Saraiva estudos O curso de C# \n\n");                    

            PdfPTable tabela = new PdfPTable(3);// constroi 3 colunas
            tabela.DefaultCell.FixedHeight = 20;

            //PdfPCell  celula1 = new PdfPCell(new Phrase("Tabela de Preços")); metodo adicionado titulo
            //celula1.AddElement(logo);//adiciona uma imagem            

            tabela.AddCell("ID Turma");
            tabela.AddCell("Turma");
            tabela.AddCell("Horário");

            DataTable dataTableTurmas = Banco.Dql(valorQueryDgv);

            for (int i = 0; i < dataTableTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dataTableTurmas.Rows[i].Field<Int64>("Id Turma").ToString());
                tabela.AddCell(dataTableTurmas.Rows[i].Field<string>("Descrição da Turma"));
                tabela.AddCell(dataTableTurmas.Rows[i].Field<string>("Horario"));

            }
            /* modo de fazer para proxima utilização
            PdfPCell celula2 = new PdfPCell( new Phrase("Tabela de Preços 2"));            
            celula2.Colspan = 3; //Linha 1 de titulo fica mesclada;
            celula2.FixedHeight = 35; // rotaciona a celular
            celula2.HorizontalAlignment = Element.ALIGN_CENTER;
            celula2.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabela.AddCell(celula2);
            */
            documento.Open();
            //documento.Add(logo);
            documento.Add(paragrafo1);
            documento.Add(tabela);
            documento.Add(paragrafo2);
            documento.Close();

            DialogResult resultado = MessageBox.Show("Deseja abrir o relatório impresso?", "Abrir", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
            }
        }
    }
}
