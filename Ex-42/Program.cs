using System;

namespace HotelBookingFinal
{
    class Room
    {
        public string name;      
        public int apartment;    
        public string luxury;    
        public Room()
        {
            name = "???";        
            apartment = 0;
            luxury = "стандарт";
        }
        public Room(string guestName, int seats)
        {
            name = guestName;
            apartment = seats;
            luxury = "стандарт";
        }
        public Room(string guestName, int seats, string roomClass)
        {
            name = guestName;
            apartment = seats;
            luxury = roomClass;
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

            Console.WriteLine("--- Результаты вызовов трех разных конструкторов ---");
            Console.WriteLine("---------------------------------------------------");
            Room roomEmpty = new Room();
            Console.Write("Вызов без параметров:   ");
            roomEmpty.showOrder();
            Room roomTwoArgs = new Room("Николай Андреевич Римский-Корсаков", 1);
            Console.Write("Вызов с 2 аргументами:  ");
            roomTwoArgs.showOrder();
            Room roomThreeArgs = new Room("Антон Павлович Чехов", 3, "люкс");
            Console.Write("Вызов с 3 аргументами:  ");
            roomThreeArgs.showOrder();

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Программа успешно выполнена. Ошибок сборки нет!");
        }
    }
}