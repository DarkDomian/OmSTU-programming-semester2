using System;

namespace _103
{
    delegate void Del();
    class Program
    {
        static void Main(string[] args)
        {
            Del del = new Del(M1);
            del += M2;

            Mdel(del);
        }
        static void M1()
        {
            Console.WriteLine("Это метод №1");
            Console.ReadLine();
        }
        static void M2()
        {
            Console.WriteLine("Это метод №2");
            Console.ReadLine();
        }
        static void Mdel(Del d)
        {
            Console.WriteLine("Передача делегата в качестве параметра");
            d();
        }
    }
}