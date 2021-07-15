using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// import para usar banco de dados
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Saraiva_Academia
{
    class Banco
    {
        private static SQLiteConnection conexao;
        /*
         *  Campos da tb_usuario
        N_Id_Usuario,
        T_Nome_Usuario,
        T_Username,
        T_Senha,
        T_Situacao_Usuario,
        N_Nivel_Usuario
         */

        private static SQLiteConnection ConexaoBanco()
        {
            //Aula 111 modificamos para um camino relativo do banco de dados
            conexao = new SQLiteConnection("Data Source=" +Globais.caminhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }
        /// ////////////////
        /// ///////////////
        /// //FUNÇÕES GENERICAS
        public static DataTable Dql(string sql) //Data Query Language dql (Select)
        {
            SQLiteDataAdapter dataAdapter = null; // data adapter
            DataTable dataTable = new DataTable();
            try
            {
                var verificaConexao = ConexaoBanco();
                var comand = verificaConexao.CreateCommand();
                comand.CommandText = sql;
                dataAdapter = new SQLiteDataAdapter(comand.CommandText, verificaConexao);
                dataAdapter.Fill(dataTable); //preenche as informações capturadas para o dataTable;
                verificaConexao.Close();
                return dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Dml(string query, string msgOk = null, string msgError = null) //Data Manipulation Language(insert, Delete update
        {

            SQLiteDataAdapter dataAdapter = null; // data adapter
            DataTable dataTable = new DataTable();
            try
            {
                var verificaConexao = ConexaoBanco();
                var comand = verificaConexao.CreateCommand();
                comand.CommandText = query;
                dataAdapter = new SQLiteDataAdapter(comand.CommandText, verificaConexao);
                comand.ExecuteNonQuery();
                //Obs Aula 109 Não se usa fill em update
                verificaConexao.Close();//nunca deixe uma conexão aberta
                if (msgOk != null) //usuario entrou com uma mensagem
                {
                    MessageBox.Show(msgOk);
                }

            }
            catch (Exception ex)
            {
                if(msgError != null)
                {
                    MessageBox.Show(msgError + "\n" + ex.Message);
                }
                throw ex;
            }
        }

        public static DataTable ObterTodosUsuarios()
        {
            /*
             Aula 102 -- Vamos criar um data adapter e data table
            vamos fazer uma consulta de todos usuarios e retorna todos usuário em datatable
            para consultar vamos criar um ocmmand usando sql e passar para um data adapter e preenche o
            datatable com infomações
             */
            /*
             * Aula 108 Vamos atulizar todos os metodos para ter a sua propria conexao deixando o codigo mais 
             * legigel e tirar as conexões abertas no cacth
             */
            SQLiteDataAdapter dataAdapter = null; // data adapter
            DataTable dataTable = new DataTable();
            try
            {
                var verificaConexao = ConexaoBanco();
                var comand = verificaConexao.CreateCommand();                
                comand.CommandText = "SELECT * FROM tb_usuarios";
                dataAdapter = new SQLiteDataAdapter(comand.CommandText, verificaConexao);
                dataAdapter.Fill(dataTable); //preenche as informações capturadas para o dataTable;
                verificaConexao.Close();//nunca deixe uma conexão aberta
                return dataTable;
                
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
        
        /*
         * Funções do Form F_NovoUsuario
         *
         */
        public static void NovoUsuario(Usuario usuario)
        {
            /*Aula 106 Configuramos o campo username como unique e faremos as tratativas atraves do try catch
             * Assim não há replicação de usernames
             * passando a classe usuario como parametros para poder usar depois para usar no insert
             */
            if(ExisteUsername(usuario))
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var verificaConexao = ConexaoBanco();
                var comand = verificaConexao.CreateCommand();                
                comand.CommandText = "INSERT INTO tb_Usuarios (T_Nome_Usuario, T_Username, T_Senha, T_Situacao_Usuario, N_Nivel_Usuario) VALUES (@nome, @username, @senha, @status,@nivel)";
                comand.Parameters.AddWithValue("@nome", usuario.T_Nome_Usuario);
                comand.Parameters.AddWithValue("@username", usuario.T_Username);
                comand.Parameters.AddWithValue("@senha", usuario.T_Senha);
                comand.Parameters.AddWithValue("@status", usuario.T_Situacao_Usuario);
                comand.Parameters.AddWithValue("@nivel", usuario.N_Nivel_Usuario);
                comand.ExecuteNonQuery();
                MessageBox.Show("Novo usuario inserido com sucesso");
                verificaConexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuario" );                
            }
        }


        // Fim da funções

        /* FUNÇOES PARA O F_GESTAOUSUARIOS
         * 
         */
        public static DataTable ObterUsuariosIdNome()
        {
            
            SQLiteDataAdapter dataAdapter = null; // data adapter
            DataTable dataTable = new DataTable();
            try
            {
                var verificaConexao = ConexaoBanco();
                var comand = verificaConexao.CreateCommand();
                comand.CommandText = "SELECT N_Id_Usuario as 'ID do Usuário', T_Nome_Usuario as 'Nome do usuário' FROM tb_usuarios";
                dataAdapter = new SQLiteDataAdapter(comand.CommandText, verificaConexao);
                dataAdapter.Fill(dataTable); //preenche as informações capturadas para o dataTable;
                verificaConexao.Close();//nunca deixe uma conexão aberta
                return dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ObterDadosUsuarios(string id)
        {

            SQLiteDataAdapter dataAdapter = null; // data adapter
            DataTable dataTable = new DataTable();
            try
            {
                var verificaConexao = ConexaoBanco();
                var comand = verificaConexao.CreateCommand();
                comand.CommandText = "SELECT * FROM tb_usuarios WHERE N_Id_Usuario=" + id ;
                dataAdapter = new SQLiteDataAdapter(comand.CommandText, verificaConexao);
                dataAdapter.Fill(dataTable); //preenche as informações capturadas para o dataTable;
                verificaConexao.Close();//nunca deixe uma conexão aberta
                return dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void AtualizarUsuario(Usuario usuario)//Update não prescisa retorna valores
        {

            SQLiteDataAdapter dataAdapter = null; // data adapter
            DataTable dataTable = new DataTable();
            try
            {
                var verificaConexao = ConexaoBanco();
                var comand = verificaConexao.CreateCommand();
                comand.CommandText = "UPDATE tb_usuarios SET T_Nome_Usuario='" + usuario.T_Nome_Usuario + "',T_Username='" + usuario.T_Username + "',T_Senha='" + usuario.T_Senha + "',T_Situacao_Usuario='" + usuario.T_Situacao_Usuario + "', N_Nivel_Usuario=" + usuario.N_Nivel_Usuario + " WHERE N_Id_Usuario=" + usuario.N_Id_Usuario;
                dataAdapter = new SQLiteDataAdapter(comand.CommandText, verificaConexao);
                comand.ExecuteNonQuery();
                //Obs Aula 109 Não se usa fill em update
                verificaConexao.Close();//nunca deixe uma conexão aberta                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ExcluirUsuario(string id)//Update não prescisa retorna valores
        {

            SQLiteDataAdapter dataAdapter = null; // data adapter
            DataTable dataTable = new DataTable();
            try
            {
                var verificaConexao = ConexaoBanco();
                var comand = verificaConexao.CreateCommand();
                comand.CommandText = "Delete FROM tb_usuarios WHERE N_Id_Usuario=" + id;
                dataAdapter = new SQLiteDataAdapter(comand.CommandText, verificaConexao);
                comand.ExecuteNonQuery();
                //Obs Aula 109 Não se usa fill em update
                verificaConexao.Close();//nunca deixe uma conexão aberta                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Fim das funções
        //Rotinas Gerais 
        public static bool ExisteUsername(Usuario usuario)
        {
            bool resultadoConsulta;
            SQLiteDataAdapter dataAdapter = null; // data adapter
            DataTable dataTable = new DataTable();

            var verificaConexao = ConexaoBanco();
            var comand = verificaConexao.CreateCommand();
            comand.CommandText = "SELECT T_Username FROM tb_usuarios WHERE T_Username='" + usuario.T_Username + "'";
            dataAdapter = new SQLiteDataAdapter(comand.CommandText, verificaConexao);//Passamos a query e a conexao
            dataAdapter.Fill(dataTable);
            resultadoConsulta = (dataTable.Rows.Count > 0) ? true : false;
            verificaConexao.Close();
            return resultadoConsulta ;
        }

    }
}
   
