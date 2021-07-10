using System; 

namespace ConsoleApp1
{
    class task2
    {
        static void Main()
        {
            /*Вывести на экран прямоугольник, заполненный буквами А. 
              Количество строк в прямоугольнике равно 5, количество столбцов равно 8.
            */
            for (int i = 0; i < 6; i++) 
            {
                for (int s = 0; s < 8; s++)
                {
                    Console.Write("A ");
                }
                Console.WriteLine();

            } 
            Console.ReadKey();
        }
    }
}