using System;

namespace Exercises.Class
{
    public class LoanCalculation
    {
        public LoanCalculation()
        {

        }

        public bool ApplyForLoan(float salary, out int loanAmount, out int interest, params string[] doc)
        {
            loanAmount = -1; interest = -1;
            if (doc.Length >= 2)
            {
                for (int i = 0; i < doc.Length; i++)
                {
                    if (doc[i].ToLower().Equals("Passport".ToLower()))
                    {
                        if (salary < 12000)
                        {
                            loanAmount = 25000;
                            interest = 4;
                            return true;
                        }
                        else if (salary >= 12000 && salary <= 50000)
                        {
                            loanAmount = 50000;
                            interest = 6;
                            return true;
                        }
                        else if (salary > 50000)
                        {
                            loanAmount = 100000;
                            interest = 8;
                            return true;
                        }
                    }
                    return false;
                }
            }
            return false;
        }


        public void Emi_Discount(int loanAmount, int relativeMarketing, int tenure, int interest, out int emi)
        {
            emi = (loanAmount + (loanAmount * interest / 100)) / tenure;
            int discount = 0;
            if (relativeMarketing == 1)
            {
                discount = 10;
                emi = emi - (emi * discount / 100);
            }
            else if (relativeMarketing == 2)
            {
                discount = 8;
                emi = emi - (emi * discount / 100);
            }
            else if (relativeMarketing == 3)
            {
                discount = 6;
                emi = emi - (emi * discount / 100);
            }
            else
            {
                discount = 4;
                emi = emi - (emi * discount / 100);
            }
            

        }

        public void SalaryDeduction(ref float salary, int relativeMarketing,
            int loanAmount, int tenure, int interest, out int emi) {
            {
                Emi_Discount(loanAmount, relativeMarketing, tenure, interest, out emi);
                salary = salary - emi;
                Console.WriteLine("EMI = " + emi);
                Console.WriteLine("SALARY = " + salary);

            }
        }
    }
}
