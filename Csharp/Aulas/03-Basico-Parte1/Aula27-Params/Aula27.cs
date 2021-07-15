using System;

namespace Aulas
{
    class Aula27
    {
        static void Main()
        {        
            soma(1, 10, 40, 60);
        }
        static void somaa(int n1, int n2) // função indicando valores com parametros definidos
        {
            int res = n1 + n2;
            Console.WriteLine("A soma de {0} com {1} é {2}", n1,n2, res);
        }
        static void soma(params int[]n) //resolve a quantidade de params que pode entrar 0 parametros a 2 ou infinito
        //cuidado nada mostra nada, 1 mostra ele ou mais de 1 pecorre o array do parametros;
        {
            int res = 0;
            if (n.Length < 1)
            {
                Console.WriteLine("Não existem valores a serem chamados");

            }else if(n.Length < 2)
            {
                Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);

            }else
            {
                for (int i = 0 ; i < n.Length; i++)
                {
                    res += n[i];
                }
                Console.WriteLine("A soma dos valores é: {0} ", res);
            }            
        }

    }
}