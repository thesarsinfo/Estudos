using static System.Console;

namespace Uri1103
{
    public class Uri1103Exer
    {        
        public string[] GetData()
        {
            string[]? data = ReadLine().Split(" ");
            return data;
        }
        public void CompareDate(int[] minutes)
        {
            int timeRemain;
            if (minutes[0] < minutes[1])
            {
                timeRemain = minutes[1] - minutes[0];
                PrintTime(timeRemain);
            }
            else
            {
                timeRemain = ((24 * 60) - minutes[0]) + minutes[1];
                PrintTime(timeRemain);
            }
        }
        public int[] ConvertDate(string[] data)
        {
            int[] minutes = new int[2];
            for(int i = 0 ; i < (data.Length /2); i++)
            {
                if (i == 0)                
                    minutes[i] = int.Parse(data[i]) * 60 + int.Parse(data[i + 1]);
                else
                    minutes[i] = int.Parse(data[i + 1]) * 60 + int.Parse(data[i +2]);
            }
            return minutes;
        }
        public void PrintTime(int timeRemain)
        {
            WriteLine(timeRemain);
        }
    }
}