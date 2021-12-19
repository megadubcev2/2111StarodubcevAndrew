using System;

namespace operat
{
    public class MyComplex
    {
        public double re, im;
        public MyComplex(double xre, double xim)
        { re = xre; im = xim; }
        // Неправильная реализация:       


        //public static MyComplex operator ++(MyComplex mc)        
          //  { mc.re++; mc.im++; return mc; }
            
            public static MyComplex operator --(MyComplex mc)
       { return new MyComplex(mc.re-1, mc.im-1); }

        public double Mod()
        { return Math.Abs(re * re + im * im); }
        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }
        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }

        static public MyComplex operator +(MyComplex f1 , MyComplex f2)
        {
            MyComplex f3 = new MyComplex(f1.re + f2.re, f1.im + f2.im);
            return f3;
        }

        static public MyComplex operator -(MyComplex f1, MyComplex f2)
        {
            MyComplex f3 = new MyComplex(f1.re - f2.re, f1.im - f2.im);
            return f3;
        }

        static public MyComplex operator *(MyComplex f1, MyComplex f2)
        {
            MyComplex f3 = new MyComplex(f1.re * f2.re - f1.im * f2.im, f1.im * f2.re + f2.im * f1.re);
            return f3;
        }

        static public MyComplex operator /(MyComplex f1, MyComplex f2)
        {
            MyComplex f3 = new MyComplex((f1.re * f2.re + f1.im * f2.im), f1.im - f2.im);
            return f3;
        }
        public override string  ToString ()
        {
            return this.re + " " + this.im;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyComplex myComp1 = new MyComplex(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            MyComplex myComp2 = new MyComplex(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(myComp1 + myComp2);
            Console.WriteLine(myComp1 - myComp2);
            Console.WriteLine(myComp1 * myComp2);
            Console.WriteLine(myComp1 / myComp2);
        }
    }
}


