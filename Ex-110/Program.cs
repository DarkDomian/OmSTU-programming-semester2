using System;

namespace _110
{
    class Primer
    {
        static void Main()
        {
            Thread thread = new Thread(Method);
            thread.Priority = ThreadPriority.Highest;
            thread.Start();
            while (true)
            {
                Console.Write("!!!");
                Thread.Sleep(500);
            }
        }
        static void Method()
        {
            while (true)
            {
                Thread.Sleep(250);
                Console.Write("___");
            }
        }
    }
}
