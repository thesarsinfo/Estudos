using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
           //Aula 09 -- Operadores de bitwise
           /* 
           0000 0000 = 0
           
           << Dobrar o valor da variavel
           >> Metade do valor da variavel
           EX: 
           0000 1010 = 10
           << dobrando o valor
           0001 0100 = 20

           Ex: 2 bitwise para direita
           0000 1000 = 8
           >> metade do valor
           0000 0100 = 4
           */
           int num = 0;
           // o numero 1 é repetiçao da operação. em caso de numero impar ele usa o numero par menor 
           // E bitwise de 0 é 0
           num = num >> 1;
           Console.WriteLine(num);
        }
    }
}