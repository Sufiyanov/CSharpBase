using System;

namespace ConsoleApp1
{
    class task7
    {
        static void Main()
        {
            /*Робот может перемещаться в четырех направлениях 
              («11» — север, «12» — запад, «13» — юг, «14» — восток) 
              и принимать три цифровые команды: 0 — продолжать движение, 
              1 — поворот налево, –1 — поворот направо. Дан число (11, 12, 13 или 14) — исходное 
              направление робота и целое число N (0, 1 или -1) — посланная ему команда. 
              Вывести направление робота после выполнения полученной команды (то есть север, запад, юг или восток).
            */
            Console.WriteLine("Введите исходное направление");
            int cardinalDirection = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите команду роботу");
            int command = int.Parse(Console.ReadLine());
            string result ="";
            if (cardinalDirection + command == 11 || cardinalDirection + command == 15) result = "север";
            if (cardinalDirection + command == 12) result = "запад";
            if (cardinalDirection + command == 13) result = "юг";
            if (cardinalDirection + command == 14 || cardinalDirection + command == 10) result = "восток";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}