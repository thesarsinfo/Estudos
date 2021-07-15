using System;

namespace URI
{
    public class Numbers
    {   
        private string[] readNumbers;
        private int[] numbers = new int[3];
        private int[] sortNumbers = new int[3];
        public Numbers()
        {
            ReadNumbers();
            SortNumber(numbers);
        }
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
        private void SortNumber(int[] numbers)
        {            
            Array.Copy(numbers,sortNumbers,numbers.Length);
            Array.Sort(sortNumbers);            
        }
        public int[] GetPrintNumber()
        {
            return numbers;
        }
        public int[] GetPrintSortNumber()
        {
            return sortNumbers;
        }
    }
    class URI1042
    {
        static void Main()
        {      
            int[] receiveNumbers ; int[] receiveSortNumbers;  
            Numbers numbers = new Numbers();
            receiveNumbers = numbers.GetPrintNumber();
            receiveSortNumbers = numbers.GetPrintSortNumber();
            for (int i = 0; i < receiveNumbers.Length; i++)
            {
                Console.WriteLine(receiveSortNumbers[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < receiveNumbers.Length; i++)
            {
                Console.WriteLine(receiveNumbers[i]);
            }            
        }
    }
}