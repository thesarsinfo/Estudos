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
    public partial class Form_LinkLabel : Form
    {
        public Form_LinkLabel()
        {
            InitializeComponent();
            //Ao inicializar o componente carregue essas configurações.
            LL_MultiplosLinks.Links.Add(0,6,"https//www.google.com.br");//0 Representa o label Google onde 0 representa onde come
            //começa e 6 o tamanho da palavra  a ideia é uma string e ser clicavel em todos
            LL_MultiplosLinks.Links.Add(9, 5, "https//www.youtube.com.br/CFBCursos");
            LL_MultiplosLinks.Links.Add(17, 7, "https//www.youtube.com.br/");
            //para desabilitar um item
            LL_MultiplosLinks.Links[2].Enabled = false;

        }

        private void LL_Canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            System.Diagnostics.Process.Start("C:/Program Files/Firefox Developer Edition/firefox.exe", "www.youtube.com/nome=" + Tb_Nome.Text);
            LinkLabel ll = (LinkLabel)sender;
            //setando apos o clique que o link foi visitado;
            ll.LinkVisited = true;
        }

        private void LL_Calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void LL_MultiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // a variavel "e" representa a area do link que foi clicado
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            //setando para visitado 
            e.Link.Visited = true;

        }
    }
}
