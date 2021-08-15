using System;

namespace ConsoleApp1
{
    class task15
    {
        static void Main()
        {
            //Metanit
            // С помощью циклов переберите все элементы этого массива и выведите их на консоль в следующем виде:
            //{{{1 , 2} , {3 , 4}} , {{4 , 5} , {6 , 7}} , {{7 , 8}, {9 , 10}} , {{10 , 11} , {12 , 13}}}

            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };

            int checkOld = 0;
            Console.Write('{');
            for (int t = 0; t <= mas.GetUpperBound(0); t++) 
            {
                Console.Write('{');
                for (int i = 0; i <= mas.GetUpperBound(1); i++) 
                {
                    Console.Write('{');
                    for (int j = 0; j <= mas.GetUpperBound(2); j++) 
                    {
                        Console.Write(mas[t, i, j]);
                        if (j != mas.GetUpperBound(2)) Console.Write(" , ");
                        checkOld++;
                    }
                    Console.Write("}");
                    if (i != mas.GetUpperBound(1)) Console.Write(" , ");
                }
                Console.Write("}");
                if (t != mas.GetUpperBound(2) && mas.Length != checkOld) Console.Write(" , ");
            }
            Console.Write("}");
            Console.ReadKey();
        }
    }
}