using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_four
{
    class MotoPassengerScout : MotorOneWheel
    {
        public int QualityOfScout { get; set; }

        public MotoPassengerScout(int QualityOfScout, int TypeOfEngine, string Name, double Speed, double Weight)
        {

            this.QualityOfScout = QualityOfScout;
            base.TypeOfEngine = TypeOfEngine;
            base.Name = Name;
            base.Speed = Speed;
            base.Weight = Weight;

            Console.WriteLine("Число пилотов = " + this.QualityOfScout);
            Console.WriteLine("Класс авиации = " + base.TypeOfEngine);
            Console.WriteLine("Название = " + base.Name);
            Console.WriteLine("Скорость =" + base.Speed);
            Console.WriteLine("Вес = " + base.Weight);
            Console.WriteLine();
        }
    }
}
