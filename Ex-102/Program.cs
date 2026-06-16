using System;

namespace _102
{
    delegate BaseClass Del(string name);
    class Program
    {
        static void Main(string[] args)
        {
            Del del = new Del(Method);
            SomeClass BC = (SomeClass)del("Name for SomeClass");
            Console.WriteLine(BC.name);
            Console.ReadKey();
        }
        static SomeClass Method(string name)
        {
            return new SomeClass(name);
        }
    }
    class BaseClass
    {
        public string name;
        public BaseClass(string name)
        {

            this.name = name;
        }
        public BaseClass()
        { }
    }
    class SomeClass : BaseClass
    {
        public SomeClass(string name)
        {
            this.name = name;
        }
    }
}