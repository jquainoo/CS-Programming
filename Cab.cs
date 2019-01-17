namespace Assignments.DayFour
{
    //Assignment 12
    public class Cab : Vehicle
    {
        private string voucher;

        public Cab() : base()
        {

        }

        public Cab(double farePerKM, int distance, string voucher, int vehicleNumber) : base(farePerKM, distance)
        {
            this.voucher = voucher;
            VehicleId = "C" + vehicleNumber;
        }

        public override double CalculateTotalFare()
        {
            double totalFare = base.CalculateTotalFare();
            if (voucher != null)
                totalFare -= 100;

            double tax = ((5 / 100) * totalFare);
            return (totalFare + tax);
        }
    }
}
