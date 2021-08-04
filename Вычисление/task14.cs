using System;

namespace ConsoleApp1
{
    class task14
    {
        static void Main()
        {
            /*Напишите программу, в которую пользователь вводит два числа и выводит результат их умножения. 
             * При этом программа должны запрашивать у пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. 
             * Если введенные числа окажутся больше 10 или меньше 0, то программа должна вывести пользователю о том, 
             * что введенные числа недопустимы, и повторно запросить у пользователя ввод двух чисел. 
             * Если введенные числа принадлежат диапазону от 0 до 10, то программа выводит результат умножения.

             * Для организации ввода чисел используйте бесконечный цикл while и оператор break.
            */
            int end = 0;
            while (end == 0) {
                Console.Write("Введите множимое: ");
                int multiplicanda = Convert.ToInt16(Console.ReadLine());
                Console.Write("Введите множитель: ");
                int multiplier = Convert.ToInt16(Console.ReadLine());
                if (multiplicanda >= 0 && multiplicanda <= 10 && multiplier >= 0 && multiplier <= 10)
                {
                    int product = multiplicanda * multiplier;
                    Console.WriteLine(multiplicanda + " x " + multiplier + " = " + product);
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("введенные числа недопустимы");
            }

        }
    }
}