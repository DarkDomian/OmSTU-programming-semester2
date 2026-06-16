using System;

namespace _61
{
    class Program
        {
        static void Main(string[] args)
        {
            SomeStruct SS = new SomeStruct(100);
            Converter(SS);
            Console.ReadLine();
            SomeStruct2 SS2 = new SomeStruct2(50);
            Converter(SS2);
            Console.ReadLine();
        }
        static void Converter(object oo)
        {
            if (oo is SomeStruct)
            {
                SomeStruct SS = (SomeStruct)oo;
                Console.WriteLine("SS.x = ({0})", SS.x);
                return;
            }
            if (oo is SomeStruct2)
            {
                SomeStruct2 SS = (SomeStruct2)oo;
                Console.WriteLine("SS.y = ({0})", SS.y);
                return;
            }
            Console.WriteLine("Вы передали не тип SomeStruct");
        }
        struct SomeStruct
        {
            public int x;
            public SomeStruct(int x)
            {
                this.x = x;
            }
        }
        struct SomeStruct2
        {
            public int y;
            public SomeStruct2(int y)
            {
                this.y = y;
            }
        }
    }
}