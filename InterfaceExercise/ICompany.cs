using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
     public interface ICompany
    {
        string Logo { get; set; }
        int DateEstablished { get; set; }

        public void Drive()
        {
            Console.WriteLine("Logo and Date Established:");
        }
    }
}
