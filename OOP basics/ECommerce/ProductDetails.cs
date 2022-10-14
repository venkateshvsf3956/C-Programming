using System;
using System.Collections.Generic;
namespace ECommerce
{
    public class ProductDetails
    {
        public static int s_productId=100;
        public string  ProductId { get; set; }
        public string ProductName { get; set; }
        public Double  Price{ get; set; }
        public int Stock { get; set; }
        public int StockDuration{ get; set; }

        public ProductDetails(string productName,double price,int stock,int stockDuration)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productName;
            Price=price;
            Stock=stock;
            StockDuration=stockDuration;
        }
        
    }
}