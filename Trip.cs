using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayTwo
{
    public class Trip
    {

        public Trip(string source, string destination, int[] availability, string[] travelclass)
        {
            Source = source;
            Destination = destination;
            Availability = availability;
            TravelClass = travelclass;
        }

        
        public int[] Availability { get; set; }
        public string Destination { get; set; }
        public double Fare { get; set; }
        public string Source { get; set; }
        public string[] TravelClass { get; set; }



    }
}
