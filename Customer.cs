using System;

namespace Infosys.Exercises1Class
{
    public class Customer
    {
        //Member Variables for Customer
        private string address;
        private int customerId;
        private string customerName;
        private string customerType;
        private DateTime dateOfBirth;
        private string emailId;
        private string gender;
        private string password;

        public Customer(int customerId, string customerName, string address, 
            DateTime dateOfBirth,string emailId, string gender, string password,
            string customerType){
            this.customerId = customerId;
            this.customerName = customerName;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
            this.emailId = emailId;
            this.gender = gender;
            this.password = password;
            this.customerType = customerType;
        }

        public double GetDiscount(){
            double discount = 0.0;
            if (string.Equals(customerType, "priviledged", StringComparison.OrdinalIgnoreCase))
                discount = 2;
            else if (string.Equals(customerType, "regular", StringComparison.OrdinalIgnoreCase))
                discount = 5;
            else if (string.Equals(customerType, "elite", StringComparison.OrdinalIgnoreCase))
                discount = 7;
            else
                discount = 0;
            return discount;
        }
    }
}
