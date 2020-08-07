using System;

namespace Code_Challenge_Day_17__Propagating_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());

            while(T-->0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);

                try
                {
                    int ans = calculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
           
        }
    }
}
