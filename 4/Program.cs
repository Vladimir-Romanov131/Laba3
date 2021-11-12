using System;
namespace _4
{
    class Program
    {
        static void Main(string[] args)
// Написать функции для поэлементного сложения и вычитания двумерных
// массивов 3х3✔. Функции должны принимать массивы в качестве параметров
// и выдавать результирующий массив в качестве возвращаемого значения✔. В
// третьем параметре функции необходимо вернуть среднее значение всех
// элементов входных массивов✔.
        {
            Console.WriteLine("__________________________________");
            Console.WriteLine("         Первая матрица           ");
            Console.WriteLine("__________________________________");
            Random rnd = new Random();  // о великий рандом
            int [,] mas = new int[131,131]; // 131 любимое число, могу себе позволить 
            int razm = 3;
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
            Console.WriteLine("________________________________________");
            Console.WriteLine("            Выберите действие           ");
            Console.WriteLine("________________________________________");
            Console.WriteLine("   Для выбора действия напишите цифру   ");
            Console.WriteLine("________________________________________");
            Console.WriteLine(" 1.Сумма 2.Разность. 3.Среднее значение ");
            Console.WriteLine("________________________________________");
            int n = int.Parse(Console.ReadLine());
            if(n == 1)
            {
                int [,] massum = new int[131,131];
                Console.WriteLine("__________________________________");
                Console.WriteLine("           Сумма матриц           ");
                Console.WriteLine("__________________________________");
                for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
                {
                    for (int j = 0; j < razm; j++)
                    { 
                        massum [i,j] = mas[i,j] + mas1[i,j];

                        Console.Write($"|{massum[i, j]}|  \t");
                    }
                    Console.WriteLine(); 
                }
            }
            if(n == 2)
            {      
                int [,] masraz = new int[131,131];
                Console.WriteLine("__________________________________");
                Console.WriteLine("          Разница матриц          ");
                Console.WriteLine("__________________________________");
                for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
                {
                    for (int j = 0; j < razm; j++)
                    { 
                        masraz [i,j] = mas[i,j] - mas1[i,j];

                        Console.Write($"|{masraz[i, j]}|  \t");
                    }
                    Console.WriteLine(); 
                }
            }
            if(n==3)
            {
                int [,] masred = new int[131,131];
                Console.WriteLine("__________________________________");
                Console.WriteLine("      Среднее значение матриц     ");
                Console.WriteLine("__________________________________");
                for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
                {
                    for (int j = 0; j < razm; j++)
                    { 
                        masred [i,j] = (mas[i,j] + mas1[i,j]) / 2;

                        Console.Write($"|{masred[i, j]}|  \t");
                    }
                    Console.WriteLine(); 
                }
            }
        }
    }
}
