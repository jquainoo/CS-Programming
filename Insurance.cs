using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayTwo_Sub
{
    public class Insurance
    {
        public Insurance(string insuranceId, string insuranceName, int insuranceTerm, double amount, double premium)
        {
            InsuranceId = insuranceId;
            InsuranceName = insuranceName;
            InsuranceTerm = insuranceTerm;
            Amount = amount;
            Premium = premium;

        }

        public Insurance()
        {

        }

        public double Amount { get; set; }
        public string InsuranceName { get; set; }
        public int InsuranceTerm { get;  set; }
        public double Premium { get; set; }
        public string InsuranceId { get; set; }
    }
}
