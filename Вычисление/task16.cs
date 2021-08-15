using System;

namespace ConsoleApp1
{
    class task16
    {
        static void Main()
        {
            // Найти наибольший элемент массива.
            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };

            int result = mas[0, 0, 0];
            foreach (int i in mas)
            {
                if (result < i) result = i;
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}