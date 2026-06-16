using System;

namespace MyCalculator
{
    class Calculator
    {
        private void instructions()
        {
            Console.WriteLine("\n--- Инструкция по работе с калькулятором ---");
            Console.WriteLine("Доступные операции: +, -, *, /, ^");
            Console.WriteLine("Нажмите Q для выхода из программы");
            Console.WriteLine("--------------------------------------------");
        }
        public void Go()
        {
            instructions();
            bool isQuit = false;
            do
            {
                Console.Write("\nВведите операцию (+, -, *, /, ^) или Q: ");
                string operation = Console.ReadLine().ToUpper(); 
                switch (operation)
                {
                    case "Q":
                        Console.WriteLine("До свидания!");
                        isQuit = true; 
                        break;

                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    case "^":
                        Console.Write("Введите первое число: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        if (operation == "+") Console.WriteLine($"Результат: {num1 + num2}");
                        if (operation == "-") Console.WriteLine($"Результат: {num1 - num2}");
                        if (operation == "*") Console.WriteLine($"Результат: {num1 * num2}");
                        if (operation == "/")
                        {
                            if (num2 != 0) Console.WriteLine($"Результат: {num1 / num2}");
                            else Console.WriteLine("Ошибка! На ноль делить нельзя.");
                        }
                        if (operation == "^") Console.WriteLine($"Результат: {Math.Pow(num1, num2)}");
                        break;

                    default:
                        Console.WriteLine("Ошибка! Недопустимый символ.");
                        instructions();
                        break;
                }

            } while (!isQuit); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Calculator myCalc = new Calculator();
            myCalc.Go();
            Console.WriteLine("\nНажмите ENTER для выхода из консоли...");
            Console.ReadLine();
        }
    }
}