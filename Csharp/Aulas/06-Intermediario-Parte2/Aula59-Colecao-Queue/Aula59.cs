using System;
using System.Collections.Generic;
/*
Fila Queue o primeiro a entrar e o primeiro a sair first in first out.
*/

namespace Aula59._02_Iniciante_Parte2
{
    class Aula59
    {
        static void Main()
        {        //declaracao + inicializaçao com contrutor com valores bases
            string[] vs = {"Carro","Moto","Navio"};
            Queue<string> veicu = new Queue<string>(vs);
            //Declaraçao usando o contrutor vazio
            Queue<string> veiculos = new Queue<string>();
            //Adicionado ao final da fila
            veiculos.Enqueue("Carro");//Adiciona no final da fila
            veiculos.Enqueue("Moto");
            veiculos.Enqueue("Navio");
            veiculos.Enqueue("Aviao");
            Console.WriteLine("Tamanho da fila: {0}",veiculos.Count);//Retorna um int
            //Mostra o primeiro valor e remove ele da lista
            Console.WriteLine("Primeiro Veiculo {0}", veiculos.Dequeue());
            Console.WriteLine("Tamanho da fila: {0}",veiculos.Count);//Retorna um int
            //Retorna o elemento sem removelo da fila
             Console.WriteLine("Primeiro Veiculo Metodo Peek {0}", veiculos.Peek());
            Console.WriteLine("Tamanho da fila: {0}",veiculos.Count);//Retorna um int
            Console.WriteLine("Veiculo:=========================== ");
            //Valores das fila sem removelos
            foreach (string item in veiculos)
            {
                Console.WriteLine("Veiculo: " + item);
               // item = veiculos.Dequeue();
            }
            Console.WriteLine("Tamanho da fila: {0}",veiculos.Count);//Retorna um int
            //Não é possivel indexar do tipo array na fila >> veiculos[0]



            string verifica = "Aviao";
            if(veiculos.Contains(verifica))
            {
            Console.WriteLine("Veiculo da fila encotrado: {0}",verifica);                
            }
            else
            {
            Console.WriteLine("Veiculo da fila não encotrado: {0}",verifica);
            }
            Console.WriteLine("Primeiro Veiculo {0}", veiculos.Dequeue());

            //Removendo os valores da fila
            while(veiculos.Count > 0)
            {
                Console.WriteLine(veiculos.Dequeue());
            }
            veiculos.Clear();//Limpa a fila;
            Console.WriteLine("Tamanho da fila: {0}",veiculos.Count);//Retorna um int


        }
    }
}