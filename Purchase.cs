using Infosys.QuickKartBusinessLayer;
using System;

namespace Infosys.QuickKartBusinessLayer
{
    public class Purchase{
        static int purchaseCounter;
        private DateTime dateOfPurchase;
        private string paymentType;
        private string purchaseId;
        private int quantityOrdered;
        private string shippingAddress;



        static Purchase()
        {
            PurchaseCounter = 1001;
        }

        public Purchase()
        {
            purchaseId = "B" + PurchaseCounter++;
        }


        public Purchase(string purchaseId, int quantityOrdered, string shippingAddress, 
            DateTime dateOfPurchase, string paymentType)
        {
            this.PurchaseId = purchaseId;
            this.QuantityOrdered = quantityOrdered;
            this.ShippingAddress = shippingAddress;
            this.DateOfPurchase = dateOfPurchase;
            this.PaymentType = paymentType;
        }

        public DateTime DateOfPurchase
        {
            get
            {
                return dateOfPurchase;
            }

            set
            {
                dateOfPurchase = value;
            }
        }


        public string PaymentType
        {
            get
            {
                return paymentType;
            }

            set
            {
                paymentType = value;
            }
        }


        public string PurchaseId
        {
            get
            {
                return purchaseId;
            }

            set
            {
                purchaseId = value;
            }
        }


        public int QuantityOrdered
        {
            get
            {
                return quantityOrdered;
            }

            set
            {
                quantityOrdered = value;
            }
        }


        public string ShippingAddress
        {
            get
            {
                return shippingAddress;
            }

            set
            {
                shippingAddress = value;
            }
        }

        public static int PurchaseCounter
        {
            get
            {
                return purchaseCounter;
            }

            //Made it inaccessible
            private set
            {
                purchaseCounter = value;
            }
        }



        //Class Methods
        public double CalculateBillAmount(double price)
        {
            return QuantityOrdered * price;
        }

        public double CalculateBillAmount(double price, double discountPercentage)
        {
            double totalAmount = CalculateBillAmount(price);
            return (totalAmount - (totalAmount * (discountPercentage / 100)));
        }

        public static double RoundOffBill(double amount)
        {
            return Math.Round(amount, 2);
        }


        //Check implementation
        public static double GetPurchasePercentage(DateTime[] transactionDates, DateTime dateForReport)
        {
            double purchasePercentage = -1.0;
            for(int i = 0; i < transactionDates.Length; i++)
            {
                if(dateForReport == transactionDates[i])
                {
                    //Purchase percentage = No. of purchases made on the particular date/ 
                    //Total no. of purchases *100
                    purchasePercentage = (PurchaseCounter - 1001) / PurchaseCounter * 100;
                }
            }
            return purchasePercentage;
        }

        public double CalculateBillAmount(params Product[] products)
        {
            double totalPrice = 0, totalBillAmount = 0, serviceTax, discountPercentage;
            for(int i = 0; i < products.Length; i++)
            {
                totalPrice += products[i].Price;
            }
            serviceTax = 0.07 * totalPrice;
            discountPercentage = CalculateDiscount();

            totalBillAmount += (totalPrice + serviceTax) *(1 - discountPercentage);
            return totalBillAmount;
        }


        public double CalculateBillAmount(Product product, int quantityRequired)
        {
            double totalPrice = 0, totalBillAmount = 0, serviceTax, discountPercentage;
            totalPrice = product.Price * quantityRequired;
            serviceTax = 0.07 * totalPrice;
            discountPercentage = CalculateDiscount();
            totalBillAmount += (totalPrice + serviceTax) * (1 - discountPercentage);
            return totalBillAmount;
        }

        private double CalculateDiscount()
        {
            double discount = 0.05;
            return discount;
        }
    }
}
