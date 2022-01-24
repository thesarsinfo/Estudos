using Cadastro_Empresa.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro_Empresa.Database;
namespace Cadastro_Empresa
{
    public partial class Form_Cadastro_Empresa : Form
    {
        public Form_Cadastro_Empresa()
        {
            InitializeComponent();
        }

        private void Form_Cadastro_Empresa_Load(object sender, EventArgs e)
        {
            Cb_Estado.Items.Clear();
            Cb_Estado.Enabled = false;
            Tb_NomeFantasia.Enabled = false;
            MTb_CNPJ.Enabled = false;
            Btn_Limpar.Enabled = false;
            Btn_SalvarEmpresa.Enabled = false;
            foreach (int estado in Enum.GetValues(typeof(Estado)))  
            {                
                Cb_Estado.Items.Add((Estado)estado);                
            }            

            
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
            if(Cb_Estado.SelectedItem == null || Tb_NomeFantasia.Text == "" || MTb_CNPJ.Text == "")
            {
                MessageBox.Show("Existe algum campo não preenchido");
                
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
                string cnpj = dataTable.Rows[0].Field<string>("CNPJ");
                MessageBox.Show(cnpj);
            }
        }
    }
}
