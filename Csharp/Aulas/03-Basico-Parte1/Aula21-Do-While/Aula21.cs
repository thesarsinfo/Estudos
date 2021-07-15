using System;

namespace Aula00._02_Iniciante_Parte2
{
    class Program
    {
        static void Main()
        {  
            string senha="123";
            string senhauser;
            int tentativas = 0;              
         
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha");
                senhauser = Console.ReadLine();
                tentativas++;

            } while (senha != senhauser );          
            Console.Clear();
            Console.WriteLine("Senha Correta, tentativas:{0}", tentativas);


        }
    }
}