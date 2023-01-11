using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int StorageSpace { get; set; }
        public int EngineSize { get; set; }
        public int NumberOfWheels { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public int SeatCount { get ; set ; }
        public string Logo { get ; set ; }
        public int MarketValue { get ; set ; }
    }
}
