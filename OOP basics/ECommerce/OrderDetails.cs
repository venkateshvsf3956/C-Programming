using System;
using System.Collections.Generic;

namespace ECommerce
{
    public enum OrderStatus{Default,Ordered,Cancelled}
    public class OrderDetails
    {
        public static int s_orderId=1000;
        public string OrderId{ get; }
        public string CustomerId { get; set; }
        public string ProductId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public OrderStatus OrderStatus{get;set;}
        public OrderDetails(string customerId,string productId,double totalPrice,DateTime purchaseDate,int quantity,OrderStatus orderstatus)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            CustomerId=customerId;
            ProductId=productId;
            TotalPrice=totalPrice;
            PurchaseDate=purchaseDate;
            Quantity=quantity;
            OrderStatus=orderstatus;

        }
        
    }
}