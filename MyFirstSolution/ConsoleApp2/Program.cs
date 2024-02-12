using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа через Enter, чтобы найти среднее арифметическое этих чисел:");



            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double d;

            d = (a + b + c) / 3;

            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}

