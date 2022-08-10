using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//import mysql 
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cadastro_Empresa.Database
{
    
    class DatabaseMySQL
    {       
        private static MySqlConnection databaseConnection()
        {
            
            string connection;
            connection = "server=localhost;port=3306;User Id=root;database=banco_empresa;password=b4B4D0GP0K;";
            MySqlConnection mySqlConnection = new MySqlConnection(connection);
            mySqlConnection.Open();
            return mySqlConnection;
        }
        public static  DataTable Dql(string sql)
        {            
            MySqlDataAdapter mySqlDataAdapter = null;
           DataTable dataTable = new DataTable();
            try
            {
                var verifyConnection = databaseConnection();               
                mySqlDataAdapter = new MySqlDataAdapter(sql, verifyConnection);
                mySqlDataAdapter.Fill(dataTable);                
                verifyConnection.Close();                
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static void Dml(string sql)
        {
            try
            {
                var verifyConnection = databaseConnection();
                MySqlCommand objectCommand = new MySqlCommand(sql, verifyConnection);
                objectCommand.Parameters.Clear();
                objectCommand.CommandType = CommandType.Text;
                objectCommand.ExecuteNonQuery();
                verifyConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
