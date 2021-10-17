using System;

namespace maxcifra
{
    class Program
    {
        static void Main(string[] args)
        {
            string strChislo = Console.ReadLine();
            if (!int.TryParse(strChislo, out int chislo))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            int maxcifra = -1;
            int mincifra = 10;
            int cifra;
            while (chislo > 0)
            {
                cifra = chislo % 10;
                chislo /= 10;

                if (cifra < mincifra)
                {
                    mincifra = cifra;
                }
                if (cifra > maxcifra)
                {
                    maxcifra = cifra;
                }
            }
            Console.WriteLine(maxcifra);
            Console.WriteLine(mincifra);
        }
    }
}
