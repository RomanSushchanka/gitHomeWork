using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141592653;

            Console.WriteLine("Введите радиус основания r:");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите образующую l:");
            double l = double.Parse(Console.ReadLine());

            double S = pi * r * (r + l);

            Console.WriteLine($"Площадь круглого конуса равна: {S}");
            Console.ReadKey();
        }
    }
}