using System;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
// Написать программу циклического сдвига массива на k позиций влево.✔ 
// ничего не понял, но очень интересно 
//--------------------------------------------------------------------------------------------------------
//1 2 3|2 3 1 вроде так 
//4 5 6|5 7 4 сдвиг на один влево
//7 8 9|8 9 7 j  + 1 (1,4,7) = 0 (2,5,8)=1 (3,6,9)=2
        {
            Console.WriteLine("__________________________________________");
            Console.WriteLine($"           Изначальный массив            ");
            Console.WriteLine("__________________________________________");
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
            Console.WriteLine("__________________________________________________________");
            int Tmp = mas[0,0];
            int Tmp1 = mas[0,1];
            int Tmp2 = mas[0,2];
            int Tmp3 = mas[0,3];
            int Tmp4 = mas[0,4];
            Console.WriteLine("Введите число на сколько массив должен быть сдвинут влево ");
            Console.WriteLine("__________________________________________________________");
            int n = int.Parse(Console.ReadLine());
            int N = n;
            while(N>10)
            {
                N = N - 5;
            }
            if(N>5)
            {
                N = N - 5;
            }
            Console.WriteLine("__________________________________________");
            Console.WriteLine($"Массив сдвинут в лево на: {n} раз влево");
            Console.WriteLine("__________________________________________");
            if(N == 1)
            {
                 for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
                {
                    Tmp = mas[i,0];
                    Tmp1 = mas[i,1];
                    Tmp2 = mas[i,2];
                    Tmp3 = mas[i,3];
                    Tmp4 = mas[i,4];
                    for (int j = 0; j < razm; j++)
                    {
                        mas[i,j ] = mas[i,j+1];
                        // mas[i,5-3] = Tmp4;
                        // mas[i,5-1] = Tmp3;
                        // mas[i,5-1] = Tmp2;
                        // mas[i,5-1] = Tmp1;
                        mas[i,5] = Tmp;
                        Console.Write($"|{mas[i, j]}|  \t");
                    }
                    Console.WriteLine(); // а как повернуть?
                }
                Console.WriteLine("__________________________________________");
            }
            
            else if(N == 2)
            {
                  for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
                {
                    Tmp = mas[i,0];
                    Tmp1 = mas[i,1];
                    Tmp2 = mas[i,2];
                    Tmp3 = mas[i,3];
                    Tmp4 = mas[i,4];
                
                    for (int j = 0; j < razm; j++) 
                    {
                        mas[i,j ] = mas[i,j+2];
                        mas[i,5-3] = Tmp4;
                        mas[i,5-1] = Tmp3;
                        mas[i,5-1] = Tmp2;
                        mas[i,5-1] = Tmp1;
                        mas[i,5] = Tmp;

                        

                        Console.Write($"|{mas[i, j]}|  \t");

                    }
                    Console.WriteLine(); // а как повернуть?
                }  
                Console.WriteLine("__________________________________________");  

            }
            else if(N == 3)
            {
                for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
                {
                    Tmp = mas[i,0];
                    Tmp1 = mas[i,1];
                    Tmp2 = mas[i,2];
                    Tmp3 = mas[i,3];
                    Tmp4 = mas[i,4];
                    for (int j = 0; j < razm; j++)
                    {
                        mas[i,j ] = mas[i,j+3];
                        mas[i,5-4] = Tmp4;
                        mas[i,5-2] = Tmp3;
                        mas[i,5-1] = Tmp2;
                        mas[i,5-2] = Tmp1;
                        mas[i,5-3] = Tmp;

                        

                        Console.Write($"|{mas[i, j]}|  \t");

                    }
                    Console.WriteLine(); // а как повернуть?
                }
                Console.WriteLine("__________________________________________");

            }
            else if(N == 4)
            {
                for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
                {
                    Tmp = mas[i,0];
                    Tmp1 = mas[i,1];
                    Tmp2 = mas[i,2];
                    Tmp3 = mas[i,3];
                    Tmp4 = mas[i,4];
                
                    for (int j = 0; j < razm; j++) 
                    {
                        mas[i,j ] = mas[i,j+4];
                        mas[i,5-3] = Tmp4;
                        mas[i,5-1] = Tmp3;
                        mas[i,5-2] = Tmp2;
                        mas[i,5-3] = Tmp1;
                        mas[i,5-4] = Tmp;
                        Console.Write($"|{mas[i, j]}|  \t");
                    }
                    Console.WriteLine(); // а как повернуть?
                }
                Console.WriteLine("__________________________________________");
            }
            else if(N == 5)
            {
                for (int i = 0; i < razm; i++) // Ctrl+C \\ Ctr + V \\ из прошлого задания не карается ? надеюсь нет
                {
                    Tmp = mas[i,0];
                    Tmp1 = mas[i,1];
                    Tmp2 = mas[i,2];
                    Tmp3 = mas[i,3];
                    Tmp4 = mas[i,4];
                    for (int j = 0; j < razm; j++)
                    {
                        mas[i,j ] = mas[i,j];
                        // mas[i,5-3] = Tmp4;
                        // mas[i,5-1] = Tmp3;
                        // mas[i,5-1] = Tmp2;
                        // mas[i,5-1] = Tmp1;
                        // mas[i,5] = Tmp;
                        Console.Write($"|{mas[i, j]}|  \t");
                    }
                    Console.WriteLine(); // а как повернуть?
                }
                Console.WriteLine("__________________________________________");
            }  
        }
    }
}
