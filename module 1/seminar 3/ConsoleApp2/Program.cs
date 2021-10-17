using System;

namespace ConsoleApp2
{
    class Program
    {
        public static double Sum(int n)
        {
            double sum = 0;
            for (int k = 1; k <= n; k++)
            {
                sum += (k + 0.3) / (3 * k * k + 5);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string nstr = Console.ReadLine();
            int n;
            if (!int.TryParse(nstr, out n))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(Sum(i));

            }
        }
    }
}
