//Operadores e operações em CSharp
using System;

class Aula05
{
    static void Main()
    {
        int num = 0;
        int result = (10 + 5) * 2;        
        Console.WriteLine(result);
        //Operares relacionais ( < > <= >= != )
        bool  resultBool = 10 > 5; 
        Console.WriteLine(resultBool);
        //inclremento de variaveis
        num += 1;
        num++;
        num += 10;
        num /= 2;
        Console.WriteLine(num);
        //Operadores & ou |
        resultBool = (5>7)|(10 < 5); // false
        Console.WriteLine("O valor de operador booleano: " + resultBool);


    }
}