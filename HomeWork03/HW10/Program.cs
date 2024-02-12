using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool CalculateIncomeTax(double income, out double taxAmount)
            {
                // Ваш код для расчета налога на доход

                // Предположим, что налоговая ставка составляет 20%
                double taxRate = 0.2;

                // Рассчитываем налог на доход
                taxAmount = income * taxRate;

                // Возвращаем true, чтобы указать, что расчет был выполнен успешно
                return true;
            }

            // Пример использования функции
            double income = 5000;
            double tax;

            if (CalculateIncomeTax(income, out tax))
            {
                Console.WriteLine($"Налог на доход составляет: {tax}");
            }
            else
            {
                Console.WriteLine("Не удалось выполнить расчет налога на доход.");
            }
        }
    }
}