using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public bool HasBed { get; set; } = true;
        public bool HasTwoDoors { get; set; } = true;
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool HasFourWheels { get; set; } = true;
        public string Logo { get; set; } = "Chevrolet logo";
        public int DateEstablished { get; set; } = 1911;

        public void Drive()
        {
            Console.WriteLine("This used truck is for sale.");
        }

    }
}
