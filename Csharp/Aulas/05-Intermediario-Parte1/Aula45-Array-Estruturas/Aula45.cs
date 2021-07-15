using System;
/*
Array de estruturas
*/

namespace Aula00._02_Iniciante_Parte2
{
    struct Carro
    {   
       
        public string modelo;
        public string cor;
        
        public void Info()
        {
            Console.WriteLine("Modelo.: {0}", this.modelo);
            Console.WriteLine("cor....: {0}", this.cor);            
            Console.WriteLine("<!---------------------------------!>");
        }
    }
    class Aula45
    {
        static void Main()
        {        
            Carro[] carros = new Carro[4];
            carros[0].modelo = "HRV";
            carros[0].cor = "Prata"; 
            
            carros[1].modelo = "Golf";
            carros[1].cor = "Azul"; 
           
            carros[2].modelo = "Jetta";
            carros[2].cor = "Branco"; 
           
            carros[3].modelo = "Argo";
            carros[3].cor = "Preto"; 
            
            for (int i = 0; i < carros.Length; i++)
            {
                carros[i].Info();
            }
            carros[0].Info();
            carros[1].Info();
            carros[2].Info();
            carros[3].Info();           
        }
    }
}