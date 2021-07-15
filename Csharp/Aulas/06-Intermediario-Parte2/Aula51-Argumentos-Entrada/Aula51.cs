using System;
/*
Argumentos de entrada do Main parecido com a aula c++
*/
namespace Aula51._02_Iniciante_Parte2
{
    class Aula51
    {
        static void Main(string[] args)
        {  
            if (args.Length == 0)
            {
                Console.WriteLine("Saraiva Estudos");
                Console.WriteLine("nenhum argumentos passado");
            }      
            else if (args[0] == "-o")
            {
                Console.WriteLine("Comando certo");
            }
            else
            {
                Console.WriteLine("Comando Errado");
            }
            
        }
    }
}