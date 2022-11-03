using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool IsAManual { get; set; }
        public bool HasBlueTooth { get; set; }
        public bool HasFourWheels { get ; set ; }
        public bool HasWindows { get ; set ; }
        public bool HasSteeringWheel { get ; set ; }
        public bool HasAirBags { get ; set ; }
        public string Name { get ; set ; }
        public string Logo { get ; set ; }
        public void CarStats()
        {
            Console.WriteLine($" This cars name is a {Name} and its logo is spelt like {Logo}");
            Console.WriteLine(" Its manual transmission, has bluetooth, 4 wheels, has windows," +
                              "a steering wheel, and airbags");
        }
    } 

}
