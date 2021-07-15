using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula62_TextBox
{
    /*
     AS colunas foram adicionadas manualmente e selecionamos a propriedade fullrowselected = true para quando selecionar
    linha ela toda seja selecionada.
     */
    public partial class Form_ListView : Form
    {

        public Form_ListView()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
             Tb_Id.Clear();
             Tb_Produto.Clear();
             Tb_Quantidade.Clear();
             Tb_Preco.Clear();
             Tb_Id.Focus();
        }
        private void obter()
        {
            Tb_Id.Text = Lv_Produtos.SelectedItems[0].SubItems[0].Text;
            Tb_Produto.Text = Lv_Produtos.SelectedItems[0].SubItems[1].Text;
            Tb_Quantidade.Text = Lv_Produtos.SelectedItems[0].SubItems[2].Text;
            Tb_Preco.Text = Lv_Produtos.SelectedItems[0].SubItems[3].Text;
            //Definimos a propriedade como multiselected portando trabalhamos no indice 0
            //se nao fosse selecionado era necessario trabalhar com todos
            //Como no casso usamo textbox para obter teremos que usar o indice do subitens
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (Tb_Id.Text == "" || Tb_Produto.Text == "" || Tb_Quantidade.Text == "" || Tb_Preco.Text =="")
            {
                MessageBox.Show("Algum campo entre o ID, Produto, Quantidade e Preço está vazio");
                Limpar();
            }
            else
            {
                string[] colunas = new string[4];
                colunas[0] = Tb_Id.Text;
                colunas[1] = Tb_Produto.Text;
                colunas[2] = Tb_Quantidade.Text;
                colunas[3] = Tb_Preco.Text;
                ListViewItem listViewProdutos = new ListViewItem(colunas);
                Lv_Produtos.Items.Add(listViewProdutos);
                Limpar();
            }
        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            Lv_Produtos.Items.RemoveAt(Lv_Produtos.SelectedIndices[0]);//O indice é sempreo id
        }

        private void Btn_Obter_Click(object sender, EventArgs e)
        {
            obter();            
        }

        private void Lv_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Lv_Produtos.SelectedItems.Count >0)
            {
                obter();
            }
          
        }
    }
}
