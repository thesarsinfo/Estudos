using System;

namespace Exe1008.URI
{
    public class Exe1008
    {
        public  Exe1008()
        {   
            int idWorker , workedHours;
            double hourlywages;
            Console.WriteLine("Digite o Id do funcionario!");
            idWorker = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as Horas trabalhadas");
            workedHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor hora");
            hourlywages = double.Parse(Console.ReadLine());
            Console.WriteLine("NUMBER = {0}",idWorker);
            Console.WriteLine("SALARY = U$ {0:0.00}", (hourlywages * workedHours));  
              
                   
        }
    }
}