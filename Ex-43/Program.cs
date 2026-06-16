using System;

namespace ThisKeywordPart2
{
    class Room
    {
        public string name;
        public int apartment;
        public string luxury;
        public bool flag;
        public Room(string name, int apartment, string luxury)
        {
            this.name = name;
            this.apartment = apartment;
            this.luxury = luxury;
        }
        public void SetFlag(bool flag)
        {
            this.flag = flag;
            Console.WriteLine($"Метод SetFlag вызван. Значение поля flag теперь: {this.flag}");
        }
        public void showOrder()
        {
            int nameWidth = 40;
            int seatsWidth = 8;
            int classWidth = 20;

            string nameFormatted = name.PadRight(nameWidth);
            string seatsFormatted = apartment.ToString().PadLeft(seatsWidth);
            string classFormatted = luxury.PadRight(classWidth);

            Console.WriteLine($"| {nameFormatted} | {seatsFormatted} | {classFormatted} |");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- Демонстрация работы с 'this.' при совпадении имён ---");
            Console.WriteLine("---------------------------------------------------------");
            Room myRoom = new Room("Николай Андреевич Римский-Корсаков", 1, "домик в деревне");
            myRoom.showOrder();
            myRoom.SetFlag(true);

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Программа успешно выполнена. Концепция this.поле изучена.");
        }
    }
}