namespace Assessment
{
    public class OrderDetail
    {
        public static int s_orderId=100;
        public string  OrderId { get;  }
        public string BookingId { get;  }
        public string  ProductId { get; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }

        public OrderDetail(string bookingId,string productId,int purchaseCount,double priceOfOrder)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            BookingId=bookingId;
            ProductId=productId;
            PurchaseCount=purchaseCount;
           PriceOfOrder=priceOfOrder;
        }
        public OrderDetail(string data)
        {
            string []value=data.Split(",");
            s_orderId=int.Parse(value[0].Remove(0,3));
            OrderId=value[0];
            BookingId=value[1];
            ProductId=value[2];
            PurchaseCount=int.Parse(value[3]);
            PriceOfOrder=double.Parse(value[4]);
        }
    }
}