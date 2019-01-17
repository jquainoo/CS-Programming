namespace Assignments.DayFour
{
    //Assignement 12
    public class Vehicle
    {
        private int distance;
        private double farePerKM;
        private string vehicleId;

        

        public Vehicle()
        {

        }

        public Vehicle(double farePerKM, int distance)
        {
            this.farePerKM = farePerKM;
            this.distance = distance;

        }

        public int Distance
        {
            get
            {
                return distance;
            }

            set
            {
                distance = value;
            }
        }

        public double FarePerKM
        {
            get
            {
                return farePerKM;
            }

            set
            {
                farePerKM = value;
            }
        }

        protected string VehicleId
        {
            get
            {
                return vehicleId;
            }

            set
            {
                vehicleId = value;
            }
        }

        public virtual double CalculateTotalFare()
        {
            return this.farePerKM * this.distance;
        }
    }
}
