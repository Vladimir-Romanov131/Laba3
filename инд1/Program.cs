using System;
namespace инд1
{
    class Program
    {
        static void Main(string[] args)
// Написать программу, заполняющую и отображающую на экране двумерный
// массив 9х9, в соответствии с вариантом    
// Заполнить матрицу линейной последовательностью чисел,
// от центра по спирали: влево - вниз - вправо - вверх.✔
        {
            int [,] mas = new int[131,131]; // 131 любимое число, могу себе позволить 
            int razm = 9;
            int i1 = 81;
            int sx = 0; // горизонт
            int sy = 0; // вертикаль 
            int x = razm - 1;
            int y = razm - 1;
            while(sx<= x && sy<=y)
            {
                for(int i = sx; i <= x; i++)
                {
                    mas[sy,i] = i1;
                    i1--;
                }
                sy++;
                for(int j = sy; j <= y; j++)
                {
                    mas[j,x] = i1;
                    i1--;
                }
                x--;
                for(int i = x; i >= sx; i--)
                {
                    mas[y,i] = i1;
                    i1--;
                }
                y--;
                for(int i = y; i >= sy; i--)
                {
                    mas[i,sx] = i1;
                    i1--;

                }
                sx++;
            }
            for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
            {
                for (int j = 0; j < razm; j++)
                {
                    Console.Write($"|{mas[i, j]}|  \t");
                }
                Console.WriteLine(); // а как повернуть?
            }



            
        }
    }
}
