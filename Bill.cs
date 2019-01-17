using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.DayFour
{
    public class Bill
    {

        public Bill()
        {

        }

        public double GenerateBill(Patient obj)
        {
            double totalBillAmount = 0;
            if(obj is Outpatient)
            {
                totalBillAmount = ((Outpatient)obj).CalculateConsultationFee();
            }
            else if(obj is Inpatient)
            {
                totalBillAmount = ((Inpatient)obj).CalculateConsultationFee() + ((Inpatient)obj).RoomCharge();
            }
            else
                totalBillAmount = 0;

            return totalBillAmount;
        }
    }
}
