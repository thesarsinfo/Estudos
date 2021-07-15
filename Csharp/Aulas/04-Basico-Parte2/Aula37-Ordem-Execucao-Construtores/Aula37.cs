using System;

namespace Aula00._02_Iniciante_Parte2
{
    class Base
    {
        public Base()
        {
        
             Console.WriteLine("Construtor da classe Base");
        }
    }
    class Derivada1:Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da classe Derivada 1");
        }
    }
    class Derivada2:Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor da classe Derivada 2");
        }   
}
    class Derivada3:Derivada2
    {
         public Derivada3()
        {
        Console.WriteLine("Construtor da classe Derivada 3");
        }
    }
    class Program
    {
        static void Main()
        {        
            Derivada3 deri = new Derivada3();
        }
    }
}