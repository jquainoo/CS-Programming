using System.Collections.Generic;
using System.Linq;

namespace AdvancedProgramming.DayTwo_Sub
{
    public class Agent
    {

        public Agent()
        {
            
        }

        public List<Insurance> InsuranceList { get; set; }

        public List<Insurance> AddPolicy(Insurance obj)
        {
            if(InsuranceList.Count() ==  0 || InsuranceList == null)
            {
                InsuranceList = new List<Insurance>();
                InsuranceList.Add(obj);
            }
            else
            {
                foreach(Insurance insurance in InsuranceList)
                {
                    if(!(insurance.InsuranceId.ToLower().Equals(obj.InsuranceId.ToLower())))
                        InsuranceList.Add(obj);
                }
            }
            return InsuranceList;
        }

        public List<Insurance> DeletePolicy(string insuranceId)
        {
            foreach (Insurance insurance in InsuranceList)
            {
                if (insurance.InsuranceId.ToLower().Equals(insuranceId.ToLower()))
                {
                    InsuranceList.Remove(insurance);
                }
            }
            return InsuranceList;

        }

        public Insurance SearchPolicy(string insuranceId)
        {
            foreach (Insurance insurance in InsuranceList)
            {
                if(insurance.InsuranceId.ToLower().Equals(insuranceId.ToLower()))
                    return insurance;
            }
            return null;
        }
    }
}
