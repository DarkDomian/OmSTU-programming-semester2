using System;

namespace OutModifierPart2
{
    class Program
    {
        static string CalculateAndReturnText(out int I, out int G)
        {
            I = 10;
            G = I + 1;
            if (G > 1)
            {
                return "Успех! Переменная G больше единицы. Значения: I=" + I + ", G=" + G;
            }
            else
            {
                return "Альтернативный путь (условие не выполнено)";
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int firstArc;
            int secondArc;

            Console.WriteLine("Вызываем метод, который возвращает строку И заполняет out-параметры:");
            Console.WriteLine("-----------------------------------------------------------------");
            string message = CalculateAndReturnText(out firstArc, out secondArc);
            Console.WriteLine("Текст, который вернул метод: " + message);
            Console.WriteLine("Значение внутри firstArc: " + firstArc);
            Console.WriteLine("Значение внутри secondArc: " + secondArc);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Вывод: C# дает свободу сочетать return и модификаторы out/ref.");
        }
    }
}