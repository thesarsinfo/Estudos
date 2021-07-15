using System;

namespace URI
{
    public class Multiplus
    {
        private int[] intNumbers = new int[2];
        private double[] dotNumbers = new double[2];          
        private string[] receiveNumbers;
        
        public void ReceiveStringNumbers()
        {
            Console.WriteLine("Digite 2 numeros separados por espaço");
            receiveNumbers = Console.ReadLine().Split(' ');
        }
        public string[] RetrieveNumbers()
        {
            return receiveNumbers;
        }     
        public double[] ConvertNumbers(string[] receiveNumbers)
        {
            for (int i = 0; i < receiveNumbers.Length; i++)
            {
                dotNumbers[i] = double.Parse(receiveNumbers[i]);                
            }
            Array.Sort(dotNumbers);
            return dotNumbers;
        }
        public int CalculateNumbers(int[] numbers)
        {
            int resultMultiplus;
            return resultMultiplus = numbers[1] % numbers[0];
        }
        public double CalculateNumbers(double[] numbers)
        {            
            double resultMultiplusDouble;
            return resultMultiplusDouble = numbers[1] % numbers[0];
        }           

    }
    static class URI1044
    {
        static void Main()
        {   
            
            string printResult;            

            Multiplus multiplus = new Multiplus();
            multiplus.ReceiveStringNumbers();
            var dotNumbers = multiplus.ConvertNumbers(multiplus.RetrieveNumbers());
            var resultNumbers = multiplus.CalculateNumbers(dotNumbers);
            printResult = (resultNumbers == 0)? "Sao Multiplos" : "Nao sao Multiplos";
            Console.WriteLine(printResult); 
        }
    }
}