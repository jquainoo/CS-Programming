using System;
using System.Collections.Generic;

namespace AdvancedProgramming.DayTwo
{
    public class Coupon
    {
        public Dictionary<string, Discount> AvailableCoupons { get; set; }
        
        public Coupon()
        {
            AvailableCoupons = new Dictionary<string, Discount>();
        }

        public bool AddCoupons(string travelClass, Discount discount)
        {
            if (AvailableCoupons.ContainsKey(travelClass))
                return false;
            else
            {
                AvailableCoupons.Add(travelClass, discount);
                return true;
            }
        }

        public bool IncreaseNoOfCoupons(string travelClass, int noOfCoupons)
        {
            foreach (KeyValuePair<string, Discount> discount in AvailableCoupons)
            {
                if (discount.Key.ToLower().Equals(travelClass.ToLower()))
                {
                    discount.Value.NoOfCoupons = discount.Value.NoOfCoupons + noOfCoupons;
                    return true;
                }
            }
            return false;
        }

        public DateTime IssueCoupon(string travelClass)
        {
            foreach (KeyValuePair<string, Discount> discount in AvailableCoupons)
            {
                if (discount.Key.ToLower().Equals(travelClass.ToLower()))
                {
                    if (discount.Value.NoOfCoupons > 0)
                    {
                        while (discount.Value.NoOfCoupons != 0)
                        {
                            discount.Value.NoOfCoupons = discount.Value.NoOfCoupons - 1;
                        }
                        return discount.Value.ExpiryDate;
                    }
                    return DateTime.Now;
                    
                }
            }
            return DateTime.Now;
        }
    }
}
