using System;

namespace URI1037.URI
{
    class Interval
    {
        public static string receiveSimpleData;
        private static string verifyInterval;
        public static double numberInterval;
        public static void ReceiveSimpleData()
        {
            Console.WriteLine("Digite um valor");
            receiveSimpleData = Console.ReadLine();
        }
        public void ConvertStringInt(string receiveSimpleData)
        {            
            numberInterval = double.Parse(receiveSimpleData);
        }
        public void VerifyInterval(double numberInterval)
        {
            verifyInterval = (numberInterval >= 0 && numberInterval <= 25) ? "Intervalo (0,25]" 
                            :(numberInterval >= 25 && numberInterval <= 50) ? "Intervalo [25,50]" 
                            :(numberInterval >= 50 && numberInterval <= 75) ? "Intervalo (50,75]"
                            :(numberInterval >= 75 && numberInterval <= 100) ? "Intervalo [75,100]"
                            :"Fora de intervalo";    
        }
        public string GetVerifyInterval()
        {
            return verifyInterval;
        }
        public static void PrintResult(string verifyInterval)
        {
            Console.WriteLine(verifyInterval);
        }

    }
    class URI1037
    {
        
        static void Main()
        {        
        Interval.ReceiveSimpleData();
        Interval intervalObject = new Interval();
        intervalObject.ConvertStringInt(Interval.receiveSimpleData);
        intervalObject.VerifyInterval(Interval.numberInterval);
        Interval.PrintResult(intervalObject.GetVerifyInterval());        
        }
    }
}