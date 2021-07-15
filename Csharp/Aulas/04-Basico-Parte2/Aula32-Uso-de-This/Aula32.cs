using System;

namespace Aula32.Basico.Parte2
{
    class Calculos
    {
        public int v1;
        public int v2;
        public Calculos(int v1, int v2)
        {
            /*
                this se refere ao objeto pai que é Calculos.
            */
            this.v1 = v1;
            this.v2 = v2;
        }
        public int Somar()
        {
            return v1 + v2;
        }
    }
    class Aula32
    {
        static void Main()
        {
          /* Aula 32 Operador this.

          */          
            Calculos calculos = new Calculos(10,2);
            Console.WriteLine(calculos.Somar());

        }
    }
}