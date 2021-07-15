using System;

namespace Aula07.Aulas
{
    class Aula07
    {
        static void Main()
        {
            //Aula 08 - Leitura de valores do teclado O Console.ReadLine;

            int v1,v2,soma;
            string nome;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Nome digitado: {0}", nome);
            // Existe duas formas de converter o valor;
            Console.WriteLine("Digite o primeiro número ");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número ");
            v2 = Convert.ToInt32(Console.ReadLine());

            soma = v1 + v2;

            Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1,v2,soma);


           
        }
    }
}