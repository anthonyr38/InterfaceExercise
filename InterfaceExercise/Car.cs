﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        
            public int TrunkSize { get; set; }
            public int DoorCount { get; set; }
        
            public int WheelCount { get; set; }
            public string FuelType { get; set; }
            public string Color { get; set; }
            public bool HasAC { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public string CoName { get; set; }
            public int EmpSize { get; set; }
            public int YearEst { get; set; }
    }
}