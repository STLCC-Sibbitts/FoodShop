using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShop
{
    class LineItem
    {
        public int LineItemID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ProductDescription { get; set; }
        public int UpsellID { get; set; }
        //public string TaxCategory { get; set; }

        // Default Constructor
        public LineItem()
        {

        }
        // Custom Constructor
        public LineItem(int orderID, int productID, int quantity, string productName, decimal price, string productDescription, int upsellID)
        {
            LineItemID = 0;
            ProductID = productID;
            Quantity = quantity;
            ProductName = productName;
            Price = price;
            ProductDescription = productDescription;
            UpsellID = upsellID;
        }
        /*
         * Joe, create your line item object based on the custom constructor above. Just create an instance of DBServices class, then call
         *  the addNewData method that takes a LineItem object
        */
    }
}
