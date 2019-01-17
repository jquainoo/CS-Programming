using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.DayFour
{
    public class Patient
    {
        public Patient()
        {

        }

        public Patient(string name, int age, char gender, string illness)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Illness = illness;

        }

        public int Age { get; set; }
        public double ConsultationFee { get; set; }
        public char Gender { get; set; }
        public string Illness { get; set; }
        public string Name { get; set; }


        public virtual double CalculateConsultationFee()
        {
            double consultationFee = 0;
            if (Age > 0 && Age <= 18)
                consultationFee = Age * 10;
            else if (Age > 18)
                ConsultationFee = Age * 15;
            return consultationFee;
        }
    }
}
