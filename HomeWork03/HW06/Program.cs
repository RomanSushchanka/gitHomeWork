using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int units = number % 10;
        int tens = (number / 10) % 10;
        int hundreds = number / 100;

        int sumOfNumbers = units + tens + hundreds;
        int productOfNumbers = units * tens * hundreds;

        Console.WriteLine("Число единиц: " + units);
        Console.WriteLine("Число десятков: " + tens);
        Console.WriteLine("Сумма цифр: " + sumOfNumbers);
        Console.WriteLine("Произведение цифр: " + productOfNumbers);

        Console.ReadKey();
    }
}