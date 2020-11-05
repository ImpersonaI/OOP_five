using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_four
{
    class TruckWithForce : Truck
    {

        public double AmountOfForce { get; set; }

        public TruckWithForce(double AmountOfForce, string Name, double Power, double Speed, double Weight, int TypeOfWheels)
        {
            this.AmountOfForce = AmountOfForce;
            base.Name = Name;
            base.Power = Power;
            base.Speed = Speed;
            base.Weight = Weight;
            base.TypeOfWheels = TypeOfWheels;
        }
    }
}
