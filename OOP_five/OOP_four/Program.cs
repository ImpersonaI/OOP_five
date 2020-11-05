using System;

namespace OOP_four
{
    class Program
    {
        static void Main(string[] args)
        {
            // Machine machine = new Machine("Vasya", 455, 455);
            Machine machine = new Machine();
            Aviation aviation = new Aviation();
            Truck truck = new Truck();
            Motorcycle motorcycle = new Motorcycle();

            TruckWithFood truckWithFood = new TruckWithFood(445.2, "Food", 888, 90, 1.2, 2);
            TruckWithEquipment truckWithEquipment = new TruckWithEquipment(4.5, "Equipment", 670, 100, 1.7, 1);
            TruckWithForce truckWithForce = new TruckWithForce(15.7, "Force", 670, 100, 1.7, 1);
            AviaDestroyer aviaDestroyer = new AviaDestroyer(2, 3, 4, "aviaDestroyer", 1200, 2);
            AviaHelicopter aviaHelicopter = new AviaHelicopter(2, 3, 2, "aviaHelicopter", 1600, 3);
            MotoPassengerSpy motoPassengerSpy = new MotoPassengerSpy(4, 2, "MotoPassengerSpy", 190, 450);
            MotoPassengerScout motoPassengerScout = new MotoPassengerScout(4, 3, "MotoPassengerScout", 299, 320);
            MotoPassengerMinigun motoPassengerMinigun = new MotoPassengerMinigun(4, 3, "MotoPassengerMinigun", 300, 500);
            MotoPassengerHealer motoPassengerHealer = new MotoPassengerHealer(34, 4, "MotoPassengerHealer", 350, 600);


            Console.ReadKey();
        }
    }
}
