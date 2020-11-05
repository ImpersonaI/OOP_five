using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_four
{
    class AviaHelicopter : Aviation
    {
        public int TypeOfHelicopter { get; set; }

        public AviaHelicopter(int TypeOfHelicopter, int ClassofAviation, int Typeofweapon, string Name, double Speed, double Weight)
        {

            this.TypeOfHelicopter = TypeOfHelicopter;
            base.ClassofAviation = ClassofAviation;
            base.Typeofweapon = Typeofweapon;
            base.Name = Name;
            base.Speed = Speed;
            base.Weight = Weight;

            Console.WriteLine("Число пилотов = " + this.TypeOfHelicopter);
            Console.WriteLine("Класс авиации = " + base.ClassofAviation);
            Console.WriteLine("Тип вооружения = " + base.Typeofweapon);
            Console.WriteLine("Название = " + base.Name);
            Console.WriteLine("Скорость =" + base.Speed);
            Console.WriteLine("Вес = " + base.Weight);
            Console.WriteLine();
        }
    }
}
