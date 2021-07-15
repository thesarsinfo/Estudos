using System;

/*
Delegates é um OBJETO que faz referencia a um ou mais metodo static dentro da classe. Pega o ponto de endereço
do metodo parece util para agrupar metodos porem devem ter o mesmo numeros de parametros entao.
*/
namespace Aula50._02_Iniciante_Parte2
{
    delegate int Operacao(params int[] n);
    class Matematica
    {
        public static int resultado;
        public Matematica()
        {
            resultado = 0;
        }
        public static int soma(params int[] n)
        {
            resultado = 0;
            for (int i = 0; i < n.Length; i++)
            {
                resultado += n[i];
            }
            return resultado;
        }
        public static int dobro(params int[] n)
        {
            return n[0] * 2;
        }
        public static int multi(params int[] n)
        {
            resultado = 1;
            for (int i = 0; i < n.Length; i++)
            {
                resultado *= n[i];
            }
            return resultado;
        }
    }
    class Aula50
    {
        static void Main()
        {    
            int resultado;
            Operacao d1 = new Operacao(Matematica.soma);
            resultado = d1(10 ,10);
            Console.WriteLine("Soma: {0}", resultado);

            d1 = new Operacao(Matematica.multi);
            resultado = d1(10,10);
            Console.WriteLine("Multiplicacao: {0}", resultado);
        }
    }
}