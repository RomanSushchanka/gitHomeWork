using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой рост в см:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"Название переменной: {nameof(height)}; Значение: {height}");
            Console.ReadKey();
        }
    }
}