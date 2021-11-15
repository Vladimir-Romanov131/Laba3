using System;
namespace _1 {
    class Program
    {
         static void Main(string[] args ) 
// Написать программу, которая запрашивает число элементов массива✔, после
// чего создает массив, заполняет его случайными целыми числами в
// диапазоне от -30 до 45✔ и выводит на экран строками по 10 элементов✔.
// Программа должна после этого вывести элементы массива в обратном
// направлении, начиная с последнего, игнорируя отрицательные элементы✔.
        { 

            Random rand = new Random(); // о великий рандом
            Console.WriteLine("Введите колество эмементов в массиве");      
            int kol = int.Parse(Console.ReadLine()); // kol - это тип сокращенное количество, да я оригинален 
            int[] mas = new int[kol];
            for (kol = 0; kol < mas.Length; kol++)
            {
                mas[kol] = rand.Next(-30, 45);
            }
            Console.WriteLine("Элементы массива");   // я убил на это два дня, всем спасибо, я спать
            int j = 0;
            foreach (int element in mas) 
            {
                Console.Write(element + " \t");
                j++;
                while (j > 9)
                {
                    Console.WriteLine();
                    j = 0;
                }
            }
            Console.WriteLine();
            Console.Write("Положительные элементы в обратном порядке "); // я вернулся,  обратный порядок изи, спасибо туториалам
            Console.WriteLine();
            Array.Reverse(mas);
            foreach (int element in mas)
            {
                if(element>0)
                {
                    Console.Write(element + " \t");
                    j++;
                    while (j > 9)
                    {
                        Console.WriteLine();
                        j = 0;
                    }
                }
            }
            
        }
        public static void Reverse (int[] mas){}
    }
}   
