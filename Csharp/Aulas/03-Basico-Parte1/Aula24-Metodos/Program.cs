using System;

namespace Aula24
{
    class Program
    {
        static void Main()
        {
            
            int v1, v2, r;
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());

            Ola(); 
            r = Soma(v1, v2);
            Console.WriteLine("A Soma de {0} e {1} é: {2}", v1,v2, r);
        }
        static void Ola()
        {
            Console.WriteLine("Saraiva Estudos");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Isso ae");

        }
        static int Soma(int n1, int n2)
        {
            int res = n1 + n2;
            return res;
            
        }
    }
}
