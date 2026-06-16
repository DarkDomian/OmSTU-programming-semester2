using System;

namespace ReferenceParametersDemo
{
    class Work
    {
        public void ChangeByValue(int number, bool flag)
        {
            number = number * 2;
            flag = !flag;
        }
        public void ChangeByRef(ref int number, ref bool flag)
        {
            number = number * 2;
            flag = !flag;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Work myWork = new Work();
            int a = 10;
            bool b = true;

            Console.WriteLine($"Исходные значения в Main: a = {a}, b = {b}");
            Console.WriteLine("------------------------------------------------");
            myWork.ChangeByValue(a, b);
            Console.WriteLine("Вызван метод ChangeByValue (передача по значению).");
            Console.WriteLine($"Значения в Main ПОСЛЕ вызова: a = {a}, b = {b} (НЕ изменились)");
            Console.WriteLine("------------------------------------------------");
            myWork.ChangeByRef(ref a, ref b);
            Console.WriteLine("Вызван метод ChangeByRef (передача по ссылке через ref).");
            Console.WriteLine($"Значения в Main ПОСЛЕ вызова: a = {a}, b = {b} (ИЗМЕНИЛИСЬ!)");
            Console.WriteLine("------------------------------------------------");
        }
    }
}
