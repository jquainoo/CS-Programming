using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.DayFour
{
    public class Outpatient : Patient
    {

        public Outpatient()
            : base()
        {

        }

        public Outpatient(string name, int age, char gender, string illness) 
            : base(name, age, gender, illness)
        {

        }

        public override double CalculateConsultationFee()
        {
            double consultationFee = 0;
            if(Illness.ToLower().Equals("fever") || Illness.ToLower().Equals("cough"))
                consultationFee = base.CalculateConsultationFee() - 10;
            else
                consultationFee = base.CalculateConsultationFee() + 10;
            return consultationFee;

        }
    }
}
