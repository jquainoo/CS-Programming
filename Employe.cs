using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.DayThree
{ 
    //Assignment 11
    public class Employe : Department
    {
        private int fixedSalary;
        private DateTime workingFrom;

        //static contructor
        static Employe()
        {

        }

        public Employe()
        {
         
        }

        public Employe(int fixedSalary, DateTime workingFrom)
            : this()
        {
            this.fixedSalary = fixedSalary;
            this.workingFrom = workingFrom;
        }

        public double GetAllowance(DateTime cutOffDate)
        {
            int numberOfYearsWorked = 0; double allowance = 0;
            numberOfYearsWorked = (int.Parse(DateTime.Now.ToString("yyyyMMdd")) -
                int.Parse(cutOffDate.ToString("yyyyMMdd"))) / 10000;

            if (numberOfYearsWorked < 5)
                allowance = (5 / 100) * fixedSalary;

            else if (numberOfYearsWorked < 10 && numberOfYearsWorked >= 5)
                allowance = (10 / 100) * fixedSalary;

            else if (numberOfYearsWorked < 15 && numberOfYearsWorked >= 10)
                allowance = (15 / 100) * fixedSalary;

            else
                allowance = (20 / 100) * fixedSalary;

            return allowance;

        }

        public double GetAllowance()
        {
            DateTime cutOffDate = new DateTime(2014 / 03 / 31);
            int numberOfYearsWorked = 0; double allowance = 0;

            numberOfYearsWorked = (int.Parse(DateTime.Now.ToString("yyyyMMdd")) -
                int.Parse(cutOffDate.ToString("yyyyMMdd"))) / 10000;

            if (numberOfYearsWorked < 5)
                allowance = (5 / 100) * fixedSalary;

            else if (numberOfYearsWorked < 10 && numberOfYearsWorked >= 5)
                allowance = (10 / 100) * fixedSalary;

            else if (numberOfYearsWorked < 15 && numberOfYearsWorked >= 10)
                allowance = (15 / 100) * fixedSalary;

            else
                allowance = (20 / 100) * fixedSalary;

            return allowance;

        }


        public double GetTotalSalary(DateTime cutOffDate, float multiplyFactor)
        {
            double TotalSalary = 0;
            TotalSalary = fixedSalary + GetAllowance(cutOffDate) + GetIncentive(multiplyFactor);
            return TotalSalary;
        }

        public double GetTotalSalary(float multiplyFactor)
        {
            double TotalSalary = 0;
            TotalSalary = fixedSalary + GetAllowance() + GetIncentive(multiplyFactor);
            return TotalSalary;
        }
    }
}
