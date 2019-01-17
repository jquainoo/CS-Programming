namespace Exercises.Class
{
    public class Department
    {
        private int deptNumber;
        private bool isProducing;
        private float produce;

        static Department()
        {

        }

        public Department()
        {

        }

        public Department(int deptNumber, bool isProducing, float produce)
        {
            this.deptNumber = deptNumber;
            this.isProducing = isProducing;
            this.produce = produce;
        }

        public float GetIncentive(float multiplyFactor)
        {
            float incentive = 0;
            if (isProducing == true)
                incentive = produce * multiplyFactor;
            else
                incentive = 0;
            return incentive;
        }
    }
}
