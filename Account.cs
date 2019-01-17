using System;

namespace Assignments.DayOne
{
    //Assignment 1
    public class Account
    {
        private long accountNo;
        private double balance;
        private string[] payees;
        private long[] payeesAccount;


        
        public Account()
        {
        }

        //static constructor
        static Account()
        {

        }


        public Account(long accountNo, double balance)
        {
            this.accountNo = accountNo;
            this.balance = balance;
        }

        public Account(long accountNo, double balance, string[] payees, long[] payeesAccount)
            : this()
        {
            
            this.payees = payees;
            this.payeesAccount = payeesAccount;
        }

        public int DebitAmount(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return 1;
            }
            return 0;
        }

        public int TransferMoney(long payeeAccountNo, double amount)
        {
            foreach (long accNo in payeesAccount)
            {
                if (accNo == payeeAccountNo)
                {
                    return DebitAmount(amount);
                }
            }
            return -1;
        }

        public int TransferMoney(string nickName, double amount)
        {
            foreach (string accountName in payees)
            {
                if(string.Equals(accountName, nickName, StringComparison.OrdinalIgnoreCase))
                {
                    return DebitAmount(amount);
                }
            }
            return -1;
        }
    }
}
