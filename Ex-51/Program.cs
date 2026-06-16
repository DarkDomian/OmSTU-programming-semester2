using System;

namespace ParamsModifierDemo
{
    class Program
    {
        static int CalculateSum(params int[] mass)
        {
            int res = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                res = res + mass[i];
            }

            return res;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- Демонстрация работы модификатора params ---");
            Console.WriteLine("----------------------------------------------");
            int сумма1 = CalculateSum(1, 2, 3, 4, 5);
            Console.WriteLine("Переданы числа: 1, 2, 3, 4, 5");
            Console.WriteLine("Результат вычисления суммы: " + сумма1);
            Console.WriteLine("----------------------------------------------");
            int сумма2 = CalculateSum(6, 7, 8, 9, 10);
            Console.WriteLine("Переданы числа: 6, 7, 8, 9, 10");
            Console.WriteLine("Результат вычисления суммы: " + сумма2);
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Вывод: Модификатор params позволил передать числа напрямую без ручного создания массивов.");
        }
    }
}