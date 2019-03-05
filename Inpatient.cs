using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.DayFour
{
    public class Inpatient :Patient
    {
        private int days;

        public Inpatient() : base()
        {
        }

        public Inpatient(string name, int age, char gender, string illness, int days) 
            : base(name, age, gender, illness)
        {
            this.days = days;
            PerDayService = 155.00;
            ExtraService = 100;
        }

        public int Days
        {
            get
            {
                return this.days;
            }

            set
            {
                if (value > 0)
                    this.days = value;
                else
                    this.days = 1;
            }
        }
        public double ExtraService { get; set; }
        public double PerDayService { get; set; }

        public override double CalculateConsultationFee()
        {
            double consultationFee = base.CalculateConsultationFee() + ExtraService;
            return consultationFee;
        }

        public double RoomCharge()
        {
            double roomCharges = 0;
            if (days <= 7)
                roomCharges = PerDayService * Days;
            else if(days > 7)
                roomCharges = (PerDayService * Days) + (ExtraService * Days);
            return roomCharges;
        }
    }
}
