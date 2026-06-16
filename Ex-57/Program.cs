using System;

namespace _57
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRectangle r1 = new MyRectangle("This is my first rect");
            MyRectangle r2;
            r2 = r1;
            Console.WriteLine("r1.top = (" + r1.top + "), r1.left = (" + r1.left + "), r1.bottom = (" + r1.bottom + "), r1.right = (" + r1.right + ")\n r1.rectInfo.infoString = (" + r1.rectInfo.infoString + ")");
            Console.WriteLine("\n\nr2.top = (" + r2.top + "), r2.left = (" + r2.left + "), r2.bottom = (" + r2.bottom + "), r2.right = (" + r2.right + ")\n r2.rectInfo.infoString = (" + r2.rectInfo.infoString + ")");
            Console.ReadLine();
            r2.left = r2.right = r2.top = r2.bottom = 1000;
            r1.left = r1.right = r1.top = r1.bottom = -9;
            Console.WriteLine("r1.top = (" + r1.top + "), r1.left = (" + r1.left + "), r1.bottom = (" + r1.bottom + "), r1.right = (" + r1.right + ")\n r1.rectInfo.infoString = (" + r1.rectInfo.infoString + ")");
            Console.WriteLine("\n\nr2.top = (" + r2.top + "), r2.left = (" + r2.left + "), r2.bottom = (" + r2.bottom + "), r2.right = (" + r2.right + ")\n r2.rectInfo.infoString = (" + r2.rectInfo.infoString + ")");
            Console.ReadLine();
        }
    }
    class ShapeInfo
    {
        public string infoString;
        public ShapeInfo(string info)
        {
            infoString = info;
        }
    }
    struct MyRectangle
    {
        public ShapeInfo rectInfo;
        public int top, left, bottom, right;
        public MyRectangle(string info)
        {
            rectInfo = new ShapeInfo(info);
            top = left = 10;
            bottom = right = 100;
        }
    }
}