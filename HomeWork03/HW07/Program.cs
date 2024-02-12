using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 200;
            int b = 500;
            int d = 17;

            int i = 201;
            string result = string.Empty;

            while (i > a & i < b)
            {
                if (i % 17 == 0)
                {
                    if (string.IsNullOrEmpty(result))
                    {
                        result += i.ToString();
                    }
                    else
                    {
                        result += "," + i.ToString();
                    }
                }
                i++;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}