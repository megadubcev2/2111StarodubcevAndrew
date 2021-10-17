using System;

namespace sortarr
{
    class Program
    {
        public static int SortOdd(int a, int b)
        {
            if (a % 2 == 0)
            {
                return -1;
            }
            return 1;

        }
        public static int CountDigits(int a)
        {
            int quantity = 0;
            while (a > 0)
            {
                quantity++;
                a /= 10;
            }
            return quantity;
        }
        public static int SumDigits(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }
            return sum;
        }
        public static int SortQuantityDigits(int a, int b)
        {
            if (CountDigits(b) < CountDigits(a))
            {
                return 1;
            }
            return -1;
        }
        public static int SortSumDigits(int a, int b)
        {
            if (SumDigits(b) < SumDigits(a))
            {
                return 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            int[] mas = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = random.Next(0, 1000);
            }
            Array.ForEach(mas, el => Console.Write(el + " "));
            Console.WriteLine(); Array.Sort(mas, SortOdd);
            Array.ForEach(mas, el => Console.Write(el + " "));
            Console.WriteLine();
            Array.Sort(mas, SortQuantityDigits);
            Array.ForEach(mas, el => Console.Write(el + " "));
            Console.WriteLine(  );
            Array.Sort(mas, SortSumDigits);
            Array.ForEach(mas, el => Console.Write(el + " "));
            Console.WriteLine();
        }
    }
}
