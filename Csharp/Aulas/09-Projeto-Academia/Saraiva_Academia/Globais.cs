using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saraiva_Academia
{
    class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0; //1 usuario basico 2 Gerente 3 Master ou manuteção

        //Caminho para ambiente dev
        //public static string caminho = System.Environment.CurrentDirectory;

        //Caminho de ambiente Deploy
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "database_academia.db";
        public static string caminhoBanco = caminho + @"\database\";
        public static string caminhoFotos = caminho + @"\bancodefotos\";


    }
}
