
using System;

namespace _111
{
    class Primer
    {
        static void Main()
        {
            Thread t = new Thread(new ParameterizedThreadStart(Method));
            All all = new All(10, "number 9");
            t.Start(all);
        }
        static void Method(object o)
        {
            All all = o as All;
            for (int i = 0; i < all.i; i++)
            {
                Thread.Sleep(1000);
                Console.Write(all.s + " ");
            }
        }
    }
    class All
    {
        public int i;
        public string s;
        public All(int i, string a)
        {
            this.i = i;
            this.s = a;
        }
    }
}