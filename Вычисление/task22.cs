using System;

namespace Expr5
{
    class Program
    {
        static void Main()
        {
            //Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.
            //int N = int.Parse(Console.ReadLine());
            int a = 1995;
            int b = 2020;
            Console.WriteLine(b/4-a/4);
            Console.ReadKey();
        }
    }
}