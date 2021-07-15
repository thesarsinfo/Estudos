using System;
/*
Aula 41 esses acessots  é uma mistura de propriedade e metodos
*/
namespace Aula00._02_Iniciante_Parte2
{
    class Carro 
    {
        private int velMax;
        public int vm
        {
            get
            { 
                return velMax;
            } //propriedade de leitura readonly // Obter valo
            set
            {
                if(value < 0)
                {
                    velMax = 0;
                }else if(value > 300)
                {
                    velMax = 300;
                }else
                {
                    velMax = value;
                }
            } // propriedade de escrita writeonly
        }
        public Carro()
        {
            this.velMax = 120;
            vm = 130;
        }
        public void vlm(int velMax)
        {
            this.velMax = velMax;
        }
    }
    class Aula41
    {
        static void Main()
        {        
             Carro c1 = new Carro();
             Console.WriteLine("Velocidade:{0}", c1.vm); 
             c1.vm = 200;         
             Console.WriteLine("Velocidade:{0}", c1.vm); 
        }     
    }
}