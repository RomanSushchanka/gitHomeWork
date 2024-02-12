using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            int index = 0;
        generateRandom:
            array[index] = random.Next(100);
            index++;

            if (index < array.Length)
                goto generateRandom;

            Console.WriteLine("Сгенерированный массив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}