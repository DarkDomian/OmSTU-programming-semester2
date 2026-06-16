using System;

namespace _104
{

    delegate void PushPrinterButton(); //объявление делегата
    class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse = new Mouse();
            //подписались на событие с указанием конкретного метода
            mouse.Click += new PushPrinterButton(mouse.OnMouseClick);
            //.............
            mouse.DoEvent(); //вызываем событие
        }
    }
    class Mouse
    {
        public event PushPrinterButton Click; //объявим событие о нажатии кнопки мыши
        public void DoEvent() //генерация события
        {
            if (Click != null)
                Click(); //запуск события
        }
        public void OnMouseClick() //обработчик события
        {
            Console.WriteLine("Происходит нажатие кнопки мыши по кнопке печати.\nНачинается печать...");
            Console.ReadLine();
        }
    }
}
