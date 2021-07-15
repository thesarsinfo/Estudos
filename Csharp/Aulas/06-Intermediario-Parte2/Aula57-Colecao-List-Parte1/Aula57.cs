using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Lifetime;
/*
Substitui um array de forma mais moderno e dinamico e tunado.
*/
namespace Aula57._02_Iniciante_Parte2
{
    class Aula57
    {
        static void Main()
        {  
            // Declaração      
            List<string> carros = new List<string>();
            List<string> carros2 = new List<string>();
            string[] carros3 = new string[6];
            //Para adicionar itens
            carros.Add("Golf");
            carros.Add("HRV");
            carros.Add("Focus");
            carros.Add("Argo");

            //Metodos para adionar um range ou uma lista
            carros2.AddRange(carros);
            //Verificar se existe um elemento na lista
            if(carros.Contains("Golf"))
            {
                Console.WriteLine("O elemento esta na lista");
            }
            else
            {
                Console.WriteLine("Não encontrado");
            }
            //Metodo copyto serve para copiar a partir de um elemento
            //O que queremos copiar deve ser obrigatoriamente um array como no exemplo de carros3
            carros.CopyTo(carros3,2);

            //Listar a lista
            foreach (string car in carros3)
            {
                Console.WriteLine("Carro: {0}", car );
            }
            
            // Retorna o index de um valor da lista.
            foreach (string car in carros)
            {
                Console.WriteLine("Carro: {0}", car );
            }
            string carr = "HRV";
            int pos = 0;
            pos = carros.IndexOf(carr);//podemos usar o valor diretamente.            
            Console.WriteLine("Carro {0} esta na posição {1}",carr,pos);//Retorna o indice

            //Limpar uma lista
            carros.Clear();
        }
    }
}