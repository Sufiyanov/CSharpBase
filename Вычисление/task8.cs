using System;

namespace ConsoleApp1
{
    class task8
    {
        static void Main()
        {
            /*Дана дата из трех чисел (день, месяц и год). 
              Вывести yes, если такая дата существует (например, 12 02 1999 - yes, 22 13 2001 - no). 
              Считать, что в феврале всегда 28 дней.
            */
            Console.WriteLine("Введите дату через пробел");
            string date = (Console.ReadLine());
            string result = "no";
            string[] dateParse = date.Split(' ');
            int day = int.Parse(dateParse[0]);
            int mounth = int.Parse(dateParse[1]);
            int year = int.Parse(dateParse[2]);
            if (day >= 1 && day <= 31 && mounth >= 1 && mounth <= 12 && mounth != 2 && year>=1) result = "yes";
            if (day >= 1 && day <= 28 && mounth == 2 && year >= 1) result = "yes";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}