using System;

namespace _63
{
    class Program
    {
        static void Main()
        {
            Commodity coffee = new Commodity();
            coffee.name = "Jacobs";
            // coffee.Coast.set(12.5f);
            Console.WriteLine("Цена покупки банки кофе составляет " +
            Commodity.Coast + " руб");
            Console.WriteLine("Цена реализации банка кофе составляет " +
            coffee.GetRealPrice() + " руб");

            Console.ReadKey();
        }
        class Commodity
        {
            public string name; //название продукта
            private static float coast; //цена продукта
            public static float Coast
            {
                get { return Commodity.coast; }
                set { coast = value; }
            }
            float percentage = 32.5f;
            public float GetRealPrice()
            {
                return coast + coast * percentage / 100;
                coast = 12f;
            }
        }
    }
}