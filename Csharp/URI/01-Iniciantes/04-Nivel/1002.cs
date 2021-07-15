using System;
namespace Exe1002.URI
{
    public class Exe1002
    {
        public  Exe1002()
        {
            const double pi = 3.14159;
            double ray, area;
            Console.WriteLine("Digite o tamanho do raio");
            ray = double.Parse(Console.ReadLine());
            area = pi * Math.Pow(ray , 2);
            Console.WriteLine("A={0:0.0000} ", area);
        }
    }
}


