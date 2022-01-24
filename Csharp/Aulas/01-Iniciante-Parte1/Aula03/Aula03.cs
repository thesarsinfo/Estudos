using System;

namespace Aula03
{
    class Aula03
    {
        static void Main()
        {
            byte n1 = 10; //0 e 255
            int x ,y;            
            int numero = 0;
            int num, num2, res;
            x = 0;
            y = 0;
            num  = 5;
            num2 = 10;
            res = num + num2;
            char letra = 'c';
            float valorReal = 5.3f;
            string nome = "Saraiva";
            var aux = 10; //não especifica o tipo de variavel e na compilação
            //tipo compilação python porem no futuro não podemos alterar
            FloorTemperature(2.0f);
           

            Console.WriteLine(x/y);
        }
         public static void FloorTemperature(float degrees)
            {
                object degreesRef = degrees;
                int result = (int)(float)degreesRef;
                Console.WriteLine(result);
                
            }
    }
}