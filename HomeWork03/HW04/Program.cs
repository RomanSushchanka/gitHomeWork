using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(default(byte));      
            Console.WriteLine(default(sbyte));      
            Console.WriteLine(default(short));      
            Console.WriteLine(default(ushort));    
            Console.WriteLine(default(int));        
            Console.WriteLine(default(uint));      
            Console.WriteLine(default(long));       
            Console.WriteLine(default(ulong));      
            Console.WriteLine(default(float));      
            Console.WriteLine(default(double));     
            Console.WriteLine(default(decimal));
            Console.WriteLine(default(int?));
            Console.WriteLine(default(string));
            Console.WriteLine(default(char));
            Console.WriteLine(default(bool));
        }
    }
}