using System;

namespace Assignments.DayFour
{
    //Assignment 14
    public abstract class InsurancePolicy
    {
        //Properties
        public double PolicyCover { get; set; }
        public int PolicyTerm { get; set; } //In months
        public double Premium { get; set; }
        public double Risk { get; set; }


        public InsurancePolicy()
        {

        }

        public InsurancePolicy(int policyTerm)
            :this()
        {
            PolicyTerm = policyTerm;
        }

        public abstract double CalculatePolicyCover();

        public abstract double CalculateRisk();

        public double CalculatePremium()
        {
            return (CalculateRisk() * CalculatePolicyCover()) / PolicyTerm;
        }

    }

    public class VehicleInsurancePolicy : InsurancePolicy
    {
        public string VehicleCondition { get; set; }
        public double VehiclePrice { get; set; }
        public string VehicleType { get; set; }
       


        public VehicleInsurancePolicy()
        {

        }

        public VehicleInsurancePolicy(string vehicleType, double vehiclePrice, string vehicleCondition, int policyTerm)
            : base(policyTerm)
        {
            VehicleType = vehicleType;
            VehiclePrice = vehiclePrice;
            VehicleCondition = vehicleCondition;
        }

        public override double CalculateRisk()
        {
            if (VehicleType.ToLower().Equals("sports"))
                return .35;
            else if (VehicleType.ToLower().Equals("logistics"))
                return .4;
            else if (VehicleType.ToLower().Equals("sedan"))
                return .2;
            else
                return 0.15;

        }


        public override double CalculatePolicyCover()
        {
            if(VehicleCondition.ToLower().Equals("new"))
                return PolicyCover = .90 * VehiclePrice;
            else if(VehicleType.ToLower().Equals("good"))
                return PolicyCover = .75 * VehiclePrice;
            else if(VehicleType.ToLower().Equals("old"))
                return PolicyCover = .50 * VehiclePrice;
            else
                return PolicyCover = 0.0 * VehiclePrice;
        }
    }



    public class LifeInsurancePolicy : InsurancePolicy
    {
        public int Age { get; set; }
        public string MedicalHistory { get; set; }

        public LifeInsurancePolicy()
        {

        }

        public LifeInsurancePolicy(int age, string medicalHistory, double policyCover, int policyTerm)
            : base(policyTerm)
        {
            Age = age;
            MedicalHistory = medicalHistory;
            PolicyCover = policyCover;
        }

        public override double CalculatePolicyCover()
        {
            return PolicyCover;
        }

        public override double CalculateRisk()
        {
            if (Age <= 25 && MedicalHistory.ToLower().Equals("clear"))
                return .05;
            else if (Age <= 40 && MedicalHistory.ToLower().Equals("minor"))
                return .4;
            else if (Age <= 55 && MedicalHistory.ToLower().Equals("moderate"))
                return .2;
            else
                return 0.2;
        }
    }
}
