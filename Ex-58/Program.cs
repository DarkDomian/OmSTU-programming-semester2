using System;

namespace _58
{
    class Program
    {
        static void Main(string[] args)
        {
            Some some = new Some();
            some.ShowField();
            ChangeType(some);
            some.ShowField();
        }
        static void ChangeType(Some a)
        {
            a.field++;
        }
        class Some
        {
            public int field;
            public void ShowField()
            {
                Console.WriteLine("field = " + field);

                Console.ReadLine();
            }
        }
    }
}