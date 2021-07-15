using System;

namespace Uri1041._03_Nivel._01_Iniciantes.URI
{
    interface ICoordinatesPoints
    {        
        void ReceivePoints();
        void ConvertStringDouble(int numIterator);
        void CheckPoints(double[] cartesianPoints);
        void PrintResult(string checkPoints);
    }
    public class CoordinatesPoints:ICoordinatesPoints
    {
        private string[] receivePoints;
        private string checkPoints;
        private double[] cartesianPoints;
        
        public CoordinatesPoints()
        {   
            cartesianPoints = new double[2];         
            ReceivePoints();
        }
        public void ReceivePoints()
        {   
            Console.WriteLine("Digite 2 números separados por espaço!");         
            receivePoints = Console.ReadLine().Split(' ');
        }
        public string[] GetReceivePoints()
        {
            return receivePoints;
        }
        public void ConvertStringDouble(int numIterator)
        {   
            
            if (numIterator >= cartesianPoints.Length){}           
            else
            {            
            cartesianPoints[numIterator] = double.Parse(receivePoints[numIterator]);            
            ConvertStringDouble(++numIterator);
            }
        }
        public double[] GetCartesianPoints()
        {
            return cartesianPoints;
        }
        public void CheckPoints(double[] cartesianPoints)
        {            
            this.cartesianPoints = cartesianPoints;
            checkPoints = (this.cartesianPoints[0] == 0 && this.cartesianPoints[1] == 0) ? "Origem"
                        : (this.cartesianPoints[0] == 0 && this.cartesianPoints[1] != 0) ? "Eixo Y"
                        : (this.cartesianPoints[0] != 0 && this.cartesianPoints[1] == 0) ? "Eixo X"
                        : (this.cartesianPoints[0] > 0 && this.cartesianPoints[1] > 0) ? "Q1"
                        : (this.cartesianPoints[0] < 0 && this.cartesianPoints[1] > 0) ? "Q2"
                        : (this.cartesianPoints[0] < 0 && this.cartesianPoints[1] < 0) ? "Q3" : "Q4";            
        }
        public string GetCheckPoints()
        {
            return checkPoints;
        }
        public void PrintResult(string checkPoints)
        {
            Console.WriteLine(checkPoints);
        }
    }
    class URI1041
    {
        static void Main()
        {            
            CoordinatesPoints points = new CoordinatesPoints();            
            points.ConvertStringDouble(0);
            points.CheckPoints(points.GetCartesianPoints());
            points.PrintResult(points.GetCheckPoints());
        }
    }
}