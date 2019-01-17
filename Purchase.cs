
using System;

//Exercise 2
namespace DayTwoExercises.StaticMCV
{
    public class Purchase
    {
        private DateTime dateOfPurchase;
        private string paymentType;
        private string purchaseId;
        private int quantityOrdered;
        private string shippingAddress;

        //static varibale 
        private static int purchaseCounter;

        static Purchase()
        {
            purchaseCounter = 1001;
        }

        public Purchase()
        {
            this.purchaseId = "B" + purchaseCounter++;
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
                if(Validator.isName(value) == true)
                    shippingAddress = value;
            }
        }


        //Class Methods
        public double CalculateBillAmount(double price)
        {
            return QuantityOrdered * price;
        }

        public static double RoundOffBill(double amount)
        {
            return Math.Round(amount, 2);
        }
        

        //////check implementation
        public static double getpurchasepercentage(DateTime[] transactiondates, DateTime dateforreport)
        {
            double purchasepercentage = -1.0;
            for (int i = 0; i < transactiondates.Length; i++)
            {
                if (dateforreport == transactiondates[i])
                {
                    //purchase percentage = no. of purchases made on the particular date/ 
                    //total no. of purchases *100
                    purchasepercentage = (purchaseCounter - 1001) / purchaseCounter * 100;
                }
            }
            return purchasepercentage;
        }


        //Overloading Methods

        //public double CalculateBillAmount(double price, double discountPercentage)
        //{
        //    double totalAmount = CalculateBillAmount(price);
        //    return (totalAmount - (totalAmount * (discountPercentage / 100)));
        //}

        //public double CalculateBillAmount(params Product[] products)
        //{
        //    double totalPrice = 0, totalBillAmount = 0, serviceTax, discountPercentage;
        //    for (int i = 0; i < products.Length; i++)
        //    {
        //        totalPrice += products[i].Price;
        //    }
        //    serviceTax = 0.07 * totalPrice;
        //    discountPercentage = CalculateDiscount();

        //    totalBillAmount += (totalPrice + serviceTax) * (1 - discountPercentage);
        //    return totalBillAmount;
        //}


        //public double CalculateBillAmount(Product product, int quantityRequired)
        //{
        //    double totalPrice = 0, totalBillAmount = 0, serviceTax, discountPercentage;
        //    totalPrice = product.Price * quantityRequired;
        //    serviceTax = 0.07 * totalPrice;
        //    discountPercentage = CalculateDiscount();
        //    totalBillAmount += (totalPrice + serviceTax) * (1 - discountPercentage);
        //    return totalBillAmount;
        //}

        //private double CalculateDiscount()
        //{
        //    double discount = 0.05;
        //    return discount;
        //}
    }
}
