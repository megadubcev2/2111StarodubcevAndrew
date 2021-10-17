using System;

namespace sjatie
{
    class Program
    {
        static void Main(string[] args)
        {
            string strLen = Console.ReadLine();
            if (!int.TryParse(strLen, out int len))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            int[] mas = new int[len];
            for (int i = 0; i < len; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out mas[i]))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }
            }
            for (int i = 0; i < len - 1; i++)
            {
                if ((mas[i] + mas[i + 1]) % 3 == 0)
                {
                    mas[i] = mas[i] * mas[i + 1];
                    for (int j = i + 1; j < len - 1; j++)
                    {
                            mas[j] = mas[j + 1];
                    }
                    len--;
                }
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write(mas[i] + " ");
            }
        }
    }
}
