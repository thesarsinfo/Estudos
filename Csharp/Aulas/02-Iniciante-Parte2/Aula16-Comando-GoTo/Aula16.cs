using System;

namespace Aula00._02_Iniciante_Parte2
{
    class Program
    {
        static void Main()
        {
            int tempo = 0;
            char escolha;
            string resposta;
            inicio:;
            Console.Clear();
            Console.WriteLine("Belo Horizonte/MG a Vitória!");
            Console.WriteLine("Escolha o transporte : [a]Avião [c] Carro [o]Onibus");
            escolha = char.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 'a':
                    tempo = 50;
                    break;
                case 'c':
                    tempo = 480;
                    break;
                case 'o':
                    tempo = 660;
                    break;
                default:
                    tempo = 0;
                    break;
            }
            resposta = (tempo < 1) ? "transporte indefinido: " : "Para o transporte escolhido o tempo é de: ";            
            Console.WriteLine( resposta + "{0} minutos", tempo); 
            Console.WriteLine("Calcular outro transporte:[s/n]");
            escolha = char.Parse(Console.ReadLine());
            if (escolha == 's')
            {
                goto inicio;
            } else
            {
                Console.WriteLine("Até breve!!");
            }

        }
    }
}