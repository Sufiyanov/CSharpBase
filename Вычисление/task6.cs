using System;

namespace ConsoleApp1
{
    class task6
    {
        static void Main()
        {
            /*Даны три числа. Написать "yes", 
              если можно взять какие-то два из них и в сумме получить третье
            */
            Console.WriteLine("Введите число x1");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число x2");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число x2");
            int x3 = int.Parse(Console.ReadLine());
            string result ="";
            if (x1 + x2 == x3) result = "yes";
            if (x3 + x2 == x1) result = "yes";
            if (x1 + x3 == x2) result = "yes";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}