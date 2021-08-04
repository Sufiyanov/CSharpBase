using System;

namespace ConsoleApp1
{
    class task11
    {
        static void Main()
        {
            /*За каждый месяц банк начисляет к сумме вклада 7% от суммы. 
              Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев. 
              А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
              Для вычисления суммы с учетом процентов используйте цикл for. 
              Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет представлять тип decimal).
            */
            Console.Write("Введите сумму вклада: ");
            decimal summContribution = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите количество месяцев вклада: ");
            int countMounth = Convert.ToInt16(Console.ReadLine());
            decimal bankInterest = 0.07M;
            for (int i = 0; i < countMounth; i++) 
            {
                summContribution= summContribution + summContribution * bankInterest;
            }
            Console.WriteLine("вам начислется " + summContribution);
            Console.ReadKey();
        }
    }
}