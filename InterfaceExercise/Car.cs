using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public bool HasTrunk { get; set; } = true;
        public bool LowerGasMileage { get; set; } = true;
        public string Logo { get; set; } = "Toyota logo";
        public int DateEstablished { get; set; } = 1937;
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool HasFourWheels { get; set; } = true;

        public void Drive()
        {
            Console.WriteLine("This car is for sale.");
        }


    }


}
