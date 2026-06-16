using System;

namespace _64
{
    class Program
    {
        static void Main()
        {
            Sooruzhenie Soorud = new Sooruzhenie();
            GiloDom Gdom = new GiloDom();
            ChastnijDom ChastDom = new ChastnijDom();
            Sooruzhenie Soorud2 = new Sooruzhenie();
            Console.WriteLine("Soorud.ploshad = ({0}), Soorud2.ploshad = ({1}), Gdom.ploshad = ({2}), ChastDom.ploshad = ({3}), Soorud2.ploshad", Soorud.ploshad, Soorud2.ploshad, Gdom.ploshad, ChastDom.ploshad, Soorud2.ploshad);
            Console.ReadLine();
            Soorud.ploshad = 10;
            Soorud2.ploshad = 15;
            ChastDom.ploshad = 5;
            Gdom.ploshad = 1;
            Console.WriteLine("Soorud.ploshad = ({0}), Soorud2.ploshad = ({1}), Gdom.ploshad = ({2}), ChastDom.ploshad = ({3}), Soorud2.ploshad", Soorud.ploshad, Soorud2.ploshad, Gdom.ploshad, ChastDom.ploshad, Soorud2.ploshad);
            Console.ReadLine();
        }
    }
    class Sooruzhenie
    {
        public int ploshad;
        protected int visota;
        public bool stagnorn;
    }
    class GiloDom : Sooruzhenie
    {
        public bool podlesdi;
    }
    class ChastnijDom : GiloDom
    {
        int ploshadUcastka;
    }
}