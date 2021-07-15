using System;
using System;

namespace ConsoleApp1
{
    class task10
    {
        static void Main()
        {
            /*Начав тренировки, лыжник в первый день пробежал 10 км. 
              Каждый следующий день он увеличивал пробег на 10% от пробега предыдущего дня. 
              Определите: а) пробег лыжника за второй, третий, ..., десятый день тренировок; 
              б) какой суммарный путь он пробежал за первые 7 дней тренировок. 
            */
            double mileage = 10;
            double totalPath = mileage; 
            int i = 0;
            while (i < 23)
            {
                mileage = mileage + mileage * 0.1;
                Console.WriteLine("День " + i + " | Пробежал " + mileage);
                if (i > 7) totalPath = totalPath + mileage;

               i++;
            }
            Console.WriteLine("Сумарнный путь за 7 дней " + totalPath + " km");
            Console.ReadKey();
        }
    }
}