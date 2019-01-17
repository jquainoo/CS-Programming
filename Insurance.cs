namespace Exercises.Class
{
    public class Insurance
    {
        //Instance variables
        private int age;
        private string consumerName;
        private int creditHistory;
        private string[] documents;
        private string insuranceId;

        //static variables
        private static int counter;

        static Insurance()
        {
            counter = 1000;
        }

        public Insurance()
        {
            age = 18;
            creditHistory = 45000;
        }

        public Insurance(string consumerName)
            :this()
        {
            this.consumerName = consumerName;   
        }

        public Insurance(string consumerName, string[] documents)
            : this()
        {
            this.consumerName = consumerName;
            this.documents = documents;
        }

        public Insurance(string consumerName, int creditHistory, int age, string[] documents)
            :this()
        {
            this.age = age;
            this.consumerName = consumerName;
            this.creditHistory = creditHistory;
            this.documents = documents;
        }

        public bool CheckEligibility()
        {
            if (age < 18)
                return false;
            else if ((age > 18 && age <= 30) && creditHistory <= 60000)
                return true;
            else if (age > 30 && creditHistory <= 45000)
                return true;
            else
                return false;
        }


        public bool CheckDocuments(string[] acceptabledocuments)
        {
            if (CheckEligibility() == true)
            {
                for(int i = 0; i < documents.Length; i++)
                {
                    for(int j = 0; j < acceptabledocuments.Length; j++)
                    {
                        if(documents[i].ToLower().Equals(acceptabledocuments[j].ToLower()))
                        {
                            insuranceId = "I" + counter++;
                            return true;
                        }
                    }
                }
                return false;
            }
            return false;
        }


    }
}
