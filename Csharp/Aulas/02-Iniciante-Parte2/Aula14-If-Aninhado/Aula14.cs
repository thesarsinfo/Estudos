using System;

namespace Aula00._02_Iniciante_Parte2
{
    class Program
    {
        static void Main()
        {   
            string resultado;
           int n1,n2,n3,n4, nota;
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
               resultado = (nota >= 95) ?  "Aprovado com louvor" :  "Aprovado" ;    
            } else  
            {                
               resultado = ( nota >= 40) ?  " Recuperação" :  "Reprovado";
            } 
            
           Console.WriteLine("Resultado: {0} nota: {1}",resultado, nota);           
           
        }
    }
}