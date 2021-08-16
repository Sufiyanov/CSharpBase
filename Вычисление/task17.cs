using System;

namespace ConsoleApp1
{
    class task17
    {
        static void Main()
        {
            // Дан массив и число p. Найдите два различных числа в массиве, сумма которых наиболее близка к p.

            int p = Convert.ToInt32(Console.ReadLine());
            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };

            //упаковываем многостройчный в однострочный массив (можно найти подругому, подумал так лучше)
            int[] mas2 = new int[mas.Length];
            int k = 0;
            foreach (int i in mas)
            {
                mas2[k] = i;
                k++;
            }
            int a = mas2[0];
            int b = mas2[1]; 
            int result = Math.Abs(mas2[0] + mas2[1] - p);

            
            for (int j1 = 0; j1 <= mas2.GetUpperBound(0); j1++)
            {
                for (int j2 = 0; j2 <= mas2.GetUpperBound(0); j2++)
                {
                    if (mas2[j1] != mas2[j2] && result > Math.Abs(mas2[j1] + mas2[j2] - p)) 
                    {
                        
                        result = Math.Abs(mas2[j1] + mas2[j2] - p);
                        Console.WriteLine($"{mas2[j1]} + {mas2[j2]} - {p} = {Math.Abs(mas2[j1] + mas2[j2] - p)}");
                        a = mas2[j1];
                        b = mas2[j2];
                    }
                }
            }

            Console.WriteLine($"{a} + {b} - {p} = {Math.Abs(a + b - p)}");

            Console.ReadKey();
        }
    }
}