
namespace Exercises.Class
{
    public class Trainee
    {
        private string[] focusArea;
        private float[] marks;

        public Trainee(string[] focusArea, float[] marks)
        {
            this.focusArea = focusArea;
            this.marks = marks;
        }

        public Trainee()
        {

        }


        public float CalculateScore(out float percentage, out char grade, out string message, bool isRetest = false)
        {
            float totalScore = 0, penalty = 10 / 100, maxScore = marks[0];
            totalScore += marks[0];
            int maxIndex = 0;
            for(int i = 1; i < marks.Length; i++){
                if(maxScore > marks[i])
                {
                    maxScore = marks[i];
                    maxIndex++;
                }
                totalScore += marks[i];
            }

            float maxDifference = marks[maxIndex];
            marks[maxIndex] = 100;

            totalScore = totalScore + (marks[maxIndex] - maxDifference);

            if (isRetest == true)
            {
                totalScore = totalScore - (penalty * totalScore);
            }

            percentage = ((totalScore / marks.Length * 100)) * 100;
            if (percentage >= 85 && percentage <= 100)
            {
                percentage = 85;
                percentage = 100;
                grade = 'A';
            }
            else if (percentage >= 75 && percentage <= 84)
                grade = 'B';
            else if (percentage >= 0 && percentage <= 74)
                grade = 'C';
            else
                grade = 'N';


            if (percentage >= 50 && percentage <= 100)
                message = "Qualified";
            else
                message = "Not Qualified";

            return totalScore;
        }
    }
}
