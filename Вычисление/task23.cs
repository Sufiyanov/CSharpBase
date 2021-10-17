using System;

namespace Expr10
{
    class Program
    {
        static void Main()
        {
            //Expr10. Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.
            int x = 1000;
            int k=0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    k=k+1;
                }
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}