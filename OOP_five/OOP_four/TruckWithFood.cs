using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_four
{
    class TruckWithFood : Truck
    {
        public double AmountOfFood { get; set; }

        public TruckWithFood(double AmountOfFood, string Name, double Power, double Speed, double Weight, int TypeOfWheels)
        {
            this.AmountOfFood = AmountOfFood;
            base.Name = Name;
            base.Power = Power;
            base.Speed = Speed;
            base.Weight = Weight;
            base.TypeOfWheels = TypeOfWheels;
        }
    }
}
