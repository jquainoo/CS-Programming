namespace Exercises.Class
{
    public class Patient
    {
        private string[] labTestId;
        private int patientId;
        private string patientName;
        LabTestRepository lab = new LabTestRepository();


        static Patient()
        {

        }

        public Patient()
        {

        }

        public Patient(int patientId, string patientName, string[] labTestId)
        {
            this.labTestId = labTestId;
            this.patientId = patientId;
            this.patientName = patientName;
        }

        public double CalculateCharge()
        {
            double totalCharge = 0;
            for(int i = 0; i < lab.LabTestId.Length; i++)
            {
                totalCharge += lab.GetCharge(lab.LabTestId[i]);
            }
            return totalCharge;
     
        }
    }
}
