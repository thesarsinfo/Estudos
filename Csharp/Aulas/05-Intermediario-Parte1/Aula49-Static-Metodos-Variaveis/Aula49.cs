using System;
/*
Objetivo é usar diretamente o metodo ou variavel dentro da classe sem se preocupar em instanciar o objeto.
*/
namespace Aula00._02_Iniciante_Parte2
{
    class Matematica
    {
        public static double pi = 3.14159;
        public static int dobro(int n)
        {
            return n * 2;
        }
    }
    class Aula49
    {
        static void Main()
        {        
            double valorpi =  Matematica.pi;
            int num = 10;
            Console.WriteLine(Matematica.dobro(num));
            Console.WriteLine(valorpi);
        }
    }
}