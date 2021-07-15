using System;
/*
    NAmespace serve para definir escopo das classes dentro do programa e dividir em areas
*/
namespace CalculoI // escopo
{
    class Area
    {
        public static float Quadrado(float comprimento , float altura)
        {
            if(comprimento == 0 || altura == 0)
            {
                throw new Exception("Base ou altura com valor com 0");
            }
            return comprimento * altura;
        }
    }
}
namespace CalculoII
{
    class Area
    {
        public static float Quadrado(float comprimento , float altura)
        {
            if(comprimento == 0 || altura == 0)
            {
                throw new Exception("Base ou altura com valor com 0");
            }
            return comprimento * altura;
        }
    }
}
    class Aula54
    {      
        static void Main()
        { 
            float area = 0;           
            try
            {              
                area = CalculoI.Area.Quadrado(1F,5F);//Declaração na função o namespace mas podemos usar o
                //using o nome do namespace e aqui estamos usando o namespace CalculoI e a CalculoII esta como
                //fantasma so para representar que podemos ter o mesmo nome.
                Console.WriteLine("Area do Quadrado: {0}", area);                
            }
            catch(Exception errado) 
            {
                Console.WriteLine("L1 ERRO:{0}",errado.Message);                
                           
            }
            finally
            {
                Console.WriteLine("Fim do processo");
            }            
        }
    }



