using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayOne
{
    public class Customer

    {
        private int counter;
        private string emailId;
        private bool flag = false;

        public Customer() 
        {
            counter = 0;

        }

        public string CustomerName { get; set; }
        public string EmailId {
            get
            {
                return emailId;
            }
            set
            {
                try
                {
                    if (countAt(value) == 1 && !value.StartsWith("@") && value.EndsWith(".com"))
                        emailId = value;
                }
                catch(InvalidEmailIdException ex){
                    flag = true;
                    InvalidEmailIdException invalid = new InvalidEmailIdException("Invalid email address");
                    throw invalid;
                }
            }
        }

        public string PhoneNumber {
            get
            {
                return PhoneNumber;
            }

            set
            {
                if (value.Length == 10 && !value.StartsWith("0") && value.Any(char.IsDigit))
                    PhoneNumber = value;
                else
                {
                    flag = true;
                    InvalidPhoneNumberException invalid = new InvalidPhoneNumberException("Invalid Phone Number");
                    throw invalid;
                }
            }
        }

        public string Password { get; set; }
        public string Address { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }



        private int countAt(string emailAddress)
        {
            char[] email = emailAddress.ToCharArray();
            int count = 0;
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == ('@'))
                    count++;
            }
            return count;
        }
    }
}
