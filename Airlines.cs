using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayTwo_Sub
{
    public class Airlines
    {
        

        public Airlines()
        {

        }
        public double AirlineId { get; set; }
        public double AirlineName { get; set; }
        public double BaseFare { get; set; }

        public double CalculateServiceCharges(double baseFare)
        {
            return (baseFare * (5 / 100));
        }

        public double CalculateTax(double baseFare)
        {
            return (baseFare * (15 / 100));
        }

        public double CalculateFare(Customer obj)
        {
            double totalAmount = 0;

            try
            {
                int age = obj.CalculateAge();

                try
                {
                    if (age > 0 && age < 100)
                    {
                        if (obj.ClassOfTravel.ToLower().Equals("business"))
                        {
                            BaseFare = 10000;
                        }
                        else if (obj.ClassOfTravel.ToLower().Equals("premium"))
                            BaseFare = 5000;
                        else if (obj.ClassOfTravel.ToLower().Equals("economy"))
                            BaseFare = 1200;
                    }

                }
                catch (InvalidTravelClassException ex)
                {
                    Console.WriteLine("Invalid Travel Class");
                    BaseFare = 0;
                    Console.WriteLine(ex.Message);
                }

            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Invalid Age");
                BaseFare = 0;
                Console.WriteLine(ex.Message);

            }
            finally
            {
                totalAmount = BaseFare + CalculateServiceCharges(BaseFare) + CalculateTax(BaseFare);
            }

            return totalAmount;
        }
    }
}
