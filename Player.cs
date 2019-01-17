namespace Assignments.DayThree
{
    //Assignment 6
    public class Player
    {
        private int height;
        private string playerId;
        private string playerName;
        private  int score;
        private float weight;
        private string role;

        
        public Player()
        {
            role = "Defender";
        }

        public Player(string playerId, string playerName, int height, float weight, string role)
            :this()
        {
            this.height = height;
            this.playerId = playerId;
            this.playerName = playerName;
            this.weight = weight;
        }
        public void CalculateScore(out string reward, int noOfHits, int noOfMisses, int noOfRetries = 3, bool complete = true)
        {
            score = (noOfHits * 100) - (noOfMisses * 25) - (noOfRetries * 50);
            if (complete == true)
                reward = DetermineReward();
            else
                reward = "NA";
        }


        public string DetermineReward()
        {
            string reward = "";
            if (score >= 2500)
                reward += "Cash_Coupons";
            else if (score >= 1000 && score < 2500)
                reward += "Extra_Chance";
            else if (score >= 50 && score < 1000)
                reward += "Coupons";
            else
                reward += "No_Reward";

            return reward;
        }



    }
}
