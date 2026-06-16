using System;

namespace _105
{
    delegate void PushPrinterButton();
    class Program
    {
        static void Main(string[] args)
        {
            PrintButton printButton = new PrintButton();
            printButton.Click += new PushPrinterButton(StartPrint.OnPrintClick);
            Console.WriteLine("наберите текст");
            Console.CancelKeyPress += new
            ConsoleCancelEventHandler(SomeMethod);
            while (true)
            {
                string temp = Console.ReadLine();
                if (temp != "")
                {
                    StartPrint.text += temp;
                    continue;
                }
                break;
            }
            while (true)
            {
                if (Console.ReadLine() == "p")
                {
                    printButton.DoEvent();
                    break;
                }
            }
        }
        static void SomeMethod(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine(e.Cancel + "\a\a\a\a\a");
        }
    }
    class StartPrint
    {
        public static string text;
        public static void OnPrintClick()
        {
            Console.WriteLine("получите текст:---------------------\n");
        }
    }
    class PrintButton
    {
        public event PushPrinterButton Click;
        public void DoEvent()
        {
            if (Click != null)
                Click();
        }
    }
}