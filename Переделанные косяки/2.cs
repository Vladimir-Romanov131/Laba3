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
                    mas[i, j] = rnd.Next(10); 
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine(); // а как повернуть?
            }
            Console.WriteLine();
            Console.WriteLine("Массив первернут на 90 градусов"); // нижний ряд должен быть слева
            Console.WriteLine();
            int o = 0; // почему бы и нет
            int [,] mas90 = new int[7,7];
            for (int i = 0; i < razm; i++)
            {
                for (int j = 0; j < razm; j++)
                {
                    mas90[i,j] = mas[razm -1 - j, i ];
                    Console.Write(mas90[i, j] + "\t");
                }
                Console.WriteLine(); // 

            }
        }
    }
}
// помойка идей....................................................................................
// string[,] matrix = {
//     {"0", "1", "0", "0"},
//     {"0", "1", "0", "0"},
//     {"1", "1", "1", "1"},
//     {"0", "1", "0", "0"}
// };
// for (int i = 0; i < matrix.GetLength(0); i++) 
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) 
//     {
//         matrix[i, j] = matrix[j, i];
//         Console.Write(matrix[i, j] + "\t");

//     }
// }