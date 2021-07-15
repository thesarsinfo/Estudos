using System;

namespace Aula47._05_Intermediario.Parte1
{
    class Calc
    {
        public int Soma(int n1,int n2)        
        {
            return n1 + n2;
        }
        public double Soma(double n1,double n2)        
        {
            return n1 + n2;
        }
        public int SomaParams(params int[] n)        
        {
            int somaTotal = 0;
            if (n.Length < 1)
            {
                Console.WriteLine("Nenhum Parametro informado");
                return 0;
            }
            for(int i = 0; i < n.Length;i++)
            {
                somaTotal += n[i];
            }
            return somaTotal;
        }
    
        public double SomaParams(params double[] n)        
        {
            double somaTotal = 0;
            if (n.Length < 1)
            {
                Console.WriteLine("Nenhum Parametro informado");
                return 0;
            }
            for(int i = 0; i < n.Length;i++)
            {
                somaTotal += n[i];
            }
            return somaTotal;
        }
    }
    class Aula47
    {
        static void Main()
        {       
            Calc calc = new Calc();
            var res = calc.Soma( 5.52,9.495); // todo var deve ser inicializada;
            var ress = calc.SomaParams(5);
            Console.WriteLine(res);
            Console.WriteLine(ress);
        }
    }
}