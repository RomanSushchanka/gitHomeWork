using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ (W, S, A, D):");
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine();

            switch (symbol)
            {
                case 'W':
                    Console.WriteLine("Переместить фигуру вверх");
                    break;
                case 'S':
                    Console.WriteLine("Переместить фигуру вниз");
                    break;
                case 'A':
                    Console.WriteLine("Переместить фигуру влево");
                    break;
                case 'D':
                    Console.WriteLine("Переместить фигуру вправо");
                    break;
                default:
                    Console.WriteLine("Нет необходимости в перемещении");
                    break;
            }
        }
    }
}