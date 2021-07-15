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
    public partial class Form_Principal : Form
    {
        public List<string> veiculos = new List<string>();
        public int num;
        public Form_Principal()
        {
            InitializeComponent();
            num = 0;
        }

       

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            
            if (Tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um veiculo");
                Tb_veiculo.Focus();
                return;
            }
            veiculos.Add(Tb_veiculo.Text);
            foreach (string item in veiculos)
            {
                MessageBox.Show(item);
            }
            Tb_Veiculos.Text += Tb_veiculo.Text + ", ";
            Tb_veiculo.Clear();
            Tb_veiculo.Focus();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {

            veiculos.Clear();
            Tb_Veiculos.Clear();
            Tb_veiculo.Clear();
            Tb_veiculo.Focus();
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            Form_Veiculos form_Veiculos = new Form_Veiculos(Tb_Veiculos.Text,this);
            //this se refere ao Form principal
            //showdialog mostra uma caixa
            //de dialogo e não consegue voltar para form anterior sem usar o botao voltar ou fechar

            form_Veiculos.ShowDialog();
            //form_Veiculos.Show();
            //Metodo show mostra uma nova janela ao usuario  e voce consegue usar outra janela no mesmo
            //programa
        }

        private void Btn_ValNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void SubMenu_CheckBox_Click(object sender, EventArgs e)
        {
            Form_CheckBox form_CheckBox = new Form_CheckBox();
            form_CheckBox.ShowDialog();
        }

        private void SubMenu_CheckedListBox_Click(object sender, EventArgs e)
        {
            Form_CheckedListBox form_CheckedListBox = new Form_CheckedListBox();
            form_CheckedListBox.ShowDialog();
        }

        private void SubMenu_ComboBox_Click(object sender, EventArgs e)
        {
            Form_ComboBox form_ComboBox = new Form_ComboBox();
            form_ComboBox.ShowDialog();
        }

        private void SubMenu_DateTimePicker_Click(object sender, EventArgs e)
        {
            Form_DateTimePicker form_DateTimePicker = new Form_DateTimePicker();
            form_DateTimePicker.ShowDialog();
        }

        private void SubMenu_LinkLabel_Click(object sender, EventArgs e)
        {
            Form_LinkLabel form_LinkLabel = new Form_LinkLabel();
            form_LinkLabel.ShowDialog();
        }

        private void SubMenu_ListBox_Click(object sender, EventArgs e)
        {
            Form_ListBox form_ListBox = new Form_ListBox();
            form_ListBox.ShowDialog();
        }

        private void SubMenu_ListView_Click(object sender, EventArgs e)
        {
            Form_ListView form_ListView = new Form_ListView();
            form_ListView.ShowDialog();
        }

        private void SubMenu_MaskedTextBox_Click(object sender, EventArgs e)
        {
            Fm_MaskedTextBox fm_MaskedTextBox = new Fm_MaskedTextBox();
            fm_MaskedTextBox.ShowDialog();
        }

        private void SubMenu_MonthCalendar_Click(object sender, EventArgs e)
        {
            Fm_MonthCalendar fm_MonthCalendar = new Fm_MonthCalendar();
            fm_MonthCalendar.ShowDialog();
        }
        /*
         * Aula 78 Notifyicon abaixo fica as operações para fechar restaurar e mensagem do programa
         * usando o evento ItemClick
         */
        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // O " e " ja vem com as informações clicadas e temos so verificar o nome
            if(e.ClickedItem.Name.ToString() == "Tsmi_Fechar")//nome do objeto do cotext menu strip
            {
                this.Close();//Fecha o formulario e o programa
            }
            else if (e.ClickedItem.Name.ToString() == "Tsmi_Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "Tsmi_Mensagem")
            {
                MessageBox.Show("Saraiva Estudos curso de C#");
            }
        }

        private void Tsmi_NumericUpDown_Click(object sender, EventArgs e)
        {
            Fm_NumericUpDown fm_NumericUpDown = new Fm_NumericUpDown();
            fm_NumericUpDown.ShowDialog();
        }

        private void Tsmi_PictureBox_Click(object sender, EventArgs e)
        {
            Fm_PictureBox fm_PictureBox = new Fm_PictureBox();
            fm_PictureBox.ShowDialog();
        }

        private void Tsmi_ProgressBar_Click(object sender, EventArgs e)
        {
            Fm_ProgressBar fm_ProgressBar = new Fm_ProgressBar();
            fm_ProgressBar.ShowDialog();
        }

        private void Tsmi_RadioButton_Click(object sender, EventArgs e)
        {
            Fm_RadioButton fm_RadioButton = new Fm_RadioButton();
            fm_RadioButton.ShowDialog();
        }

        private void Tsmi_TrackBar_Click(object sender, EventArgs e)
        {
            Fm_TrackBar fm_TrackBar = new Fm_TrackBar();
            fm_TrackBar.ShowDialog();
        }

        private void Tsmi_TreeView_Click(object sender, EventArgs e)
        {
            Fm_TreeView fm_TreeView = new Fm_TreeView();
            fm_TreeView.ShowDialog();
        }

        private void Tsmi_WebBrowser_Click(object sender, EventArgs e)
        {
            Fm_WebBrowser fm_WebBrowser = new Fm_WebBrowser();
            fm_WebBrowser.ShowDialog();
        }

        private void Tsmi_SplitContainer_Click(object sender, EventArgs e)
        {
            Fm_SplitContainer fm_SplitContainer = new Fm_SplitContainer();
            fm_SplitContainer.ShowDialog();
        }

        private void Tsmi_TabControl_Click(object sender, EventArgs e)
        {
            Fm_TabControl fm_TabControl = new Fm_TabControl();
            fm_TabControl.ShowDialog();
        }

        private void Tsmi_TableLayoutPanel_Click(object sender, EventArgs e)
        {
            Fm_TableLayoutPanel fm_TableLayoutPanel = new Fm_TableLayoutPanel();
            fm_TableLayoutPanel.ShowDialog();
        }

        private void Tsmi_ToolStripContainer_Click(object sender, EventArgs e)
        {
            Fm_ToolStripContainer fm_ToolStripContainer = new Fm_ToolStripContainer();
            fm_ToolStripContainer.ShowDialog();
        }

        private void Tsmi_BackgroundWork_Click(object sender, EventArgs e)
        {
            Fm_BackgroundWorker fm_BackgroundWorker = new Fm_BackgroundWorker();
            fm_BackgroundWorker.ShowDialog();
        }

        private void Tmsi_Timer_Click(object sender, EventArgs e)
        {
            Fm_Timer fm_Timer = new Fm_Timer();
            fm_Timer.ShowDialog();
        }

        private void Tmsi_SqlLite_Click(object sender, EventArgs e)
        {
            Fm_SqLite fm_SqLite = new Fm_SqLite();
            fm_SqLite.ShowDialog();
        }
    }
}
