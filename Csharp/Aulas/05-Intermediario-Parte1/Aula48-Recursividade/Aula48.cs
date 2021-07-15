using System;

namespace Aula00._02_Iniciante_Parte2
{
    class Aula48
    {
        static void Main()
        {        
            Console.WriteLine(Fatorial(10));
        }
        static longint Fatorial(longint n)
        {longint  result;
            if (n < 1)
            {
                result = 1;
            }
            else
            {
                result = n * Fatorial(n -1);
            }
            return result;
        }
    }
}