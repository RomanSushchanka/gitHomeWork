using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"Число {a} четное!");
            }

            else
            {
                Console.WriteLine($"Число {a} нечетное!");
            }

            Console.ReadKey();
        }
    }
}