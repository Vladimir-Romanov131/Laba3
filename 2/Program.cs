using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
// Написать программу поворота двумерного массива размерности 7х7✔ на 90
// градусов вправо✔ (без использования дополнительных массивов✔).
        {
            Random rnd = new Random();  // о великий рандом
            int [,] mas = new int[10,10];
            int razm = 7; //  7х7 изи
            for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
            {
                for (int j = 0; j < razm; j++)
                {
                    mas[i, j] = rnd.Next(49); // пусть тоже будет как в прошлом задании
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine(); // а как повернуть?
            }
            Console.WriteLine();
            Console.WriteLine("Массив первернут на 90 градусов"); // нижний ряд должен быть слева
            Console.WriteLine();
            int o = 0; // почему бы и нет
            for (int j = 0; j < razm; j++)
            {
                for (int i = 6; i >= o; i--)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine(); // 

            }
        }
    }
}
