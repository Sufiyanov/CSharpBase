using System;
using System.Collections.Generic;

namespace Expr4
{
    class Program
    {
        static void Main()
        {
            //Expr4. Найти количество чисел меньших N, которые имеют простые делители X или Y.
            int N = int.Parse(Console.ReadLine());
            int x = 3;
            int y = 5;
            var list1 = searchNumber(x, N); 
            var list2 = searchNumber(y, N);
            Console.WriteLine(removeSame(list1, list2));
            Console.ReadKey();
        }
        static List<int> searchNumber(int x, int N)
        {
            //Поиск чисел 
            var list = new List<int>();
            for (int i = 1; x * i < N; i++) {
                list.Add(x * i);
            }
            return list;
        }
        static int removeSame(List<int> list1, List<int> list2)
        {
            // Проверка массива на одинаковые числа
            foreach (int j in list2)
            {
                if (!list1.Contains(j))
                {
                    list1.Add(j);
                }
            }
            return list1.Count;
        }
    }
}