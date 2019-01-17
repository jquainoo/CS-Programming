using System;

namespace Infosys.Exercises1Class
{
    public class Employee
    {
        private DateTime dateOfBirth;
        private string[] dependents;
        private string employeeName;
        private int employeeId;
        private bool gender;
        static int nextEmployeeNumber;
        private short numberOfDependents;



        static Employee()
        {
            NextEmployeeNumber = 1001;
        }

        public Employee()
        {
            EmployeeId = nextEmployeeNumber++;
            Dependents = new string[3];

        }

        public Employee(out int employeeId, string employeeName, DateTime dateOfBirth, bool gender)
            : this()
        {
            EmployeeName = employeeName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            employeeId = this.employeeId; //Changes Made

        }

        public Employee(out int employeeId, string employeeName, DateTime dateOfBirth, bool gender, ref short numberOfDependents, params string[] dependent)
            : this()
        {
            employeeId = this.employeeId;
            if (NumberOfDependents < 0)
                NumberOfDependents = 0;
            else if (NumberOfDependents > 3)
                NumberOfDependents = 3;
            else
                NumberOfDependents = numberOfDependents;
        }


        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public string[] Dependents
        {
            get
            {
                return dependents;
            }

            set
            {
                dependents = value;
            }
        }

        public string EmployeeName
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
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

        public bool Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public static int NextEmployeeNumber
        {
            get
            {
                return nextEmployeeNumber;
            }

            set
            {
                nextEmployeeNumber = value;
            }
        }

        public short NumberOfDependents
        {
            get
            {
                return numberOfDependents;
            }

            set
            {
                numberOfDependents = value;
            }
        }

       
        public int AddDependent(string dependentName)
        {
            int countDependent = 0;
            for (int i = 0; i < Dependents.Length; i++)
            {
                if (Dependents[i] != null)
                {
                    countDependent++;
                    if(countDependent == 3)
                    {
                        return 0;
                    }
                }
                else
                {
                    Dependents[i] = dependentName;
                    countDependent++;
                    break;
                }
                return countDependent;
            }
            return 0;
        }

        public bool UpdateDependents(string dependentName, int dependentId)
        {
            //check size of dependent array
            //check dependentId is between 1 and 3
            //put dependentName in the index specified.

            if (AddDependent(dependentName) != Dependents.Length)
            {
                if (dependentId >= 1 && dependentId <= 3)
                {
                    int index = dependentId - 1;
                    for (int i = index; i < Dependents.Length - 1; i++)
                    {
                        Dependents[i + 1] = Dependents[i];
                        Dependents[i] = dependentName;
                        return true;
                    }

                }
                return false;
            }
            return false;
        }
    }
}
