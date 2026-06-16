using System;

namespace StructuresPart2
{
    struct Point
    {
        public int X;
        public int Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- Различия в инициализации структур ---");
            Console.WriteLine("-----------------------------------------");
            Point point1;
            point1.X = 10;
            point1.Y = 0;

            Console.WriteLine("Точка 1 (инициализирована вручную в стеке):");
            Console.WriteLine($"X = {point1.X}, Y = {point1.Y}");
            Console.WriteLine("-----------------------------------------");
            Point point2 = new Point();

            Console.WriteLine("Точка 2 (подстрахована конструктором по умолчанию):");
            Console.WriteLine($"X = {point2.X}, Y = {point2.Y} (автоматические нули)");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Вывод: Структура хранит данные прямо в стеке. Использование ");
            Console.WriteLine("конструктора гарантирует, что переменные не останутся пустыми.");
        }
    }
}