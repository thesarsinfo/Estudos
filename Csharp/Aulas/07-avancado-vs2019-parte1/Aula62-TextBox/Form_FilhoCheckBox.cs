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
 Aula 67
 A ideia é associar o formulario pai checked box ao filho que é esse em tudo que foi marcado
se alterar valores do pai altera do filho e vice e versa, podemos usar variaveis ou parametros mas 
vamos usar o openform
Para isso o componentes do pai deve ser publicos na propriedade.
No form pai criamos um botao para ativar os elementos.
 */

namespace Aula62_TextBox
{
    public partial class Form_FilhoCheckBox : Form
    {
        public Form_CheckBox form_CheckBox;
        public Form_FilhoCheckBox()
        {
            InitializeComponent();
            //Controle que verifica se o  formulario filho  esta aberto para evitar erros ou confusao
            //de formulario
            try             
            {
                
                //O indice é o proprio formulario pai e OpenForm retorna ele e usamos a palavra chave (as) pa
                //converte a o indice em formulario.
                //form_CheckBox aponta ao formulario pai
                form_CheckBox = Application.OpenForms["Form_CheckBox"] as Form_CheckBox;
                //A ideia que um receba o outro na linha de baixo
                CB_Carro.Checked = form_CheckBox.CB_Carro.Checked;
                CB_Aviao.Checked = form_CheckBox.CB_Aviao.Checked;
                CB_Navio.Checked = form_CheckBox.CB_Navio.Checked;
                CB_Onibus.Checked = form_CheckBox.CB_Onibus.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao abri o formulario");
            }
                
        }
        //Usamos no form filho a propriedade checkedchange para alterar no form pai.
        private void CB_Carro_CheckedChanged(object sender, EventArgs e)
        {
            form_CheckBox.CB_Carro.Checked = CB_Carro.Checked;
        }

        private void CB_Onibus_CheckedChanged(object sender, EventArgs e)
        {
            form_CheckBox.CB_Onibus.Checked = CB_Onibus.Checked;
        }

        private void CB_Aviao_CheckedChanged(object sender, EventArgs e)
        {
            form_CheckBox.CB_Aviao.Checked = CB_Aviao.Checked;
        }

        private void CB_Navio_CheckedChanged(object sender, EventArgs e)
        {
            form_CheckBox.CB_Navio.Checked = CB_Navio.Checked;
        }
    }
}
