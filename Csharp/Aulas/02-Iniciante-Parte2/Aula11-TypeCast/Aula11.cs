using System;

namespace Aula01
{
    class Program
    {
        static void Main()
        {
           //Aula 11 -- Operações de typecast converter elementos.
           int n1 = 10;
           // Conversao segura e conversao expçicita
           float n2 = n1;
           Console.WriteLine(n2);
           // Operaçao inversa
           float n3 = 10.5f;
           //int n4 = n3;
           //Não é possível converter implicitamente o tipo 'float' em 'int'.
           // Existe uma conversão explícita. Precisa de cast?
           int n4 = (int)n3; // operação tipo type cast
           Console.WriteLine(n4);

           int vInt = 11;
           // mesmo sendo inteiras e numericas mas short é de menor espaço
           short vShort = (short)vInt;
           Console.WriteLine(vShort);

           
        }
    }
}