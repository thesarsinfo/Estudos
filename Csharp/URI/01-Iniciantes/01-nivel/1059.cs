using System;

namespace Uri1059.URI.Iniciantes.Nivel1
{
    public class EvenNumbers
    {
        public int i;
        public EvenNumbers()
        {
            for (int i = 2; i < 101; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Uri1059
    {
        static void Main()
        {
            EvenNumbers evenNumbers = new EvenNumbers();            
        }
    }
}