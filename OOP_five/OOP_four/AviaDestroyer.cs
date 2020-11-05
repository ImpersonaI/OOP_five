using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace OOP_four
{
    class AviaDestroyer : Aviation
    {
        public int NumberOfPilots { get; set; }
        
        public AviaDestroyer( int NumberOfPilots, int ClassofAviation, int Typeofweapon, string Name, double Speed, double Weight)
        {
            this.NumberOfPilots = NumberOfPilots;
            base.ClassofAviation = ClassofAviation;
            base.Typeofweapon = Typeofweapon;
            base.Name = Name;
            base.Speed = Speed;
            base.Weight = Weight;

            Console.WriteLine("Число пилотов = " + this.NumberOfPilots);
            Console.WriteLine("Класс авиации = " + base.ClassofAviation);
            Console.WriteLine("Тип вооружения = " + base.Typeofweapon);
            Console.WriteLine("Название = " + base.Name);
            Console.WriteLine("Скорость =" + base.Speed);
            Console.WriteLine("Вес = " + base.Weight);
            Console.WriteLine();
        }
    }
}
