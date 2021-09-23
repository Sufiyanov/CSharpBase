using System;

namespace Expr1
{
    class Program
    {
        static void Main()
        {
            //Expr1. Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?
            int a = 1;
            int b = 2;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a}, b = {b}, Менять местами переменную не стоит");
            Console.ReadKey();
        }
    }
}
