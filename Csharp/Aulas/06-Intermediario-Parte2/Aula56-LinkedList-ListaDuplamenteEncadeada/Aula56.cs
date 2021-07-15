using System;
using System.Collections.Generic;//Trabalhador com lista
/*
Lista duplumenta encadiada e uma lista onde cada nó se conecta com anterior e o posterior.
*/
namespace Aula56._02_Iniciante_Parte2
{
    class Aula56
    {
        static void Main()
        {   
          // Tipo de Lista <tipo de dado> nome da lista = new Tipo de lista chamando seu contrutor.     
            LinkedList<string> transporte = new LinkedList<string>();
            transporte.AddFirst("Carro");
            transporte.AddFirst("Aviao");
            transporte.AddFirst("Navio");
            transporte.AddFirst("Motocicleta");
            
            transporte.AddLast("Bicicleta");

            LinkedListNode<string> noh; //nosso especie de iterator
            noh = transporte.FindLast("Navio").Next;//Aponta para o proximo de navio
            transporte.AddAfter(noh,"Patinete"); //Adiciona apos mas colocamos um iterator find last.
            noh = transporte.FindLast("Carro");//alteramos o valor do iterator
            transporte.AddBefore(noh,"Patins");

             //Para remover um elemento
            transporte.Remove("Navio");//sensecasitive
            transporte.RemoveFirst();//Remove o primero
            transporte.RemoveLast();///

            foreach (string item in transporte)
            {
                Console.WriteLine("Transporte: {0} ", item);
            }
            if(transporte.Find("Carro")==null)
            {
                Console.WriteLine("Elemento não encontrado");
            }
            else
            {
                Console.WriteLine("Elemento encontrado");                
            }
           

            transporte.Clear(); //Elimina todos os elementos

        }
    }
}