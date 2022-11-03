using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool HasFourWheels { get; set; }
        public bool HasWindows { get; set; }
        public bool HasSteeringWheel { get; set; }
        public bool HasAirBags { get; set; }
    }
}
