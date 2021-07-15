using System;

namespace Aulas
{
    class Aula26
    {
        static void Main()
        {        
            /*
                Argumento out serve para retornar 2 variaveis ou mais de cada metodo
            */

            int divid , divis, quoc, rest; // qouc = quociente e rest = resto
            divid = 10; //dividendo
            divis = 3;  //divisor
            quoc =  divide(divid, divis, out rest); // Aqui onde vai vazio e volta na variavel quoc;
            Console.WriteLine("{0}/{1}:quociente ={2} e resto= {3}",divid,divis,quoc,rest);

        }
        static int divide(int dividendo, int divisor, out int resto)
        {
            int quociente;
            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
           
        }       
    }
}