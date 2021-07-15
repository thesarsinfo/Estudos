using System; 
namespace Exe1006.URI
{
    class Exe1006
    {
        public  Exe1006() 
        { 
            double firstGrade, secondGrade , thirdGrade, averageGrade;
            Console.WriteLine("Digite a primeira nota");
            firstGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            secondGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            thirdGrade = double.Parse(Console.ReadLine());
            averageGrade = ((firstGrade * 2) + (secondGrade * 3) + (thirdGrade * 5))/ 10.0;
            Console.WriteLine("MEDIA = {0:0.0}", averageGrade);
        }
    }
}