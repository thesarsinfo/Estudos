using System;
using System.Runtime.Hosting;

namespace URI
{
    public class GeometryFigure
    {
        private string[] readNumbers;
        private double[] numbersSizes = new double[3];
        private bool verifyTrapezium;
        private double calculeArea;
        public GeometryFigure()
        {
            GetDataSizesSides();
            verifyTrapezium = VerifyTriangleTrapizium(numbersSizes);
            calculeArea =(verifyTrapezium)? CalculateArea() : CalculatePerimetry() ; 
        }
        private double[] GetDataSizesSides()
        {            
            Console.WriteLine("Digite os números separados por espaço");
            readNumbers = Console.ReadLine().Split(' ');
            for (int i = 0; i < readNumbers.Length; i++)
            {
                numbersSizes[i] = double.Parse(readNumbers[i]);
            }
            return numbersSizes;
        }
        private bool VerifyTriangleTrapizium(double[] numberSizes)
        {
            bool verifyTrapezium = false;
            if (numbersSizes[0]  < (numbersSizes[1]  + numbersSizes[2] ) )
            {                
                if (numbersSizes[1]  < (numbersSizes[0]  + numbersSizes[2] ))
                {                   
                    if (numbersSizes[2]  < (numbersSizes[0]  + numbersSizes[1] ))
                    {                        
                        verifyTrapezium = false;
                    }
                    else
                    {
                        verifyTrapezium = true;
                    }
                }
                else
                {
                    verifyTrapezium = true;
                }               
            }
            else
            {
                verifyTrapezium = true;
            }           
            return verifyTrapezium;                     
        }
        private double CalculatePerimetry()
        {            
            double perimetry;            
            perimetry = numbersSizes[0] + numbersSizes[1] + numbersSizes[2];
            return perimetry;
        }
        private double CalculateArea()
        {
            double area;            
            area = ((numbersSizes[0] + numbersSizes[1]) * numbersSizes[2]) / 2;
            return area;
        }
        public double GetResult()
        {
            return calculeArea;
        }
        public bool GetVerifyTrapezium()
        {
            return verifyTrapezium;
        }

    }
    class URI
    {
        static void Main()
        {   
            bool testResult;     
            GeometryFigure objGeometryFigure = new GeometryFigure();
            testResult = objGeometryFigure.GetVerifyTrapezium();
            if (testResult)
            {
                Console.WriteLine("Area = {0:0.0}", objGeometryFigure.GetResult());
            }else
            {
                Console.WriteLine("Perimetro = {0:0.0}", objGeometryFigure.GetResult());
            }
            
        }
    }
}