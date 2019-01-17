
namespace Infosys.QuickKartBusinessLayer
{
    public class Seller
    {
        static int sellerIdCount;
        private string sellerId;
        private string sellerName;

        public string[] SellerLocations { get; set; }


        //Static constructor
        static Seller()
        {
            sellerIdCount = 1001;

        }

        //Default constructor
        public Seller()
        {
            sellerId = "S" + sellerIdCount++;
        }


        //Paramatized constructors
        public Seller(string sellerId, string sellerName)
        {
            SellerId = sellerId;
            SellerName = sellerName;
        }


        public Seller(string sellerName)
        {
            SellerName = sellerName;
        }

        public Seller(int maxSize)
            :this()
        {

        }


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
                sellerName = value;
            }
        }


      
      
    }
}
