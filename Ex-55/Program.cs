using System;

namespace ValueAndReferenceTypes
{
    // Определение структуры
    struct ValueStruct
    {
        public int K;
    }

    // Определение класса
    class RefClass
    {
        public int K;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ValueStruct VS1;
            VS1.K = 10;
            ValueStruct VS2 = VS1;

            VS1.K = 11;
            VS2.K = 9;

            Console.WriteLine("VS1.K = " + VS1.K);
            Console.WriteLine("VS2.K = " + VS2.K);
            Console.WriteLine("----------------");

            RefClass RC1 = new RefClass();
            RC1.K = 10;
            RefClass RC2 = RC1;

            RC1.K = 15;

            Console.WriteLine("RC1.K = " + RC1.K);
            Console.WriteLine("RC2.K = " + RC2.K);
        }
    }
}