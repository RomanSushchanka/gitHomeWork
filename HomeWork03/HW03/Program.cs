using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14, y = 1, z = 5;

            x += y - x++ * z;

            Console.WriteLine("{0} {1} {2}",x,y,z);

            z = --x - y * 5;

            Console.WriteLine("{0} {1} {2}", x, y, z);

            y /= x + 5 % z;

            Console.WriteLine("{0} {1} {2}", x, y, z);

            z = x++ + y * 5;

            Console.WriteLine("{0} {1} {2}", x, y, z);

            x = y - x++ * z;

            Console.WriteLine("{0} {1} {2}", x, y, z);  //значение z в конце алгоритма равно -56

            Console.ReadKey();
        }
    }
}