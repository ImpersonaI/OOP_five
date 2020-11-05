using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_four
{
    class TruckWithEquipment : Truck
    {
        public double AmountOfEquipment { get; set; }

        public TruckWithEquipment(double AmountOfEquipment, string Name, double Power, double Speed, double Weight, int TypeOfWheels)
        {
            this.AmountOfEquipment = AmountOfEquipment;
            base.Name = Name;
            base.Power = Power;
            base.Speed = Speed;
            base.TypeOfWheels = TypeOfWheels;
            base.Weight = Weight;
            
        }
    }
}
