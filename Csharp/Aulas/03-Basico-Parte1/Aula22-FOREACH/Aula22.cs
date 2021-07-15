// Aula 22
using System;

namespace Aula00._02_Iniciante_Parte2
{
    class Program
    {
        static void Main()
        {        
              //Foreach usado para ler somente array e não para adicionas
              int[] num = new int[5]{11,22,33,44,55};

              for (int i = 0; i < num.Length; i++)
              {
                  Console.WriteLine(num[i]);
              }
              // o int n é do mesmo tipo da coleçao num que é int
              foreach (int n in num)
              {
                  Console.WriteLine(n);
              }         
        }
    }
}