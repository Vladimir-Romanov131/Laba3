using System;
namespace _6
{
    class Program
    {
        static void Main(string[] args)
// Написать и продемонстрировать работу следующих функций:
//  sumIterative – итерационно вычисляет сумму элементов массива;
//  sumRecursive – рекурсивно вычисляет сумму элементов массива;
//  minIterative – итерационно вычисляет минимальный элемент в массиве;
//  minRecursive – рекурсивно вычисляет минимальный элемент в массиве.
        {
            Console.WriteLine("__________________________________");
            Console.WriteLine("             Массив               ");
            Console.WriteLine("__________________________________");
            Random rnd = new Random();
            int [] mas = new int [131];
            int razm = 5;
            for (int i = 0; i < razm; i++)
            {
                mas[i] = rnd.Next(1,10); 
                Console.Write($"|{mas[i]}|  \t");
            }
            Console.WriteLine();
            Console.WriteLine("__________________________________");
            Console.WriteLine("      Сумма элементов Массива     ");
            int c = sumRecursive(mas);
            Console.WriteLine($"              |{c}|              ");
            Console.WriteLine("__________________________________");
            Console.WriteLine();
            Console.WriteLine("__________________________________");
            Console.WriteLine("   Минимальный элементов Массива  ");
            int min = minRecursive(mas);
            Console.WriteLine($"              |{min}|              ");
            Console.WriteLine("__________________________________");
        }
        static int sumRecursive(int [] mas, int i = 0, int j = 0)
        {
            if(i>=mas.Length)
                return 0;
            int c = sumRecursive(mas,i+1, j +1);
            return mas[i] + c;
            
        }
        static int minRecursive (int [] mas, int i = 0, int j = 0, int min = 0, int razm = 5)
        {
            // min = mas[0];
            if( i < razm)
            {
                if( i <= min )
                min = min + i;
                // min++;
                i++;
                return minRecursive( mas, razm, min, i );
            }
            else
                return min;
            
        }
        










    }
}
