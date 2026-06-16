using System;

namespace _109
{
    class Primer
    {
        static void Main()
        {
            SomeClass sc = new SomeClass();
            Thread thread = new Thread(sc.JustMethod);
            thread.Start();
            sc.JustMethod();
            Console.Read();
        }
    }
    class SomeClass
    {
        bool flag = false;
        public void JustMethod()
        {
            flag = !flag;
            Console.WriteLine("flag = {0}", flag);
        }
    }
}