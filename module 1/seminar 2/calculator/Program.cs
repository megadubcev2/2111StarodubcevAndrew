using System;

namespace calculator
{
    class Program
    {
        public static int Calc(int chislo1, int chislo2, string operacia)
        {
            switch(operacia)
            {
                case "+":
                    return chislo1 + chislo2;
                    break;
                case "*":
                    return chislo1 * chislo2;
                    break;
                case "/":
                    return chislo1 / chislo2;
                    break;
                case "%":
                    return chislo1 % chislo2;
                    break;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            string strChislo1 = Console.ReadLine();
            string strChislo2 = Console.ReadLine();
            string operacia = Console.ReadLine();
            if (!int.TryParse(strChislo1, out int chislo1) || !int.TryParse(strChislo2, out int chislo2))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Console.WriteLine(Calc(chislo1, chislo2, operacia));

        }
    }
}
