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
     * AUla 93 Split cotainer
     * Serve para organizar a visualização do programa
     * Propriedadades
     * Layout -> fixed Panel o painel não muda de tamanho se a janela for redimencionada.
     *  Layout -> isfixedPanel permite se pode ou não redimencionar o painel
     *  Layout -> SplitterWidth define a distancia do separador.
     *  Comportamento -> Orientation coloca o painel de forma vertical ou horinzontal
     * */
    public partial class Fm_SplitContainer : Form
    {
        public Fm_SplitContainer()
        {
            InitializeComponent();
        }
    }
}
