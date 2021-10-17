using System;
class MainClass
{
    public static void Print(char[] mas)
    {
        foreach (var el in mas)
            Console.Write(el + " ");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        int k = 10;
        if (!int.TryParse(Console.ReadLine(), out k))
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        char[] mas; // ссылка на массив

        mas = new char[k];
        Random random = new Random();
        for (int i = 0; i < mas.Length; i++)
            mas[i] = (char)random.Next('A', 'Z' + 1);
        Print(mas);
        char[] mas2 =  new char[k];
        Array.Copy(mas, mas2, k);
        Print(mas2);
        Array.Sort(mas2);
        Print(mas2);
        Array.Reverse(mas2);
        Print(mas2);

    }

}
