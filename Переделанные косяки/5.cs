using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
// Написать программу перемножения двух матриц 5х5.✔
            Console.WriteLine("__________________________________");
            Console.WriteLine("         Первая матрица           ");
            Console.WriteLine("__________________________________");
            Random rnd = new Random();  // о великий рандом
            int [,] mas = new int[131,131]; // 131 любимое число, могу себе позволить 
            int razm = 5;
            for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
            {
                for (int j = 0; j < razm; j++)
                {
                    mas[i, j] = rnd.Next(10); 
                    Console.Write($"|{mas[i, j]}|  \t");
                }
                Console.WriteLine(); // а как повернуть?
            }
            Console.WriteLine("__________________________________");
            Console.WriteLine("          Вторая матрица          ");
            Console.WriteLine("__________________________________");
            int [,] mas1 = new int[131,131]; // 131 любимое число, могу себе позволить 
            for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
            {
                for (int j = 0; j < razm; j++)
                {
                    mas1[i, j] = rnd.Next(10); 
                    Console.Write($"|{mas1[i, j]}|  \t");
                }
                Console.WriteLine(); 
            }
            Console.WriteLine("__________________________________");
            Console.WriteLine("   Результат умножения матриц     ");
            Console.WriteLine("__________________________________");
            int [,] Smas = new int[131,131]; // 131 любимое число, могу себе позволить 
            for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
            {
                for (int j = 0; j < razm; j++)
                {
                    for (int k = 0; k< razm; k++)
                    {
                        Smas[i,j] = mas1[i, k] *  mas[k,j];
                    }    
                }
                Console.WriteLine(); 
            }for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
            {
                for (int j = 0; j < razm; j++)
                {
                    Console.Write($"|{Smas[i, j]}|  \t"); 
                }
                Console.WriteLine(); 
            }







        }
    }
}
