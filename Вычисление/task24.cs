using System;

namespace Exp11
{
    class Program
    {
        static void Main()
        {
            //Expr11. Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.
            int hour = 1;
            int minute = 30;
            int radius = 0;
            radius = Math.Abs( (hour * 5 - minute) * 6);
            Console.WriteLine(radius);
            Console.ReadKey();
        }
    }
}