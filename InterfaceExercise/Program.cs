using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            var truk = new Truck()
            {
                NumberOfWheels = 4,
                Logo = "BULL",
                MarketValue = 100000,
                Make = "Toyota",
                Model = "Tundra",
                SeatCount = 5,
                TrailerBedCapacity = 52,
                TrailerHitchCapacity = 100
            };

            var car = new Car()
            {
                NumberOfWheels = 4,
                Logo = "Spider",
                MarketValue = 2032500,
                Make = "Ford",
                Model = "Focus",
                SeatCount = 4,
                ChargerCount= 5,
                TrunkSize= 10
            };

            var suv = new SUV()
            {
                NumberOfWheels = 4,
                Logo = "Tortoise",
                MarketValue = 804500,
                Make = "Mazda",
                Model = "M5",
                SeatCount = 8,
                EngineSize= 90,
                StorageSpace= 100
            };

            var vehicles = new List<IVehicle> { car, truk, suv};

           

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"This is a {vehicle.Make} {vehicle.Model} which has a {vehicle.SeatCount} seat count and {vehicle.NumberOfWheels} wheels");
            }

            //Creatively display and organize their values
        }
    }
}
