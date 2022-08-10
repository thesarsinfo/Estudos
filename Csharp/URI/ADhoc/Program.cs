using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


using Uri1103;
using ADhoc.Entities;


//Uri1103();
Uri1171Exer();
static void Uri1103()
{
    Uri1103Exer uri1103 = new Uri1103Exer();
    while (true)
    {
        string[] data = uri1103.GetData();
        int[] minutes = uri1103.ConvertDate(data);
        if (minutes.Sum() == 0)
            break;
        uri1103.CompareDate(minutes);
    }
}
static void Uri1171Exer()
{
    URI1171 uri1171 = new URI1171();
    GetNumbers();
    static int GetNumbers()
    {
        WriteLine("Digite a quantidade de numeros");
        int numbersTotal = int.Parse(ReadLine());
        return numbersTotal;
    }
    
   

}
