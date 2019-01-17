using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayTwo
{
    public class Discount
    {
        public Discount(int noOfCoupons, DateTime expiryDate)
        {
            NoOfCoupons = noOfCoupons;
            ExpiryDate = expiryDate;

        }

        public int NoOfCoupons { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
