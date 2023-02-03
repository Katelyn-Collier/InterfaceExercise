using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region InterfaceRegion
            Car car = new Car() { Year = 2021, Make = "Toyota", Model = "Corolla", HasTrunk = true, LowerGasMileage = true };
            SUV suv = new SUV() { Year = 2019, Make= "Ford", Model = "Flex", HasCargoHoldSize = true, GreatForFamilies = true };
            Truck truck = new Truck() { Year = 1998, Make = "Chevrolet", Model = "S-10", HasTwoDoors = true, HasBed = true };


            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(car);
            vehicles.Add(suv);
            vehicles.Add(truck);

            foreach(IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year}, {vehicle.Make}, {vehicle.Model}");
                vehicle.Drive();
                vehicle.DriveDefault();
                Console.WriteLine();
            }

            Console.ReadLine();
            #endregion









            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE Create 2 Interfaces called IVehicle & ICompany

            //DONE Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /* DONE Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            // In each of your car, truck, and suv classes

            /* DONE Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
