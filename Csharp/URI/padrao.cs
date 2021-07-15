using System;

namespace URI
{
    class URI
    {
        static void Main()
        {        
        
        }
    }


/*
ENTRADA SIMPLES
*/
public void ReceiveSimpleData()
{
    Console.WriteLine("Digite um valor");
    receiveSimpleData = Console.ReadLine();
}
/*
Convertor de strings
*/
public void ConvertStringInt(string stringText)
{
    int intNumber;
    intNumber = int.Parse(stringText);
}
/*
Print de resultados
*/
public void PrintResult(string verifyInterval)
{
    Console.WriteLine(verifyInterval);
}
/*
private int[] ReadNumbers()
        {
            Console.WriteLine("Digite os números separados por espaço");
            readNumbers = Console.ReadLine().Split(' ');
            for (int i = 0; i < readNumbers.Length; i++)
            {
                numbers[i] = int.Parse(readNumbers[i]);
            }
            return numbers;
        }

*/
}