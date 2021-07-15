
namespace Aula62_TextBox
{
    partial class Form_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.Tb_veiculo = new System.Windows.Forms.TextBox();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Veiculos = new System.Windows.Forms.TextBox();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.Btn_ValNum = new System.Windows.Forms.Button();
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.Menu_Componentes = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_CheckBox = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_CheckedListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_ComboBox = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_DateTimePicker = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_LinkLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_ListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_ListView = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_MaskedTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_MonthCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_NumericUpDown = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_PictureBox = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_ProgressBar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_RadioButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_TrackBar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_TreeView = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_WebBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_SplitContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_TabControl = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_TableLayoutPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_ToolStripContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_BackgroundWork = new System.Windows.Forms.ToolStripMenuItem();
            this.Tmsi_Timer = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotificacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tsmi_Restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.Tmsi_SqlLite = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.MenuNotificacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_veiculo
            // 
            this.Tb_veiculo.Location = new System.Drawing.Point(36, 58);
            this.Tb_veiculo.Name = "Tb_veiculo";
            this.Tb_veiculo.Size = new System.Drawing.Size(170, 23);
            this.Tb_veiculo.TabIndex = 1;
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.Location = new System.Drawing.Point(212, 57);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Adicionar.TabIndex = 3;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = true;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um veiculo";
            // 
            // Tb_Veiculos
            // 
            this.Tb_Veiculos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tb_Veiculos.Location = new System.Drawing.Point(36, 87);
            this.Tb_Veiculos.Multiline = true;
            this.Tb_Veiculos.Name = "Tb_Veiculos";
            this.Tb_Veiculos.ReadOnly = true;
            this.Tb_Veiculos.Size = new System.Drawing.Size(251, 211);
            this.Tb_Veiculos.TabIndex = 2;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(36, 304);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(250, 27);
            this.Btn_Limpar.TabIndex = 4;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(36, 336);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(250, 23);
            this.Btn_Mostrar.TabIndex = 5;
            this.Btn_Mostrar.Text = "Mostrar Veiculos";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // Btn_ValNum
            // 
            this.Btn_ValNum.Location = new System.Drawing.Point(36, 366);
            this.Btn_ValNum.Name = "Btn_ValNum";
            this.Btn_ValNum.Size = new System.Drawing.Size(250, 23);
            this.Btn_ValNum.TabIndex = 6;
            this.Btn_ValNum.Text = "Valor da variavel num";
            this.Btn_ValNum.UseVisualStyleBackColor = true;
            this.Btn_ValNum.Click += new System.EventHandler(this.Btn_ValNum_Click);
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Componentes});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(334, 24);
            this.MenuPrincipal.TabIndex = 7;
            this.MenuPrincipal.Text = "Menu Principal";
            // 
            // Menu_Componentes
            // 
            this.Menu_Componentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenu_CheckBox,
            this.SubMenu_CheckedListBox,
            this.SubMenu_ComboBox,
            this.SubMenu_DateTimePicker,
            this.SubMenu_LinkLabel,
            this.SubMenu_ListBox,
            this.SubMenu_ListView,
            this.SubMenu_MaskedTextBox,
            this.SubMenu_MonthCalendar,
            this.Tsmi_NumericUpDown,
            this.Tsmi_PictureBox,
            this.Tsmi_ProgressBar,
            this.Tsmi_RadioButton,
            this.Tsmi_TrackBar,
            this.Tsmi_TreeView,
            this.Tsmi_WebBrowser,
            this.Tsmi_SplitContainer,
            this.Tsmi_TabControl,
            this.Tsmi_TableLayoutPanel,
            this.Tsmi_ToolStripContainer,
            this.Tsmi_BackgroundWork,
            this.Tmsi_Timer,
            this.Tmsi_SqlLite});
            this.Menu_Componentes.Name = "Menu_Componentes";
            this.Menu_Componentes.Size = new System.Drawing.Size(94, 20);
            this.Menu_Componentes.Text = "Componentes";
            // 
            // SubMenu_CheckBox
            // 
            this.SubMenu_CheckBox.Name = "SubMenu_CheckBox";
            this.SubMenu_CheckBox.Size = new System.Drawing.Size(178, 22);
            this.SubMenu_CheckBox.Text = "CheckBox";
            this.SubMenu_CheckBox.Click += new System.EventHandler(this.SubMenu_CheckBox_Click);
            // 
            // SubMenu_CheckedListBox
            // 
            this.SubMenu_CheckedListBox.Name = "SubMenu_CheckedListBox";
            this.SubMenu_CheckedListBox.Size = new System.Drawing.Size(178, 22);
            this.SubMenu_CheckedListBox.Text = "CheckedListBox";
            this.SubMenu_CheckedListBox.Click += new System.EventHandler(this.SubMenu_CheckedListBox_Click);
            // 
            // SubMenu_ComboBox
            // 
            this.SubMenu_ComboBox.Name = "SubMenu_ComboBox";
            this.SubMenu_ComboBox.Size = new System.Drawing.Size(178, 22);
            this.SubMenu_ComboBox.Text = "Combo Box";
            this.SubMenu_ComboBox.Click += new System.EventHandler(this.SubMenu_ComboBox_Click);
            // 
            // SubMenu_DateTimePicker
            // 
            this.SubMenu_DateTimePicker.Name = "SubMenu_DateTimePicker";
            this.SubMenu_DateTimePicker.Size = new System.Drawing.Size(178, 22);
            this.SubMenu_DateTimePicker.Text = "Date Time Picker";
            this.SubMenu_DateTimePicker.Click += new System.EventHandler(this.SubMenu_DateTimePicker_Click);
            // 
            // SubMenu_LinkLabel
            // 
            this.SubMenu_LinkLabel.Name = "SubMenu_LinkLabel";
            this.SubMenu_LinkLabel.Size = new System.Drawing.Size(178, 22);
            this.SubMenu_LinkLabel.Text = "Link Label";
            this.SubMenu_LinkLabel.Click += new System.EventHandler(this.SubMenu_LinkLabel_Click);
            // 
            // SubMenu_ListBox
            // 
            this.SubMenu_ListBox.Name = "SubMenu_ListBox";
            this.SubMenu_ListBox.Size = new System.Drawing.Size(178, 22);
            this.SubMenu_ListBox.Text = "List Box";
            this.SubMenu_ListBox.Click += new System.EventHandler(this.SubMenu_ListBox_Click);
            // 
            // SubMenu_ListView
            // 
            this.SubMenu_ListView.Name = "SubMenu_ListView";
            this.SubMenu_ListView.Size = new System.Drawing.Size(178, 22);
            this.SubMenu_ListView.Text = "List View";
            this.SubMenu_ListView.Click += new System.EventHandler(this.SubMenu_ListView_Click);
            // 
            // SubMenu_MaskedTextBox
            // 
            this.SubMenu_MaskedTextBox.Name = "SubMenu_MaskedTextBox";
            this.SubMenu_MaskedTextBox.Size = new System.Drawing.Size(178, 22);
            this.SubMenu_MaskedTextBox.Text = "Masked Text Box";
            this.SubMenu_MaskedTextBox.Click += new System.EventHandler(this.SubMenu_MaskedTextBox_Click);
            // 
            // SubMenu_MonthCalendar
            // 
            this.SubMenu_MonthCalendar.Name = "SubMenu_MonthCalendar";
            this.SubMenu_MonthCalendar.Size = new System.Drawing.Size(178, 22);
            this.SubMenu_MonthCalendar.Text = "Month Calendar";
            this.SubMenu_MonthCalendar.Click += new System.EventHandler(this.SubMenu_MonthCalendar_Click);
            // 
            // Tsmi_NumericUpDown
            // 
            this.Tsmi_NumericUpDown.Name = "Tsmi_NumericUpDown";
            this.Tsmi_NumericUpDown.Size = new System.Drawing.Size(178, 22);
            this.Tsmi_NumericUpDown.Text = "Numeric Up Down";
            this.Tsmi_NumericUpDown.Click += new System.EventHandler(this.Tsmi_NumericUpDown_Click);
            // 
            // Tsmi_PictureBox
            // 
            this.Tsmi_PictureBox.Name = "Tsmi_PictureBox";
            this.Tsmi_PictureBox.Size = new System.Drawing.Size(178, 22);
            this.Tsmi_PictureBox.Text = "Picture Box";
            this.Tsmi_PictureBox.Click += new System.EventHandler(this.Tsmi_PictureBox_Click);
            // 
            // Tsmi_ProgressBar
            // 
            this.Tsmi_ProgressBar.Name = "Tsmi_ProgressBar";
            this.Tsmi_ProgressBar.Size = new System.Drawing.Size(178, 22);
            this.Tsmi_ProgressBar.Text = "Progress Bar";
            this.Tsmi_ProgressBar.Click += new System.EventHandler(this.Tsmi_ProgressBar_Click);
            // 
            // Tsmi_RadioButton
            // 
            this.Tsmi_RadioButton.Name = "Tsmi_RadioButton";
            this.Tsmi_RadioButton.Size = new System.Drawing.Size(178, 22);
            this.Tsmi_RadioButton.Text = "Radio Button";
            this.Tsmi_RadioButton.Click += new System.EventHandler(this.Tsmi_RadioButton_Click);
            // 
            // Tsmi_TrackBar
            // 
            this.Tsmi_TrackBar.Name = "Tsmi_TrackBar";
            this.Tsmi_TrackBar.Size = new System.Drawing.Size(178, 22);
            this.Tsmi_TrackBar.Text = "TrackBar";
            this.Tsmi_TrackBar.Click += new System.EventHandler(this.Tsmi_TrackBar_Click);
            // 
            // Tsmi_TreeView
            // 
            this.Tsmi_TreeView.Name = "Tsmi_TreeView";
            this.Tsmi_TreeView.Size = new System.Drawing.Size(178, 22);
            this.Tsmi_TreeView.Text = "Tree View";
            this.Tsmi_TreeView.Click += new System.EventHandler(this.Tsmi_TreeView_Click);
            // 
            // Tsmi_WebBrowser
            // 
            this.Tsmi_WebBrowser.Name = "Tsmi_WebBrowser";
            this.Tsmi_WebBrowser.Size = new System.Drawing.Size(178, 22);
            this.Tsmi_WebBrowser.Text = "Web Browser";
            this.Tsmi_WebBrowser.Click += new System.EventHandler(this.Tsmi_WebBrowser_Click);
            // 
            // Tsmi_SplitContainer
            // 
            this.Tsmi_SplitContainer.Name = "Tsmi_SplitContainer";
            this.Tsmi_SplitContainer.Size = new System.Drawing.Size(178, 22);
            this.Tsmi_SplitContainer.Text = "Split Container";
            this.Tsmi_SplitContainer.Click += new System.EventHandler(this.Tsmi_SplitContainer_Click);
            // 
            // Tsmi_TabControl
            // 
            this.Tsmi_TabControl.Name = "Tsmi_TabControl";
            this.Tsmi_TabControl.Size = new System.Drawing.Size(178, 22);
            this.Tsmi_TabControl.Text = "Tab Control";
            this.Tsmi_TabControl.Click += new System.EventHandler(this.Tsmi_TabControl_Click);
            // 
            // Tsmi_TableLayoutPanel
            // 
            this.Tsmi_TableLayoutPanel.Name = "Tsmi_TableLayoutPanel";
            this.Tsmi_TableLayoutPanel.Size = new System.Drawing.Size(178, 22);
            this.Tsmi_TableLayoutPanel.Text = "Table Layout Panel";
            this.Tsmi_TableLayoutPanel.Click += new System.EventHandler(this.Tsmi_TableLayoutPanel_Click);
            // 
            // Tsmi_ToolStripContainer
            // 
            this.Tsmi_ToolStripContainer.Name = "Tsmi_ToolStripContainer";
            this.Tsmi_ToolStripContainer.Size = new System.Drawing.Size(178, 22);
            this.Tsmi_ToolStripContainer.Text = "Tool Strip Container";
            this.Tsmi_ToolStripContainer.Click += new System.EventHandler(this.Tsmi_ToolStripContainer_Click);
            // 
            // Tsmi_BackgroundWork
            // 
            this.Tsmi_BackgroundWork.Name = "Tsmi_BackgroundWork";
            this.Tsmi_BackgroundWork.Size = new System.Drawing.Size(178, 22);
            this.Tsmi_BackgroundWork.Text = "Background Work";
            this.Tsmi_BackgroundWork.Click += new System.EventHandler(this.Tsmi_BackgroundWork_Click);
            // 
            // Tmsi_Timer
            // 
            this.Tmsi_Timer.Name = "Tmsi_Timer";
            this.Tmsi_Timer.Size = new System.Drawing.Size(178, 22);
            this.Tmsi_Timer.Text = "Timer";
            this.Tmsi_Timer.Click += new System.EventHandler(this.Tmsi_Timer_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuNotificacoes;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CFB Cursos";
            this.notifyIcon1.Visible = true;
            // 
            // MenuNotificacoes
            // 
            this.MenuNotificacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Restaurar,
            this.Tsmi_Mensagem,
            this.Tsmi_Fechar});
            this.MenuNotificacoes.Name = "contextMenuStrip1";
            this.MenuNotificacoes.Size = new System.Drawing.Size(134, 70);
            this.MenuNotificacoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotificacoes_ItemClicked);
            // 
            // Tsmi_Restaurar
            // 
            this.Tsmi_Restaurar.Name = "Tsmi_Restaurar";
            this.Tsmi_Restaurar.Size = new System.Drawing.Size(133, 22);
            this.Tsmi_Restaurar.Text = "Restaurar";
            // 
            // Tsmi_Mensagem
            // 
            this.Tsmi_Mensagem.Name = "Tsmi_Mensagem";
            this.Tsmi_Mensagem.Size = new System.Drawing.Size(133, 22);
            this.Tsmi_Mensagem.Text = "Mensagem";
            // 
            // Tsmi_Fechar
            // 
            this.Tsmi_Fechar.Name = "Tsmi_Fechar";
            this.Tsmi_Fechar.Size = new System.Drawing.Size(133, 22);
            this.Tsmi_Fechar.Text = "Fechar";
            // 
            // Tmsi_SqlLite
            // 
            this.Tmsi_SqlLite.Name = "Tmsi_SqlLite";
            this.Tmsi_SqlLite.Size = new System.Drawing.Size(178, 22);
            this.Tmsi_SqlLite.Text = "Sql Lite";
            this.Tmsi_SqlLite.Click += new System.EventHandler(this.Tmsi_SqlLite_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 408);
            this.Controls.Add(this.Btn_ValNum);
            this.Controls.Add(this.Btn_Mostrar);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Tb_Veiculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Adicionar);
            this.Controls.Add(this.Tb_veiculo);
            this.Controls.Add(this.MenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes - CFB - Cursos";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.MenuNotificacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_veiculo;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button Btn_Mostrar;
        private System.Windows.Forms.Button Btn_ValNum;
        public System.Windows.Forms.TextBox Tb_Veiculos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem Menu_Componentes;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_CheckBox;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_CheckedListBox;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_ComboBox;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_DateTimePicker;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_LinkLabel;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_ListBox;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_ListView;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_MaskedTextBox;
        private System.Windows.Forms.ToolStripMenuItem SubMenu_MonthCalendar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip MenuNotificacoes;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Restaurar;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Mensagem;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Fechar;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_NumericUpDown;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_PictureBox;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_ProgressBar;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_RadioButton;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_TrackBar;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_TreeView;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_WebBrowser;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_SplitContainer;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_TabControl;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_TableLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_ToolStripContainer;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_BackgroundWork;
        private System.Windows.Forms.ToolStripMenuItem Tmsi_Timer;
        private System.Windows.Forms.ToolStripMenuItem Tmsi_SqlLite;
    }
}

