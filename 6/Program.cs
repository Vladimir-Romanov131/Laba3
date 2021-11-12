using System;
namespace _6
{
    class Program
    {
        static void Main(string[] args)
// Написать и продемонстрировать работу следующих функций:
//  sumIterative – итерационно вычисляет сумму элементов массива;✔
//  sumRecursive – рекурсивно вычисляет сумму элементов массива;✔
//  minIterative – итерационно вычисляет минимальный элемент в массиве;✔
//  minRecursive – рекурсивно вычисляет минимальный элемент в массиве.
        {
            Console.WriteLine("__________________________________");
            Console.WriteLine("             Массив               ");
            Console.WriteLine("__________________________________");
            Random rnd = new Random();
            int [] mas = new int [131];
            int razm = 5;
            for (int i = 0; i < razm; i++) //массив
            {
                mas[i] = rnd.Next(1,10); 
                Console.Write($"|{mas[i]}|  \t");
            }
            Console.WriteLine();
            // Console.WriteLine("   Минимальный элементов Массива  ");
            // int min = minRecursive(mas);
            // Console.WriteLine($"              |{min}|              ");
            // Console.WriteLine("__________________________________");
            int r = 0;
            for (int i = 0; i < razm; i++)
            { 
                r = r + mas[i];  
            }
            int minn = mas[0];
            int maxx = mas[0];
            for (int i = 0; i < razm; i++)
            { 
                if(mas[i] > maxx)
                {
                    maxx = mas[i];
                }    
                if(mas[i] < minn)
                { 
                    minn = mas[i];
                } 
            }
            Console.WriteLine("__________________________________");
            Console.WriteLine("      Сумма элементов Массива     ");
            int c = sumRecursive(mas);
            Console.WriteLine($"              |{c}|.R.           ");
            Console.WriteLine("__________________________________");
            Console.WriteLine("      Сумма элементов Массива     ");
            Console.WriteLine($"              |{r}|              ");
            Console.WriteLine("__________________________________");
            Console.WriteLine("    Минимальный элемент Массива   ");
            Console.WriteLine($"              |{minn}|           ");
            Console.WriteLine("__________________________________");
            Console.WriteLine("    Минимальный элемент Массива   ");
            int min = minRecursive(mas);
            Console.WriteLine($"              |{min}|.R          ");
            Console.WriteLine("__________________________________");

        }
        static int sumRecursive(int [] mas, int i = 0, int j = 0)
        {
            if(i>=mas.Length)
                return 0;
            int c = sumRecursive(mas,i+1, j +1);
            return mas[i] + c; 
        }
        static int minRecursive(int [] mas, int i = 0, int min =0)
        {
            int razm =5;
            min = mas[0];
            if (i == 0)
                return mas[0];
            i--; 
            if(mas[0] > mas[i])
            mas[0] = mas[i];
            mas[0] = min;
            return minRecursive( mas, i, min);
        }
    }
}
