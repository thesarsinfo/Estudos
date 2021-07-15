using System;

namespace Aula23._03_Basico_Parte1
{
    class Program
    {
        static void Main()
        {        
            int[] vetor1 = new int[5];               
            int[] vetor2 = new int[5];               
            int[] vetor3 = new int[5];               
            int[,] matriz = new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}}; 
            //Essa classe random serve para gerar numeros aleatorios;
            
            Random random = new Random();
            for(int i =0; i < vetor1.Length; i++)
            {
                vetor1[i] = random.Next(1,100); //Valor minimo , valor maximo
            }
            Console.WriteLine("Elementos do vetor 1");
            foreach(int j in vetor1)
            {
                Console.WriteLine(j);
            }
            
            // Metodo Binary search OBS Somente funciona se os numeros estiverem em ordem
            // public static int BinarySearch( array, valor) //retorno int
            Console.WriteLine("BinarySearch");
            int procurado = 33; //valor que quero procurar
            int pos = Array.BinarySearch(vetor1, procurado); // se Retornar negativo é que não encontrou
            Console.WriteLine("O valor {0} esta na posicao {1}",procurado,pos);
            Console.WriteLine("----------------------------------------------");

            //public static void Copy(Array_Origem, Array_Destino, quantidades de elementos);

            Console.WriteLine("CopyTo");
            Array.Copy(vetor1,vetor2,2);
            foreach(int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------------");
            //Public void CopyTo(Array_Destino, indice que começa a copia)

            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3,0);
            foreach(int n in vetor3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------------");
            //public long GetLongLength(dimensão 2[,] ou 3 [,,]ou mais);
            Console.WriteLine("GetLongLength");
            long quantidadesElementosVetor = vetor1.GetLongLength(0);
            Console.WriteLine("Quantidades de elementos {0}", quantidadesElementosVetor);
            Console.WriteLine("----------------------------------------------");
            //public int GetLowerBound(dimensão 2[,] ou 3 [,,]ou mais);
            Console.WriteLine("GetLowerBound");
            int menorIndiceVetor = vetor1.GetLowerBound(0);
            int menorIndiceMatriz_D1 = matriz.GetLowerBound(1); //no caso posso usar 0 ou 1 que refere a dimensão
            Console.WriteLine("Menor indice de vetor {0}", menorIndiceVetor);// retorna o indice
            Console.WriteLine("----------------------------------------------");
            //public int GetUpperBound(dimensão 2[,] ou 3 [,,]ou mais);
            Console.WriteLine("GetUpperBound");
            int maiorIndiceVetor = vetor1.GetUpperBound(0);
            int maiorIndiceMatriz_D1 = matriz.GetUpperBound(1); //no caso posso usar 0 ou 1 que refere a dimensão
            Console.WriteLine("Maior indice de vetor  {0}", maiorIndiceVetor); // retorna o indice
            Console.WriteLine("----------------------------------------------");
            // Public Object GetValue (long Indice);
            Console.WriteLine("GetValue");
            //Para converter objeto em int usamos o CAST Convert
            int valor0 = Convert.ToInt32(vetor1.GetValue(3));
            int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
            Console.WriteLine("O valor da posiçao 3 de vetor1  {0}", valor0); // retorna o  valor
            Console.WriteLine("----------------------------------------------");
            // Public static int IndexOf(array , valor pesquisado)
            Console.WriteLine("IndexOf");
            int indice1 = Array.IndexOf(vetor1,33); //busca lenta 0 a ultimo indice e retorna o primeiro valor achado 
            //e retorna -1 se não achar
            Console.WriteLine("Indice do primeiro valor 3:{0}" , indice1);
            Console.WriteLine("----------------------------------------------");

            // Public static int LastIndexOf(array , valor pesquisado)
            Console.WriteLine("LastIndexOf");
            int indice2 = Array.LastIndexOf(vetor1,35); //busca lenta e a busca do ultimo indice para o primeiro
            Console.WriteLine("Indice do primeiro valor 3:{0}" , indice2);
            Console.WriteLine("----------------------------------------------");
            // public static void Reverse(Array); 
            Console.WriteLine("Reverse");
            Array.Reverse(vetor1);
            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------------");
            // public void SetValue(object valor, long indice);
            Console.WriteLine("SetValue");
            vetor2.SetValue(99,0); //Setou 99 no indice 0
            Console.WriteLine("O valor de vetor 2 no indice 0 é : {0}", vetor2[0]);
            for(int i = 0; i < vetor2.Length; i++)
            {
                vetor2.SetValue(0,i);
            }
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }
            // public static void Sort(array);
            Array.Sort(vetor1);
            Array.Sort(vetor2);
            Array.Sort(vetor3);
            Console.WriteLine("Vetor 1 \n");
            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Vetor 2 \n");
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Vetor 3 \n");
            foreach (int n in vetor3)
            {
                Console.WriteLine(n);
            }



        }
    }
}