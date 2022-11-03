﻿using System;
using System.Xml.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany DONE

            //Create 3 classes called Car , Truck , & SUV DONE

            //In your IVehicle DONE
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany DONE
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes DONE

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car = new Car();

            car.Name = "Toyota";
            car.Logo = "TOYOTA";
            car.IsAManual = true;
            car.HasBlueTooth = true;
            car.HasFourWheels = true;
            car.HasWindows = true;
            car.HasSteeringWheel = true;
            car.HasAirBags = true;

            car.CarStats();
            Console.WriteLine();

            var truck = new Truck();

            truck.Name = "Ford";
            truck.Logo = "BUILT TOUGH";
            truck.TruckBed = "8 by 4 truck bed size";
            truck.OutDoorTunk = "built in outdoor trunk";
            truck.HasFourWheels = true;
            truck.HasWindows = true;
            truck.HasSteeringWheel = true;
            truck.HasAirBags = true;

            truck.TruckStats();
            Console.WriteLine();

            var suv = new SUV();

            suv.Name = "Nissan";
            suv.Logo = "ROUGE";
            suv.FoldableSeats = " has foldable seats";
            suv.SeatWarmers = " has seat warmers";
            suv.HasFourWheels = true;
            suv.HasWindows = true;
            suv.HasSteeringWheel = true;
            suv.HasAirBags = true;

            suv.SuvStats();
            
            
        }
    }
}
