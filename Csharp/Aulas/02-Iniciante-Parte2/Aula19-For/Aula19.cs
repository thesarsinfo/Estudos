using System.Globalization;
using System;
using System.Collections;

namespace Aula19._02_Iniciante_Parte2
{
    class Aula19
    {
        static void Main()
        {        
         /* for (inicializardor de variavel de escopo local, condição, contador)
         {
             code
         }
         */   
            int i , x; 
            int[] num = new int[10];        
            for (i = 0 , x =  0; i < num.Length ; i++, x += 2) // num.metodo lenght previne o tamanho ultrapasse o 
            //limite da matriz
            {
                Console.WriteLine("Saraiva Estudos");
                num[i] = x;
            Console.WriteLine("O valor de x: {0} na posição {1} e o valor de  num = {2}:  ",x,i,num[i]);
            }
        }
    }
}