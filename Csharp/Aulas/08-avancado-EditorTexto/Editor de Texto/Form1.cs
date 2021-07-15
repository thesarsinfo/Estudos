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

namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {
        StringReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }


        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Tsmic_Novo_Click(object sender, EventArgs e)
        {
            Novo();
        }
        private void Salvar()
        {
            //Aula 83 salvando arquivos
            //Na propriedade defaulfExt definimos o nome da extensão para sara
            try
            {
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new
                    FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate,FileAccess.Write);
                    //Criado o arquivo
                    StreamWriter cfb_StreamWriter = new StreamWriter(arquivo);
                    cfb_StreamWriter.Flush();// zerar o  o buff
                    cfb_StreamWriter.BaseStream.Seek(0, SeekOrigin.Begin);//Onde começar no arquivo
                    cfb_StreamWriter.Write(this.richTextBox1.Text);
                    cfb_StreamWriter.Flush();
                    cfb_StreamWriter.Close(); //Nunca esqueça de fechar o arquivo que apos fechado que salva
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message, "Erro ao Gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Tsmic_Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void Abrir()
        {
            this.openFileDialog1.Multiselect = false; // só selecionar um arquivos
            this.openFileDialog1.Title = "Abri Arquivo";
            openFileDialog1.InitialDirectory = @"C:\Users\Saraiva\Documents\Estudos\CursosYouTube\Csharp\Aulas\08-avancado-EditorTexto\Editor de Texto\Properties\texto\";
            // @ mostra que \ não é um caracter especial de escape
            openFileDialog1.Filter = "(*.SARA)|*.SARA";// filtrando pela extensão criada.
            //Vamos testar a abertura da janela no script abaixo
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                                                //abrindo o arquivo , modo de operação do arquivo, modo de leitura do arquivo
                    FileStream arquivo = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                    StreamReader cfb_StreamReader = new StreamReader(arquivo);
                    cfb_StreamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = cfb_StreamReader.ReadLine();
                    while(linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = cfb_StreamReader.ReadLine();

                    }
                    cfb_StreamReader.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro de Leitura: " + ex.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            
        }

        private void Tsmic_Abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Btn_Abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }
        private void Copiar()
        {
            //Obs: O recortar é o mesmo procedimento mas usamos .cut()
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        private void Colar()
        {
            richTextBox1.Paste();
        }

        private void Btn_Copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void Tsmic_Copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void Tsmic_Colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void Btn_Colar_Click(object sender, EventArgs e)
        {
            Colar();
        }
        private void Negrito()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool negri, itali, sublinha = false;
            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            negri = richTextBox1.SelectionFont.Bold;
            itali = richTextBox1.SelectionFont.Italic;
            sublinha = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);
            if (negri == false)
            {
                if (itali == true && sublinha == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (itali == false && sublinha == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);

                }
                else if (itali == true && sublinha == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);

                }
                else if (itali == false && sublinha == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);

                }                
            }
            else
            {
                if (itali == true && sublinha == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (itali == false && sublinha == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);

                }
                else if (itali == true && sublinha == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);

                }
            }            
        }
        private void Italico()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool negri, itali, sublinha = false;
            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            negri = richTextBox1.SelectionFont.Bold;
            itali = richTextBox1.SelectionFont.Italic;
            sublinha = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);
            if (itali == false)
            {
                if (negri == true && sublinha == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Bold  | FontStyle.Underline);
                }
                else if (negri == false && sublinha == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);

                }
                else if (negri == true && sublinha == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Bold );

                }
                else if (negri == false && sublinha == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);

                }
            }
            else
            {
                if (negri == true && sublinha == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (negri == false && sublinha == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);

                }
                else if (negri == true && sublinha == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);

                }
            }
        }
        private void Sublinhado()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool negri, itali, sublinha = false;
            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            negri = richTextBox1.SelectionFont.Bold;
            itali = richTextBox1.SelectionFont.Italic;
            sublinha = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);
            if (sublinha == false)
            {
                if (negri == true && itali == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                }
                else if (negri == false && itali == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);

                }
                else if (negri == true && itali == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Bold);

                }
                else if (negri == false && itali == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);

                }
            }
            else
            {
                if (negri == true && itali == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (negri == false && itali == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);

                }
                else if (negri == true && itali == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);

                }
            }
        }

        private void Btn_Negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void Btn_Italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void Btn_Sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void Tsmic_Italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void Tsmic_Negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void Tsmic_Sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }
        private void AlinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void AlinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void Centralizar()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Tsmicc_AlinharEsquerda_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void Btn_AlinharEsquerda_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void Btn_Centralizar_Click(object sender, EventArgs e)
        {
            Centralizar();
        }

        private void Tsmicc_Centralizar_Click(object sender, EventArgs e)
        {
            Centralizar();
        }

        private void Tsmicc_AlinharDireita_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void Btn_AlinharDireita_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }
        private void Imprimir()
        {
            /* Aula 88
             * No Metodo de impressão vamos trabalhar com duas rotinas
             * primeiro com print dialog e o outro print document
             */
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            leitura = new StringReader(texto);
            //O if abaixo verifica se foi clicado em ok ou cancelar
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina = 0; //variavel responsavel para definir linhas por pagina
            float PosicaoY = 0;
            int cont = 0;
            //Definir margens
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;
            if (margemEsquerda < 5)
            {
                margemEsquerda = 20;//valores padroes de mercado
            }
            if (margemSuperior < 5)
            {
                margemSuperior = 20;//valores padroes de mercado
            }
            string linha = null; // guarda que vai guardada para o stream de impressão
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            
            linhasPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics); //calculo para definir
            //Linhas por paginas depedendo o tamanho da fonte.
            linha = leitura.ReadLine();
            while(cont < linhasPagina)
            {
                PosicaoY = (margemSuperior + (cont * fonte.GetHeight(e.Graphics)));//Definir o tamanho da linha 
                //para evitar encavalamento
                e.Graphics.DrawString(linha, fonte, pincel, margemEsquerda, PosicaoY, new StringFormat()); //
                //Usamos o contrutor numero 6
                cont += 1;
                linha = leitura.ReadLine();
            }
            if (linha != null)
            {
                e.HasMorePages = true; //Controle para imprimir em outra pagina
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }

        private void Tsmic_Imprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
    }
}
