namespace AdvancedProgramming.DayTwo
{
    //Exercise 11
    public class Employee
    {
        private int employeeId;
        private string name;

        public Employee()
        {

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
