using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_four
{
    class MotoPassengerMinigun : MotoTwoWheels
    {

        public double PowerOfMimigun { get; set; }

        public MotoPassengerMinigun(double PowerOfMinigun, int TypeOfEngine, string Name, double Speed, double Weight)
        {

            this.PowerOfMimigun = PowerOfMinigun;
            base.TypeOfEngine = TypeOfEngine;
            base.Name = Name;
            base.Speed = Speed;
            base.Weight = Weight;

            Console.WriteLine("Число пилотов = " + this.PowerOfMimigun);
            Console.WriteLine("Класс авиации = " + base.TypeOfEngine);
            Console.WriteLine("Название = " + base.Name);
            Console.WriteLine("Скорость =" + base.Speed);
            Console.WriteLine("Вес = " + base.Weight);
            Console.WriteLine();

        }
    }
}
