using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_four
{
    class MotoPassengerHealer : MotoTwoWheels
    {
        public double PowerOfHealing { get; set; }

        public MotoPassengerHealer(double PowerOfHealing, int TypeOfEngine, string Name, double Speed, double Weight )
        {

            this.PowerOfHealing = PowerOfHealing;
            base.TypeOfEngine = TypeOfEngine;
            base.Name = Name;
            base.Speed = Speed;
            base.Weight = Weight;

            Console.WriteLine("Число пилотов = " + this.PowerOfHealing);
            Console.WriteLine("Класс авиации = " + base.TypeOfEngine);
            Console.WriteLine("Название = " + base.Name);
            Console.WriteLine("Скорость =" + base.Speed);
            Console.WriteLine("Вес = " + base.Weight);
            Console.WriteLine();
        }
    }
}
