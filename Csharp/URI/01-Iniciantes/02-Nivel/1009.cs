using System;    

namespace Uri1009.URI
{
    public class Uri1009
    {
        static void Main()
        {
            
            string nameEmployer;
            double totalComission, salary , totalSales;
            salary = totalSales = 0;            

            nameEmployer = ReceiveNameEmployer();
            ReceiveSalaryData( ref salary , ref totalSales);
            totalComission = CalculateCommission(totalSales);
            Console.WriteLine("TOTAL = R$ {0:0.00}", (salary + totalComission));
        }
        static string ReceiveNameEmployer()
        {
        string nameEmployer;    
        Console.WriteLine("Digite o nome do funcionario:");
        nameEmployer = Console.ReadLine();    
        return nameEmployer;
        }

        static void ReceiveSalaryData(ref double salary, ref double totalSales)
        {
        Console.WriteLine("Digite o salario atual");
        salary = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite as vendas nesse mes:");
        totalSales = double.Parse(Console.ReadLine());        
        
        
        }
        static double CalculateCommission(double totalSales)
        {
        double commissionTax , totalCommission;
        commissionTax = 0.15;
        totalCommission = ( totalSales * commissionTax);    
        return totalCommission;
        }
    }  
        
}
    