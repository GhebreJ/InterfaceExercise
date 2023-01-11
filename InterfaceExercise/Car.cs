using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int TrunkSize { get; set; }

        public int ChargerCount { get; set; }


        public int SeatCount { get; set; } = 4;
        public int NumberOfWheels { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public string Logo { get ; set ; }
        public int MarketValue { get ; set ; }
    }
}
