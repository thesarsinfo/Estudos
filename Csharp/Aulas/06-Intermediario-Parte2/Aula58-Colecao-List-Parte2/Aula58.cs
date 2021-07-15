using System;
using System.Collections.Generic;

/*
Substitui um array de forma mais moderno e dinamico e tunado.
*/
namespace Aula58._02_Iniciante_Parte2
{
    class Aula58
    {
        static void Main()
        {  
            // Declaração      
            List<string> carros = new List<string>();
            List<string> carros2 = new List<string>();
            string[] carros3 = new string[8];
            //Para adicionar itens
            carros.Add("Golf");
            carros.Add("HRV");
            carros.Add("Focus");
            carros.Add("Argo");
            carros.Add("HRV");
            //Inserir elemento em determinada posição
            carros.Insert(1,"Kombi");
            //Remover o itens
            carros.Remove("Kombi");//Temos o removeAll que remove todos.
            carros.RemoveAt(0);//Remove o golf
            //Reverve os itens da lista.
            carros.Reverse();
            //Ordenação elementos da lista
            carros.Sort();
            //Tamanho da lista.
            int tamanho = carros.Count;
            Console.WriteLine("Quantidade de Carros: {0}", tamanho);

            //Definir a capacidade da sua lista

            int capacidade = carros.Capacity;
            //Definindo a capacidade
            carros.Capacity = 15; // Se definimos um valor menor que a lista temos que tratar com try catch
            Console.WriteLine("Capacidade da Lista: {0}", capacidade);

            

            //Metodos para adionar um range ou uma lista
            carros2.AddRange(carros);//Copia a lista carro
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
            Console.WriteLine("===========================");
            // Retorna o index de o primeiro achado valor da lista.
            foreach (string car in carros)
            {
                Console.WriteLine("Carro: {0}", car );
            }
            string carr = "HRV";
            int pos = 0;
            pos = carros.IndexOf(carr);//podemos usar o valor diretamente.            
            Console.WriteLine("Carro {0} esta na posição {1}",carr,pos);//Retorna o primeiro indice
            pos = carros.LastIndexOf(carr);//podemos usar o valor diretamente.            
            Console.WriteLine("Ultimo {0} esta na posição {1}",carr,pos);//Retorna o ultimo indice

            //Limpar uma lista
            carros.Clear();
        }
    }
}