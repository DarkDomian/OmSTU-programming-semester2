using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _65
{
    class Program
    {
        static void Main()
        {
            SportCar SC = new SportCar("green", 2000, 250, 7, true);
            Console.WriteLine("SC.color = ({0}), SC.power = ({1}), SC.weight = ({2}), SC.transmission = ({3}), SC.complete_drive = ({4})", SC.color, SC.power, SC.weight, SC.transmission, SC.complete_drive);
            Console.ReadLine();
        }
        class Car
        {
            public string color;
            public int weight;
            public int power;
            public Car(string color, int weight, int power)
            {
                this.color = color;
                this.weight = weight;
                this.power = power;
            }
        }
        class SportCar : Car
        {
            public short transmission;
            public bool complete_drive;
            public SportCar(string color, int weight, int power, short transmission, bool
            complete_drive)
            : base(color, weight, power)
            {
                this.transmission = transmission;
                this.complete_drive = complete_drive;
            }
        }
    }
}