using System;
/*
    Bloco Finally e disparar uma exceção como regra de negocio.
*/
namespace Aula53._02_Iniciante_Parte2
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
    class Aula53
    {      
        static void Main()
        { 
            float area = 0;           
            try
            {              
                area = Area.Quadrado(0F,5F);
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
}


