using System;

namespace Aula01
{
    class Program
    {
        static void Main()
        {
           //Se(E_L){}
           // Operadores de condionais > < >= <= == !=
           // 10 < 5 = False
           // 10 > 5 = True
           int nota = 80;
           string resultado = "reprovado";
           if (nota >= 60)
           {
               resultado = "Aprovado";             
           }
           Console.WriteLine("Resultado: {0}",resultado);

           // Parte 2
           resultado = "reprovado";
            Console.WriteLine("Digite a nota");
           nota = int.Parse(Console.ReadLine());
            if (nota >= 60)
           {
               resultado = "Aprovado";             
           }
           Console.WriteLine("Resultado: {0}",resultado);
           // Profe se empogou
           int n1,n2,n3,n4;
           n1=n2=n3=n4=0;
           resultado = "reprovado";
           Console.WriteLine("Digite a nota 1");
            n1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite a nota 2");
            n2 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite a nota 3");
            n3 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite a nota 4");
            n4 = int.Parse(Console.ReadLine());
            nota = 0;
            nota = n1 + n2 + n3 + n4;
              if (nota >= 60)
           {
               resultado = "Aprovado";             
           }
           Console.WriteLine("Resultado: {0} nota: {1}",resultado, nota);

        }
    }
}