using System;

namespace _59
{
    class Program
    {
        static void Main(string[] args)
        {
            Some some;
            some = new Some();
            some.ShowField();
            ChangeType(ref some);
            some.ShowField();
        }
        static void ChangeType(ref Some s)
        {
            s.field++;
            s = new Some();

            s.field = 500;
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