using System;

namespace refout
{
    class Program
    {
        public static bool Func1(bool p, bool q)
        {
            return !(p && q) & !(p || !q);
        }
        public static void Func2(bool p, bool q, out bool res)
        {
            res = !(p && q) & !(p || !q);
        }
        static void Main(string[] args)
        {
            bool res;
            Console.WriteLine(Func1(true, true));
            Func2 (true, true, out res);
            Console.WriteLine(res);

            Console.WriteLine(Func1(true, false));
            Func2(true, false, out res);
            Console.WriteLine(res);

            Console.WriteLine(Func1(false, true));
            Func2(false, true, out res);
            Console.WriteLine(res);

            Console.WriteLine(Func1(false, false));
            Func2(false, false, out res);
            Console.WriteLine(res);


        }
    }
}
