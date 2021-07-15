using System;
using System.Collections.Generic;
/*
Dicionary serve para coleção de dados com chave e valor
*/

namespace Aula55._02_Iniciante_Parte2
{
    class Aula55
    {
        static void Main()
        {  
            //Dicionary é uma classe de chave e valor parecido com objeto em javascript
            //O modo de faze-lo é parecido com uma declaração de uma classe e adiciona metodos      
            Dictionary<int,string> veiculos = new Dictionary<int, string>();
            veiculos.Add(10,"Carro");
            veiculos.Add(5,"Aviao");
            veiculos.Add(0,"Navio");
            veiculos.Add(20,"Moto");
            veiculos.Add(15,"Patinete");
            int chave = 20;
            veiculos.Remove(20);
            veiculos[15] = "Bicicleta"; //Altera o valor da coleção
            //imprimir todos os valores do dicionario

            foreach(KeyValuePair<int,string> v in veiculos)//Temos que usar o objeto KEYValuePair
            {
                Console.WriteLine("O valor da chave {0} e o seu valor {1}", v.Key, v.Value);
            }
            //Outra forma de imprimir mais complexa;
            Dictionary<int,String>.ValueCollection valores = veiculos.Values;
            foreach (string v in valores)
            {
                Console.WriteLine(v);//So imprime os valores
            }

            if (veiculos.ContainsKey(chave)) //removi antes co metodo remove
            {
                Console.WriteLine("A Chave exite no dicionario");
            }
            else
            {
                Console.WriteLine("A Chave não exite no dicionario");
            }
            string valor = "Bicicleta"; //sense case positive
             if (veiculos.ContainsValue(valor)) //sense case positive
            {
                Console.WriteLine("A Chave {0} exite no dicionario",valor);
            }
            else
            {
                Console.WriteLine("A Chave {0} não exite no dicionario", valor);
            }

            
            
            Console.WriteLine("Tamanho do Dicionary: {0}", veiculos.Count);//Retorna um int e seu tamanho Count é uma propriedade e nao metodo
            
            Console.WriteLine("Tamanho do Dicionary: {0}", veiculos.Count);//Count é uma propriedade e nao metodo
            
            Console.WriteLine("Tamanho do Dicionary: {0}", veiculos.Count);//Count é uma propriedade e nao metodo
            veiculos.Clear(); //Limpa o dicionary
            Console.WriteLine("Tamanho do Dicionary: {0}", veiculos.Count);//Count é uma propriedade e nao metodo



        }
    }
}