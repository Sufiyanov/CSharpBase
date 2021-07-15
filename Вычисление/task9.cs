using System;

namespace ConsoleApp1
{
    class task9
    {
        static void Main()
        {
            /*Дана дата из трех чисел (день, месяц и год). 
              Вывести yes, если такая дата существует (например, 12 02 1999 - yes, 22 13 2001 - no). 
              Считать, что в феврале всегда 28 дней.
            */
            string lineBracket = "[[[[[[[[[[[[[[[ ]]]]]]]]]]]]]]]";
            string lineCaB1 = "[:::::::::::::: ::::::::::::::]";
            string lineCaB2 = "[::::::[[[[[[[: :]]]]]]]::::::]";
            string black = "       ЧЕРНЫЙ    ";
            string squere = "      КВАДРАТ    ";
            string empty = "                 ";
            int i = 0;
            while (i < 18)
            {
                if (i == 0 || i == 17) Console.WriteLine(lineBracket);
                if (i == 2 || i == 3 || i == 2 || i == 15 || i == 16) Console.WriteLine(lineCaB1);
                if (i == 4 || i == 14 ) Console.WriteLine(lineCaB2);
                if (i >= 5 && i <= 13 && i != 8 && i != 9) Console.WriteLine($"[:::::[{empty}]:::::]");
                if (i == 8) Console.WriteLine($"[:::::[{black}]:::::]");
                if (i == 9) Console.WriteLine($"[:::::[{squere}]:::::]");
                i++;
            }
            Console.ReadKey();
        }
    }
}