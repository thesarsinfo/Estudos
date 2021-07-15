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
    public partial class Fm_MaskedTextBox : Form
    {
        /*
         * AUla 76 Masked text box ele facilita uso de mascaras no texto
         * Usamos propriedades Masked para definir telefone etc
         * https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.maskedtextbox.mask?view=net-5.0
         * propriedade PassordChar onde usamos uma Um char como mascara de senha como uso do *
         * propriedade Formatmasked para tirar pontos e - numa messagem
         */
        public Fm_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void Btn_CPF_Click(object sender, EventArgs e)
        {
            if (Cb_Mascara.Checked)
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string msg = maskedTextBox1.Text;
                //Esse masked usamo a propriedade Formatmasked
                MessageBox.Show(msg);
            }
            else
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                string msg = maskedTextBox1.Text;
                MessageBox.Show(msg);
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(Cb_RevelarSenha.Checked)
            {
                Mtb_Senha.PasswordChar = '\0';
                Mtb_Senha.Focus();
            }
            else
            {
                Mtb_Senha.PasswordChar = '*';
                Mtb_Senha.Focus();
            }

            //Altere a o comportamento a propriedade RejectInputOnFirstFalue para true

        }
    }
}
