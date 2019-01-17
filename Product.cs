namespace DayTwoExercises.StaticMCV
{
    public class Product{
        private string productId;
        private string description;
        private double price;
        private string productName;

        private static int currentProductId;


        static Product()
        {
            currentProductId = 100;
        }

        public Product()
        {
            this.productId = "P" + currentProductId++;
        }




        public Product(string productId, string productName, string description, double price)
        {
            ProductId = productId;
            Description = description;
            Price = price;
            ProductName = productName;
        }

        public string ProductId
        {
            get
            {
                return productId;
            }

            set
            {
                productId = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if(value > 0)
                    price = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
                if(Validator.isName(value))
                    productName = value;
            }
        }
    }
}
