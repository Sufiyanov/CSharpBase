using System;

namespace ConsoleApp1
{
    class task13
    {
        static void Main()
        {
            /*Напишите программу, которая выводит на консоль таблицу умножения
            */
            Console.WriteLine("Таблица умножения");
            int multiplicanda = 1;
            int multiplier = 1;
            int product;
            while (multiplicanda <= 9) 
            {
                while (multiplier <= 9) 
                {
                    product = multiplicanda * multiplier;
                    Console.WriteLine(multiplicanda + " x " + multiplier + " = " + product);
                    multiplier++;
                }
                multiplier = 1;
                multiplicanda++;
            }
            Console.ReadKey();
        }
    }
}