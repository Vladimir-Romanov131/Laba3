using System;
namespace _7
{
    class Program
    {
        static void Main(string[] args)
// Написать рекурсивную функцию для нахождения n-ого члена ряда
// Фибоначчи по формулам, приведенным в лабораторной работе No2.✔
        { 
            Console.WriteLine("________________________________________");
            Console.WriteLine("Введите порядковый номер числа Фибоначчи");
            Console.WriteLine("________________________________________");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("________________________________________");
            Console.WriteLine("    Порядковый номер числа Фибоначчи    ");
            Console.WriteLine($"                {fib(n)}               ");
            Console.WriteLine("________________________________________");
        }
        static int fib(int n)
        {
            if (n == 0) return 0;
                if (n == 1 || n == 2) return 1;

            return fib(n - 2) + fib(n - 1);
        }
    }
}
