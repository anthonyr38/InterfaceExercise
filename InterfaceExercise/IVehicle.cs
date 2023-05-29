using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int WheelCount { get; set; }
        public string FuelType { get; set; }
        public string Color { get; set; }   
        public bool HasAC { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

    }
}
