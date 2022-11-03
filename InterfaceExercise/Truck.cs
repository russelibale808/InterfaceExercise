using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string TruckBed { get; set; }
        public string OutDoorTunk { get; set; }
        public bool HasFourWheels { get ; set ; }
        public bool HasWindows { get ; set ; }
        public bool HasSteeringWheel { get ; set ; }
        public bool HasAirBags { get ; set ; }
        public string Name { get ; set ; }
        public string Logo { get ; set ; }

        public void TruckStats()
        {
            Console.WriteLine($" Trucks name is {Name} and it's logo says {Logo}." +
                              $" It's truck bed is a {TruckBed} and has a {OutDoorTunk}");
            Console.WriteLine(" Has four wheels, windows, steering wheel, and air bags");
        }
    }
}
