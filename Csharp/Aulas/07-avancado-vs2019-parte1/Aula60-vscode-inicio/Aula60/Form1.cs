﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula60
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
        }
        private void btnEstudos_Click(object sender, EventArgs e)
        {            
            lbEstudos.Text = tbEstudos.Text;            
        }

    }
}
