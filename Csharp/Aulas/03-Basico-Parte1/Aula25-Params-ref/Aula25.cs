using System;

namespace Aulas
{
    class Aula25    
    {
        static void Main()
        {        
                       //dotnet sln SaraivaEstudos.sln add .\03-Basico-Parte1\Aula24-Metodos\Aula24.cspro
            int num = 10;
            int num1 = 10;
            dobrar(num); //passagem de valor ou seja o registro na memoria sera em outro local
            Console.WriteLine(num);
            dobrarr(ref num1);// passagem por referencia e assim não cria um ponteiro de memoria
            Console.WriteLine(num1);

        }

        static void dobrar(int valor)
        {
            valor *= 2;
        }
        static void dobrarr(ref int valor)
        {
            valor *= 2;
        }
    }
}