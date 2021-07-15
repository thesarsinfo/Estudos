using System;

namespace Aula00._02_Iniciante_Parte2
{
    class Program
    {
        static void Main()
        {        
            int n1,n2,res;
            res =n1=n2=0;
            n1 = 10;
            n2 = 0;
            try
            {
                res = n1 /n2;
                Console.WriteLine("{0}/{1}={2}",n1,n2,res);
            }
            catch(Exception errado) 
            {
                Console.WriteLine("L1 ERRO:{0}",errado.Data);                
                Console.WriteLine("L2 ERRO:{0}",errado.GetBaseException());
                Console.WriteLine("L3 ERRO:{0}",errado.GetHashCode());                
                Console.WriteLine("L4 ERRO:{0}",errado.GetType());
                Console.WriteLine("L5 ERRO:{0}",errado.HelpLink);
                Console.WriteLine("L6 ERRO:{0}",errado.HResult);
                Console.WriteLine("L7 ERRO:{0}",errado.InnerException);                
                Console.WriteLine("ERRO:{0}",errado.Source);
                Console.WriteLine("ERRO:{0}",errado.StackTrace);
                Console.WriteLine("ERRO:{0}",errado.TargetSite);
                Console.WriteLine("ERRO:{0}",errado.ToString());
                
            }
            
            
        }
    }
}