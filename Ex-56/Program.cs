using System;

namespace _56
{
    class Program
    {
        static void Main(string[] args)
        {
            ReferenceClass VS1 = new ReferenceClass(); VS1.k = 10;
            ReferenceClass VS2 = new ReferenceClass(); VS2.k = 5;
            Console.WriteLine("VS1.k = (" + VS1.k + "), VS2.k = (" + VS2.k + ")",
            VS1.k, VS2.k);
            Console.ReadLine();
            VS2.k = VS1.k;
            //VS2 = VS1;
            Console.Write("Оператор VS2 = VS1: ");
            Console.WriteLine("VS1.k = (" + VS1.k + "), VS2.k = (" + VS2.k + ")",
            VS1.k, VS2.k);
            Console.ReadLine();
            VS1.k++;
            Console.Write("Оператор VS1.k++: ");
            Console.WriteLine("VS1.k = (" + VS1.k + "), VS2.k = (" + VS2.k + ")",
            VS1.k, VS2.k);
            Console.ReadLine();
            VS2.k--;
            Console.Write("Оператор VS2--: ");
            Console.WriteLine("VS1.k = (" + VS1.k + "), VS2.k = (" + VS2.k + ")",
            VS1.k, VS2.k);
            Console.ReadLine();
        }
    }

    class ReferenceClass
    {
        public int k;
    }
}