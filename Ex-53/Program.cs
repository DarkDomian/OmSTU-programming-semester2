using System;

namespace StructuresPart2
{
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Program
    {
        static void DisplayPoint(Point p)
        {
            p.X += 100;
            p.Y *= 12;
            Console.WriteLine("Данные внутри метода: X = " + p.X + ", Y = " + p.Y);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Point myPoint = new Point(10, 25);

            Console.WriteLine("Исходная точка в Main: X = " + myPoint.X + ", Y = " + myPoint.Y);
            Console.WriteLine("--------------------------------------------------");

            DisplayPoint(myPoint);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Точка в Main после метода: X = " + myPoint.X + ", Y = " + myPoint.Y);
        }
    }
}