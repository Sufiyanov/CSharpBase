using System;

namespace ConsoleApp1
{
    class task1
    {
        static void Main()
        {
            /*Вывести на экран пять строк из нулей, 
              причем количество нулей в каждой строке равно номеру строки.
            */
            for (int i = 1; i < 6; i++) 
            {
                string result = new string('0', i);
                Console.WriteLine(result);

            } 
            Console.ReadKey();
        }
    }
}