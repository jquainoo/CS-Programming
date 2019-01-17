using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayTwo
{
    public class User
    {
        private int nextUserId;
        private static int counter;


        static User()
        {
            counter = 1000;
        }

        public User()
        {
            UserId = counter++;

        }

        public SortedList<DateTime, int> CouponList { get; set; }
        public List<Ticket> TicketHistory { get; set; }
        public int UserId { get; set; }


        public Ticket BookTicket(Trip trip, int noOfPassengers, string travelClass, out bool couponStatus)
        {
            if(trip != null)
            {
                Ticket ticket;
                if (trip.TravelClass.Contains(travelClass) && trip.Availability.Length > noOfPassengers)
                {
                    ticket = new Ticket(trip, noOfPassengers, travelClass);
                    TicketHistory.Add(ticket);
                    couponStatus = CheckForCoupon(ticket);
                    return ticket;
                }
                
            }
            couponStatus = false;
            return null;
          
        }

        public bool CheckForCoupon(Ticket ticket)
        {
            Coupon coupon = new Coupon();
           if(ticket.TotalFare >= 4000)
            {
                coupon.IssueCoupon(ticket.TravelClass);

            }
            return false;
        }

        public bool AvailCoupon(Ticket ticket)
        {
            return true;
        }

    }
}
