namespace Infosys.Exercises1Class
{
    public class Product{
        private string productId;
        private string description;
        private double price;
        private string productName;

        public Product(string productId, string productName, string description, double price)
        {
            this.productId = productId;
            this.description = description;
            this.price = price;
            this.productName = productName;
        }
    }
}
