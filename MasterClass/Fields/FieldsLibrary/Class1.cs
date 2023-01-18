using System;

namespace FieldsLibrary
{
    public class Product
    {
        //fields
        public int productID;
        public string productName;
        public double cost;
        public int quantityInStock;
        public static int TotalNoProducts;
        public const string CategoryName = "Electronics";

        public readonly string dateOfPurchase;

        public Product()
        {
            dateOfPurchase = DateTime.Now.ToShortDateString();
        }
    }
}
