using System;
using System.Collections.Generic;
using System.ComponentModel;

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
            //Creatively display and organize their values

            #region car1

            var car1 = new Car();

            car1.TrunkSize = 9;
            car1.DoorCount = 4;

            car1.WheelCount = 4;
            car1.FuelType = "Gasoline";
            car1.Color = "Blue";
            car1.HasAC = true;
            car1.Make = "Nissan";
            car1.Model = "Versa";
            car1.Year = 2018;

            car1.CoName = "Nissin Ramen";
            car1.EmpSize = 60000;
            car1.YearEst = 1958;

            
            #endregion

            #region car2

            var car2 = new Car();
            
            car2.TrunkSize = 12;
            car2.DoorCount = 4;

            car2.WheelCount = 4;
            car2.FuelType = "Gasoline";
            car2.Color = "Silver";
            car2.HasAC = true;
            car2.Make = "Chevrolet";
            car2.Model = "Malibu";
            car2.Year = 2019;

            car2.CoName = "Napa Auto Parts";
            car2.EmpSize = 45000;
            car2.YearEst = 1925;

            #endregion

            #region car3
            var car3 = new Car();
            
            car3.TrunkSize = 6;
            car3.DoorCount = 2;

            car3.WheelCount = 4;
            car3.FuelType = "Elecrtic";
            car3.Color = "Red";
            car3.HasAC = true;
            car3.Make = "Tesla";
            car3.Model = "S";
            car3.Year = 2023;

            car3.CoName = "Space X";
            car3.EmpSize = 12000;
            car3.YearEst = 2002;

            #endregion

            #region truck1

            var truck1 = new Truck();

            truck1.BedSize = 28;
            truck1.ExtCab = true;

            truck1.WheelCount = 6;
            truck1.FuelType = "Diesel";
            truck1.Color = "Black";
            truck1.HasAC = true;
            truck1.Make = "Dodge";
            truck1.Model = "RAM";
            truck1.Year = 2022;

            truck1.CoName = "Longhorn Steakhouse";
            truck1.EmpSize = 150000;
            truck1.YearEst = 1981;

            #endregion

            #region truck2

            var truck2 = new Truck();

            truck1.BedSize = 20;
            truck1.ExtCab = false;

            truck2.WheelCount = 4;
            truck2.FuelType = "Gasoline";
            truck2.Color = "Red";
            truck2.HasAC = true;
            truck2.Make = "Chevrolet";
            truck2.Model = "Silverado";
            truck2.Year = 2017;

            truck2.CoName = "Campbell's Soup";
            truck2.EmpSize = 19000;
            truck2.YearEst = 1869;

            #endregion

            #region truck3

            var truck3 = new Truck();

            truck1.BedSize = 18;
            truck1.ExtCab = true;

            truck3.WheelCount = 4;
            truck3.FuelType = "Hybrid";
            truck3.Color = "Green";
            truck3.HasAC = true;
            truck3.Make = "Honda";
            truck3.Model = "Ridgeline";
            truck3.Year = 2020;

            truck3.CoName = "WD-40";
            truck3.EmpSize = 583;
            truck3.YearEst = 1953;

            #endregion

            #region suv1

            var suv1 = new SUV();

            suv1.HatchSize = 22;
            suv1.LayFlatSeats = true;

            suv1.WheelCount = 4;
            suv1.FuelType = "Gasoline";
            suv1.Color = "Blue";
            suv1.HasAC = true;
            suv1.Make = "Mitsubishi";
            suv1.Model = "Outlander";
            suv1.Year = 2023;

            suv1.CoName = "JackLinks";
            suv1.EmpSize = 3000;
            suv1.YearEst = 1985;

            #endregion

            #region suv2

            var suv2 = new SUV();

            suv2.HatchSize = 24;
            suv2.LayFlatSeats = false;

            suv2.WheelCount = 4;
            suv2.FuelType = "Electric";
            suv2.Color = "Black";
            suv2.HasAC = true;
            suv2.Make = "Tesla";
            suv2.Model = "X";
            suv2.Year = 2019;

            suv2.CoName = "The Boring Company";
            suv2.EmpSize = 200;
            suv2.YearEst = 2016;


            #endregion

            #region suv3

            var suv3 = new SUV();

            suv3.HatchSize = 18;
            suv3.LayFlatSeats = true;

            suv3.WheelCount = 4;
            suv3.FuelType = "Gasoline";
            suv3.Color = "Green";
            suv3.HasAC = true;
            suv3.Make = "Jeep";
            suv3.Model = "Renegade";
            suv3.Year = 2023;

            suv3.CoName = "Clif Bar";
            suv3.EmpSize = 300;
            suv3.YearEst = 1992;

            #endregion


            #region Lists

            var inventoryCars = new List<Car>()
            { 
                car1,
                car2, 
                car3,
            };

            var inventoryTrucks = new List<Truck>() 
            {
                truck1,
                truck2,
                truck3,
            };

            var inventorySUV = new List<SUV>() 
            {
                suv1,
                suv2,
                suv3,
            };

            #endregion

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("We have the following cars to choose from:");


            foreach(var car in inventoryCars)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Year:  {car.Year}");
                Console.WriteLine($"Make:  {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("This car hase the following features:");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"{car.DoorCount} doors - {car.TrunkSize} cu.ft. of trunkspace");
                Console.WriteLine($"color {car.Color} - comes with A/C :{car.HasAC}");
                Console.WriteLine($"{car.FuelType} engine - {car.WheelCount} brand new tires.");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("This car is sponsored by:");    
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine($"{car.CoName} established in {car.YearEst} " +
                    $"and currently employs {car.EmpSize} people.");

            }

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine("We have the following trucks to choose from:");
            
            Console.ForegroundColor = ConsoleColor.Cyan;

            foreach (var truck in inventoryTrucks)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Year:  {truck.Year}");
                Console.WriteLine($"Make:  {truck.Make}");
                Console.WriteLine($"Model: {truck.Model}");
                Console.WriteLine();

                Console.ForegroundColor= ConsoleColor.DarkYellow;
                
                Console.WriteLine("This car hase the following features:");
                Console.WriteLine();
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Extanded Cab Option: {truck.ExtCab} - {truck.BedSize} cu.ft. of truck bed space");
                Console.WriteLine($"color {truck.Color} - comes with A/C :{truck.HasAC}");
                Console.WriteLine($"{truck.FuelType} engine - {truck.WheelCount} brand new tires.");
                Console.WriteLine();
                
                Console.ForegroundColor = ConsoleColor.Green;
                
                Console.WriteLine("This truck is sponsored by:");
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                
                Console.WriteLine();    
                Console.WriteLine($"{truck.CoName} established in {truck.YearEst} " +
                    $"and currently employs {truck.EmpSize} people.");

            }

            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine("We have the following Sport Utility Models to choose from:");
            


            foreach (var suv in inventorySUV)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Year: {suv.Year}");
                Console.WriteLine($"Make: {suv.Make}");
                Console.WriteLine($"Model: {suv.Model}");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("This car hase the following features:");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"Lay Flat Seats Installed: {suv.LayFlatSeats} - {suv.HatchSize} cu.ft. of trunkspace");
                Console.WriteLine($"color {suv.Color} - comes with A/C :{suv.HasAC}");
                Console.WriteLine($"{suv.FuelType} engine - {suv.WheelCount} brand new tires.");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("This SUV is sponsored by:");    
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine($"{suv.CoName} established in {suv.YearEst}" +
                    $"and currently employs {suv.EmpSize} people.");


            }

           
            
            
            
                
        }
    }
}
