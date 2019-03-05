using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.DayTwo
{
    //Assignment 9

    public class Employee
    {
        //Instance variables
        private DateTime dateOfBirth;
        private string[] dependents;
        private string employeeName;
        private int employeeId;
        private bool gender;
        private short numberOfDependents;

        //static variables
        private static int nextEmployeeNumber;



        static Employee()
        {
            nextEmployeeNumber = 1001;
        }

        public Employee()
        {
            this.employeeId = nextEmployeeNumber++;
            this.dependents = new string[3];

        }

        public Employee(int employeeId, string employeeName, DateTime dateOfBirth, bool gender)
            : this()
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;

        }

        public Employee(int employeeId, string employeeName, DateTime dateOfBirth, bool gender, short numberOfDependents, string[] dependents)
            : this()
        {
            if (this.numberOfDependents < 0)
                this.numberOfDependents = 0;
            else if (this.numberOfDependents > 3)
                this.numberOfDependents = 3;
            else
                this.numberOfDependents = numberOfDependents;
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



        public string this[int dependentId]
        {
            get
            {
                if (dependentId >= 1 && dependentId <= 3)
                    return dependents[dependentId];
                else
                    return null;
            }
            set

            {
                if (dependentId >= 1 && dependentId <= 3)
                    if (dependents[dependentId] == null)
                        NumberOfDependents++;
                    else if (value == null)
                        NumberOfDependents--;
                    else
                        dependents[dependentId] = value;

            }
        }


        public string this[string dependentRelation]
        {
            get
            {
                if (dependentRelation.ToLower().Equals("spouse"))
                    return dependents[0];
                else if (dependentRelation.ToLower().Equals("child1"))
                    return dependents[1];
                else if (dependentRelation.ToLower().Equals("child2"))
                    return dependents[2];
                else
                    return null;
            }
            set

            {
                if (dependents[0] == null && dependentRelation.ToLower().Equals("spouse"))
                    dependents[0] = value;
                else if (dependents[1] == null && dependentRelation.ToLower().Equals("child1"))
                    dependents[1] = value;
                else if (dependents[2] == null && dependentRelation.ToLower().Equals("child2"))
                    dependents[2] = value;

            }
        }




        public int AddDependent(string dependentName)
        {
            int countDependent = 0;
            for (int i = 0; i < dependents.Length; i++)
            {
                if (dependents[i] != null)
                {
                    countDependent++;
                    if (countDependent == 3)
                    {
                        return 0; 
                    }
                }
                else
                {
                    dependents[i] = dependentName;
                    countDependent++;
                    break;
                }
                numberOfDependents = (short)countDependent;
                return countDependent;
            }
            return 0;
        }

        public bool UpdateDependents(string dependentName, int dependentId)
        {
            //check size of dependent array
            //check dependentId is between 1 and 3
            //put dependentName in the index specified.

            if (AddDependent(dependentName) != dependents.Length)
            {
                if (dependentId >= 1 && dependentId <= 3)
                {
                    int index = dependentId - 1;
                    for (int i = index; i < dependents.Length - 1; i++)
                    {
                        dependents[i + 1] = dependents[i];
                        dependents[i] = dependentName;
                        return true;
                    }

                }
                return false;
            }
            return false;
        }
    }
}
