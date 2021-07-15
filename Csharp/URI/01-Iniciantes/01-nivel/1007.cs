using System;

namespace Exe1007.URI
{
    public class Exe1007
    {
        public  Exe1007()
        {
            int i;
            int[] valores = new int[4]; 
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite o {0} valor", i+1);
                valores[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("DIFERENCA = " + (valores[0] * valores[1] - valores[2] * valores[3]));
        }
    }
}