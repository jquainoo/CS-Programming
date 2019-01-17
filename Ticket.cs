using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayTwo
{
    public class Ticket
    {
        /*
         * Initialize the members to appropriate values
         * Determine fare of the parameter trip for the travel class passed as parameter
         * If the travel class is invalid, then set TotalFare to -1
         * Else, calculate TotalFare taking noOfPassengers into consideration.
         * 
         */

        public Ticket(Trip trip, int noOfPassengers, string travelClass)
        {
            TripDetails = trip;
            NoOfPassengers = noOfPassengers;
            TravelClass = travelClass;
            TotalFare = travelClass * 

        }

        public int NoOfPassengers { get; set; }
        public double TotalFare { get; set; }
        public string TravelClass { get; set; }
        public Trip TripDetails { get; set; }
    }
}
