using System;

namespace find100
{
    class Program
    {
        public static void Print(int[] mas)
        {
            foreach (var el in mas)
                Console.Write(el + " ");
            Console.WriteLine();
        }
        public static int[] CreateArr()
        {
            Random random = new Random();
            int k = random.Next(0, 99);

            int[] mas = new int[99];
            for (int i = 0; i < k; i++)
                mas[i] = i+1;


            for (int i = k; i < 99; i++)
                mas[i] = i+2;



            for (int i = 0; i < 99; i++)
            {
                int j = random.Next(0, 98);
                int temp;
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
            return mas;
                
        }

        static void Main(string[] args)
        {
            int[] mas = CreateArr();
            Print(mas);
            int sumAll = 101 * 100 / 2;
            int sum = 0;
            for (int i = 0; i < 99; i++)
                sum+=mas[i];
            Console.WriteLine(sumAll - sum);
        }
    }
}
