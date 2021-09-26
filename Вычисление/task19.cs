using System;

namespace Expr2
{
    class Program
    {
        static void Main()
        {
            //Задается натуральное трехзначное число (гарантируется, что трехзначное).
            //Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
            int x = int.Parse(Console.ReadLine());
            int hundred = x/100;
            int ten = x/10%10;
            int unit = x%10;
            Console.WriteLine(unit*100+ten*10+hundred);
            Console.ReadKey();
        }
    }
}
