using System;

namespace Aula17._02_Iniciante_Parte2
{
    class Aula17
    {
        static void Main()
        {   
            int n1, n2, n3, n4, n5;
             // tipo[] nome = new tipo[tamanho]     
            int[] n = new int[5]; //Array do tipo inteiro primeira forma de declaração
            int[] num = new int[3]{55,77,99}; // //Array inicializado com valores
            int[] num2 = {66,55,88} // forma mais usual
           
            n[0] = 111;
            n[1] = 222;
            n[2] = 333;
            n[3] = 444;
            n[4] = 555;

            Console.WriteLine(n[0]);
            Console.WriteLine(num);


        }
    }
}