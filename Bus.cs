using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.DayFour
{
    //Exercise 24
    //Assignment 12
    public class Bus : Vehicle
    {

        public Bus() : base()
        {

        }

        public Bus(double farePerKM, int distance, int vehicleNumber) :
            base(farePerKM, distance)
        {
            VehicleId = "B" + vehicleNumber;
        }

        public override double CalculateTotalFare()
        {
            double totalFare = base.CalculateTotalFare(), tax = 0;
            tax = (2 / 100) * totalFare;
            if (totalFare > 1000)
                totalFare = totalFare + tax;
            return totalFare;
        }
    }
}
