using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_four
{
    class MotoPassengerSpy : MotorOneWheel
    {

        public int LevelOfSpy { get; set; }

        public MotoPassengerSpy(int LevelOfSpy, int TypeOfEngine, string Name, double Speed, double Weight)
        {
            this.LevelOfSpy = LevelOfSpy;
            base.TypeOfEngine = TypeOfEngine;
            base.Name = Name;
            base.Speed = Speed;
            base.Weight = Weight;

            Console.WriteLine("Число пилотов = " + this.LevelOfSpy);
            Console.WriteLine("Класс авиации = " + base.TypeOfEngine);
            Console.WriteLine("Название = " + base.Name);
            Console.WriteLine("Скорость =" + base.Speed);
            Console.WriteLine("Вес = " + base.Weight);
            Console.WriteLine();
        }
    }
}
