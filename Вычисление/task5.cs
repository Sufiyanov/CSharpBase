using System; 

namespace ConsoleApp1
{
    class task5
    {
        static void Main()
        {
            /*Дано число. Если оно от 2 до 5 включительно, то увеличить его на 10. 
              Если оно от 7 до 40, то уменьшить на 100. Если оно не более 0 или более 3000, 
              то увеличить в 3 раза (то есть умножить на 3). Иначе занулить это число.
            */
            Console.WriteLine("Введите число");
            int x = int.Parse(Console.ReadLine());
            if (x >= 2 && x <= 5)
            {
                x = x + 10;
            }
            else if (x > 7 && x < 40)
            {
                x = x - 100;
            }
            else if (x < 0 || x > 3000)
            {
                x = x * 3;
            }
            else
            {
                x = 0; 
            }
            Console.WriteLine("ответ: " + x);
            Console.ReadKey();
        }
    }
}