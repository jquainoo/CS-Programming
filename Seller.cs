
namespace DayTwoExercises.StaticMCV
{
    public class Seller
    {
 
        private string sellerId;
        private string sellerName;
        private static int sellerIdCount;



        static Seller()
        {
            sellerIdCount = 1001;
        }

        public Seller()
        {
            this.sellerId = "S" + sellerIdCount++;
        }

           //Paramatized constructors
        public Seller(string sellerId, string sellerName)
        {
            SellerId = sellerId;
            SellerName = sellerName;
        }

        //Auto-implemented Properties
        public string[] SellerLocations { get; set; }


        public string SellerId
        {
            get
            {
                return sellerId;
            }

            set
            {
                sellerId = value;
            }
        }

        public string SellerName
        {
            get
            {
                return sellerName;
            }

            set
            {
                if(Validator.isName(value) == true)
                    sellerName = value;
            }
        }
    }
}
