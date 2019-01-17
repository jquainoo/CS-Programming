using System;

namespace Assignments.DayOne
{
    //Assignment 2
    public class Instructor
    {
        private string instructorName;
        private float avgFeedback;
        private int experience;
        private string[] instructorSkill;

        public Instructor(string instructorName, float avgFeedback, int experience, string[] instructorSkill)
        {
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorSkill = instructorSkill;
        }

        public Instructor()
        {
            this.instructorName = null;
            this.avgFeedback = -1.0f;
            this.experience = -1;
            this.instructorSkill = null;
        }

        public bool CheckSkill(string technology)    
        {
            foreach (string techskill in instructorSkill){
                if(string.Equals(techskill, technology, StringComparison.OrdinalIgnoreCase))
                {
                   return ValidateEligibility();
                }
            }
            return false;
        }

        public bool ValidateEligibility()
        {
            return ((experience > 3 && avgFeedback >= 4.5) || (experience <= 3 && avgFeedback >= 4.0));
        }
    }
}
