using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public bool HasCargoHoldSize { get; set; }
        public bool GreatForFamilies { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool HasFourWheels { get; set; } = true;
        public string Logo { get; set; } = "Ford logo";
        public int DateEstablished { get; set; } = 1903; 

        public void Drive()
        {
            Console.WriteLine("This SUV is for sale.");
        }

    }
}
