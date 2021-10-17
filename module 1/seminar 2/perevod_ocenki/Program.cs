using System;

namespace perevod_ocenki
{
    class Program
    {
        public static string Perevod(int chislo)
        {
            if (chislo<=3)
            {
                return "неудовлетворительно";
            }

            if (chislo <= 5)
            {
                return "удовлетворительно";
            }

            if (chislo <= 7)
            {
                return "хорошо";
            }
            return "отлично";
        }
        static void Main(string[] args)
        {
            string strChislo = Console.ReadLine();
            if (!int.TryParse(strChislo, out int chislo))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            
            Console.WriteLine(Perevod(chislo));

        }
    }
}
