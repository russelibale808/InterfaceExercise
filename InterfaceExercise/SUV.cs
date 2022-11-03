using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public string FoldableSeats { get; set; }
        public string SeatWarmers { get; set; }
        public bool HasFourWheels { get ; set ; }
        public bool HasWindows { get ; set ; }
        public bool HasSteeringWheel { get ; set ; }
        public bool HasAirBags { get ; set ; }
        public string Name { get ; set ; }
        public string Logo { get ; set ; }

        public void SuvStats()
        {
            Console.WriteLine($" This SUV name is a {Name}, and not much of a logo more of a model, the {Logo}");
            Console.WriteLine($" It {FoldableSeats} and {SeatWarmers}. Has 4 wheels, windows, steering wheel," +
                $"and airbags. ");
        }
    }

}
