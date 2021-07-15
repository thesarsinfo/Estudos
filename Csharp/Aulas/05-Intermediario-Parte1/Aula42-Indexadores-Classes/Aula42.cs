using System;
/*
Indexadores de classe ele um membro de uma classe que vai que os objetos da classe como arrays para manipula
*/
namespace Aula00._02_Iniciante_Parte2
{
    class Carro 
    {
        private int[] velMax = new int[5]{80,120,160,240,300};
        public int this[int i]
        {
            get
            { 
                return velMax[i];
            } //propriedade de leitura readonly // Obter valo
            set
            {
                if(value < 0)
                {
                    velMax[i] = 0;
                }else if(value > 300)
                {
                    velMax[i] = 300;
                }else
                {
                    velMax[i] = value;
                }
            } // propriedade de escrita writeonly
        }
        public Carro()
        {
                       
        }
        
    }
    class Aula41
    {
        static void Main()
        {        
             Carro c1 = new Carro();
             c1[4] = 250;
             Console.WriteLine("Velocidade:{0}", c1[3]); 
                     
             
        }     
    }
}