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
    public partial class Fm_TreeView : Form
    {
        public Fm_TreeView()
        {
            InitializeComponent();
        }

        private void Tv_Marcas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Tb_Tag.Clear();
            Tb_Carro.Text = Tv_Marcas.SelectedNode.Text;
            if (Tv_Marcas.SelectedNode.Tag != null)
            {
                Tb_Tag.Text = Tv_Marcas.SelectedNode.Tag.ToString();
            }
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            TreeNode raizEstados = Tv_Marcas.Nodes.Add("Estados");
            raizEstados.Name = "raizEstados";
            TreeNode raizCores = Tv_Marcas.Nodes.Add("Cores");
            raizCores.Name = "raizCores";

            TreeNode estado1 = raizEstados.Nodes.Add("Minas Gerais");
            estado1.Name = "minasGerais";
            TreeNode estado2 = raizEstados.Nodes.Add("São Paulo");
            estado2.Name = "saoPaulo";
            TreeNode estado3 = raizEstados.Nodes.Add("Rio de Janeiro");
            estado3.Name = "rioDeJaneiro";

        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            try
            {
                Tv_Marcas.Nodes.Remove(Tv_Marcas.Nodes["raizEstados"]);
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao remover nó" + erro.ToString());
            }
        }

        private void Btn_RemoverSelecionado_Click(object sender, EventArgs e)
        {
            Tv_Marcas.Nodes.Remove(Tv_Marcas.SelectedNode);
        }
    }
}
