using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayOne
{
    public class CustomerDetails
    {
        //Write the main method
        private int indexNumber;
        private Customer[] listOfCustomers;

        public CustomerDetails()
        {
            indexNumber = 0;
            listOfCustomers = new Customer[10];
        }

        public bool AddCustomer(Customer customer)
        {
            if(indexNumber < 10 && customer != null)
            {
                listOfCustomers[indexNumber] = customer;
                indexNumber++;
                return true;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            Customer customer = new Customer();
            CustomerDetails customerDetails = new CustomerDetails();
            string customerName, emailId, phoneNumber;
        }
    }
}
