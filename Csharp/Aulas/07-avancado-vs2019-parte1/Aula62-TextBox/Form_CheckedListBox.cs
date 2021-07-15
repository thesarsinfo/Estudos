using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 CheckedListBox container ou coleção de checkbox em grupo do mesmo tipo de valores facilita a manipulação
de elementos.

 */

namespace Aula62_TextBox
{
    public partial class Form_CheckedListBox : Form
    {
        public Form_CheckedListBox()
        {
            InitializeComponent();
        }

        private void Form_CheckedListBox_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            string mostra = "";
            //Permite trabalhar com todos os itens.
            ////CLB_Transportes.Items;
            //retornando o primeiro item da lista
               // txt += CLB_Transportes.Items[0].ToString(); //To string para converter objeto em string
            //Permite trabalhar com itens selecionados
            //CheckedItens retorna uma coleção de itens selecionados
            mostra += CLB_Transportes.CheckedItems[0].ToString();
            //mostrando os valores selecionados 
            foreach(string t in CLB_Transportes.CheckedItems)
            {
                txt += t + ", ";
            }
            MessageBox.Show(mostra); // retorna o primeiro iten selecionado
            MessageBox.Show(txt);//
        }

        private void Btn_LimparListas_Click(object sender, EventArgs e)
        {
            CLB_Transportes.Items.Clear();//Limpa toda a coleçao
        }
        //Nesse metodo adicionamos manualmente os itens
        private void Btn_ResetarLista_Click(object sender, EventArgs e)
        {
            CLB_Transportes.Items.Clear();
            //Manipulação item por item
            /*
            object carro = "Carro";
            object aviao = "Aviao";
            object navio = "Navio";
            object onibus = "Ônibus";
            object trem = "Trem";
            /*
            CLB_Transportes.Items.Add(carro, false);//Add nesse caso pede um objeto e se marcar ele quando
            //criar
            CLB_Transportes.Items.Add(aviao, false);
            CLB_Transportes.Items.Add(navio, false);
            CLB_Transportes.Items.Add(onibus, false);
            CLB_Transportes.Items.Add(trem, false);
            */

            //Manipulação por coleção Criamos uma lista
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");

            
            CLB_Transportes.Items.AddRange(tr.ToArray());//Converte a lista para um array
        }

        private void Btn_AdicionarNovoTransporte_Click(object sender, EventArgs e)
        {
            if (TB_NovoTransporte.Text != "")
            {
                CLB_Transportes.Items.Add(TB_NovoTransporte.Text);
                TB_NovoTransporte.Clear();
                TB_NovoTransporte.Focus();
            }
        }
    }
}
