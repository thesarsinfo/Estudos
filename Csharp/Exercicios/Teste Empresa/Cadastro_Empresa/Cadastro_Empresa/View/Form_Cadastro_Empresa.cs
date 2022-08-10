using Cadastro_Empresa.Properties;
using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Enumarator;

namespace Cadastro_Empresa
{
    public partial class Form_Cadastro_Empresa : Form
    {
        Business.Business business = new Business.Business();
        List<string> cadastro = new List<string>();

        public Form_Cadastro_Empresa()
        {
            InitializeComponent();
        }

        private void Form_Cadastro_Empresa_Load(object sender, EventArgs e)
        {
            //Manipulação de propriedades
            Cb_Estado.Enabled = false;
            Tb_NomeFantasia.Enabled = false;
            MTb_CNPJ.Enabled = false;
            Btn_Limpar.Enabled = false;
            Btn_SalvarEmpresa.Enabled = false;
            //Limpando e populando o itens no combobox
            Cb_Estado.Items.Clear();            
            Cb_Estado.Items.AddRange(business.GetEstado());           

                     
        }

        private void Btn_NovaEmpresa_Click(object sender, EventArgs e)
        {
            Cb_Estado.Enabled = true;
            Tb_NomeFantasia.Enabled = true;
            MTb_CNPJ.Enabled = true;
            Btn_Limpar.Enabled =true;
            Btn_SalvarEmpresa.Enabled=true;
            Btn_NovaEmpresa.Enabled = false;
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Cb_Estado.SelectedItem = null;
            Tb_NomeFantasia.Text = "";
            MTb_CNPJ.Text = "";
        }

        private void Btn_SalvarEmpresa_Click(object sender, EventArgs e)
        {
            cadastro.Clear();
            string estadoString = Cb_Estado.Text;
            string nomeFantasia = Tb_NomeFantasia.Text;
            string cnpj = MTb_CNPJ.Text;
            cadastro.AddRange(new string[] { estadoString, nomeFantasia,cnpj });

            if (Cb_Estado.SelectedItem == null || Tb_NomeFantasia.Text == "" || MTb_CNPJ.MaskCompleted == false)
            {
                MessageBox.Show("Existe algum campo não preenchido corretamente");
                
            }
            else
            {                
                string queryInsertCompany = String.Format
                (@"
                    INSERT INTO tb_empresa
                        (CNPJ,NOME_FANTASIA,UF)
                    VALUES
                        ('{0}','{1}','{2}')"
                    ,MTb_CNPJ.Text,Tb_NomeFantasia.Text, Cb_Estado.Text
                );
                string querySelectedInsertCompany = String.Format
                (@"
                    SELECT 
                        CNPJ,
                        NOME_FANTASIA,
                        UF 
                    FROM 
                        tb_empresa 
                    WHERE 
                        CNPJ = '{0}'", MTb_CNPJ.Text
                );                

                Database.DatabaseMySQL.Dml(queryInsertCompany);
                MessageBox.Show("Empresa inserida");
                DataTable dataTable = Database.DatabaseMySQL.Dql(querySelectedInsertCompany);
                cnpj = dataTable.Rows[0].Field<string>("CNPJ");
                MessageBox.Show(cnpj);
            }
        }
    }
}
