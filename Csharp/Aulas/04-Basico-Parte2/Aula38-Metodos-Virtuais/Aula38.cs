using System;
/*
Aula 38 - Metodo virtuais são uma cópia mesmo nome em classe diferentes e ele pode ser sobreescrito na classe base
*/
namespace Aula00._02_Iniciante_Parte2
{
    class Base
    {
        public Base()
        {
        
             Console.WriteLine("Construtor da classe Base");
        }
        virtual public void info()
        {
            Console.WriteLine("Base");// Nao faz sentido implementar o metodo porque sempre vai ser sobreescrito.
        }
    }
    class Derivada1:Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da classe Derivada 1");
        }
        override public void info()
        {
            Console.WriteLine("Derivada1");
        }
    }
    class Derivada2:Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor da classe Derivada 2");
        }
         override public void info()
        {
            Console.WriteLine("Derivada2");
        } 
    }
    class Program
    {
        static void Main()
        {     
           // Base Ref;//Elemento de refecincia   
            Derivada1 derivada1 = new Derivada1();
            Derivada2 derivada2 = new Derivada2();
            derivada1.info();//imprime derivada 1 porque a o metodo da base foi sobreescrito
            derivada2.info();//imprime derivada 2 porque a o metodo da base foi sobreescrito
            Ref = derivada1;
            Ref.info();//imprime derivada 1;
        }
    }
}