using System;
namespace Aula06.Aulas
{
    public class Aula06
    {
        static void Main()
        {
            int n1, n2 ,n3;
            double buyValue = 5.50;
            double sellValue;
            double profit = 0.1;
            string product = "Pastel";
            n1 = 10; n2 = 20 ; n3 = 30;
            Console.WriteLine(n1 + ", " + n2 + "," + n3);
            // formatando ao estilo de indice;
            Console.WriteLine("\nO valor de n1 = \t{0} \nO valor de n2 = {1}\n e o valor de n3 = {2}\t\n", n1, n2, n3);
            // \n pula linha e \t tabulação 
            //Trabalhando com formatação do console
            sellValue = buyValue + (buyValue * profit);

            Console.WriteLine("Produto ......:{0,15}", product);// 15 é a tabulação e o 0 é o index coforme explicado acima
            Console.WriteLine("Valor Compra..:{0,15:c}", buyValue);//Saida de modo monetario
            Console.WriteLine("Lucro.........:{0,15:p}", profit);//Saida de modo porcentagem
            Console.WriteLine("Valor Venda...:{0,15:c}", sellValue);//Saida de modo monetario




        }
    }
}