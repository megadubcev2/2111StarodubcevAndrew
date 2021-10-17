using System;

namespace perevernutoe
{
    class Program
    {
        public static void Perevernut(ref int chislo)
        {
            int cifra, perevernutoe = 0;
            while (chislo > 0)
            {
                cifra = chislo % 10;
                perevernutoe *= 10;
                perevernutoe += cifra;
                chislo /= 10;
            }
            chislo = perevernutoe;
        }
        static void Main(string[] args)
        {
            string strChislo = Console.ReadLine();
            if (!int.TryParse(strChislo, out int chislo))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            Perevernut(ref chislo);
            Console.WriteLine(chislo);

        }
    }
}
