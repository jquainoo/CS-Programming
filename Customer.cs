using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infosys.AdvancedCSProgrammingExercises
{
    public class Customer
    {
        private static int counter;
        private string emailId;



        public string Address { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailId
        {
            get
            {
                return emailId;
        
            }
            set
            {
                if(value.Length >= 7 && countAt('@', value) > 1 && !value.StartsWith("@") && value.EndsWith(".com"))
                {
                    emailId = value;
                }
                else
                {
                    value = "NA";
                    throw new InvalidEmailIdException("Email address is invalid");
                }
            }
        }
        public char Gender { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }



        static Customer()
        {
            counter = 1001;
        }
        public Customer()
        {

        }

        public int countAt(char atString, string checkString)
        {
            int count = 0;
            char[] arr = checkString.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                if (atString == arr[i])
                    count++;
            }

            return count;
        }
    }
}
