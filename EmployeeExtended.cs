using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Class
{
    //Exercise 26
    public class EmployeeExtended : Department
    {
        private int fixedSalary;
        private DateTime workingTime;
        private double basicSalary;
        private double bonus;
        private int employeeId;
        
        static EmployeeExtended()
        {
        }

        public EmployeeExtended()
        {
            BasicSalary = 10000;
        }

        public EmployeeExtended(int fixedSalary, DateTime workingTime)
            : this()
        {
            this.fixedSalary = fixedSalary;
            this.workingTime = workingTime;
        }

        public double BasicSalary
        {
            get
            {
                return basicSalary;
            }

            set
            {
                basicSalary = value;
            }
        }

        public double Bonus
        {
            get
            {
                return bonus;
            }

            set
            {
                bonus = value;
            }
        }

        public int EmployeeId
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
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


        public virtual double CalculateSalary()
        {
            return BasicSalary;
        }
    }


    public class SystemsEngineer : EmployeeExtended
    {
        public double SpecialistAllowance { get; set; }
        public string Specialization { get; set; }

        public SystemsEngineer(string specialization)
            : base()
        {
            Specialization = specialization;
        }

        public override double CalculateSalary()
        {
            if (Specialization.ToLower().Equals("java") || Specialization.ToLower().Equals("c#") || Specialization.ToLower().Equals("sql"))
                SpecialistAllowance = 3000;
            else
                SpecialistAllowance = 0.0;

            return base.CalculateSalary() + SpecialistAllowance;
        }
    }


    public class Manager : EmployeeExtended
    {
        public double PhoneAllowance { get; set; }

        public Manager()
        {
            PhoneAllowance = 4000;
        }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() + PhoneAllowance;
        }
    }


    public class SeniorProjectManager : EmployeeExtended
    {
        public double CarAllowance { get; set; }

        public SeniorProjectManager()
        {
            CarAllowance = 6000;
        }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() + CarAllowance;
        }
    }

    public class Finance
    {
       public double GetCalculatedSalary(EmployeeExtended obj)
        {
            if(obj is SystemsEngineer)
            {
                return (obj.Bonus = 5000) + ((SystemsEngineer)obj).CalculateSalary();
            }

            else if (obj is Manager)
            {
                return (obj.Bonus = 9000) + ((Manager)obj).CalculateSalary();

            }
            else if (obj is SeniorProjectManager)
            {
                return (obj.Bonus = 9000) + ((SeniorProjectManager)obj).CalculateSalary();
            }
            else
                return (obj.Bonus = 0.0) + (obj).CalculateSalary();
        }
    }
}
