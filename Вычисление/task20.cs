using System;

namespace Expr3
{
    class Program
    {
        static void Main()
        {
            //Expr3.Задано время Н часов(ровно). Вычислить угол в градусах между часовой и минутной стрелками.
            //Например, 5 часов-> 150 градусов, 20 часов-> 120 градусов.Не использовать циклы.
            int H = int.Parse(Console.ReadLine());
            int angle = 180-Math.Abs(Math.Abs(H - 12) - 6)*30; 
            Console.WriteLine(angle);
            Console.ReadKey();
        }
    }
}