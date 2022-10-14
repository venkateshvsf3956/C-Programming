namespace Assessment
{
    public class ProductDetail
    {
        public static int s_productId=100;
        public string  ProductId { get; set; }
        public string ProductName{get;set;}
        public int QuantityAvailable { get; set; }
        public double QuantityPrice{get;set;}
        public ProductDetail(string productName,int quantityAvailable,double quantityPrice)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            QuantityPrice=quantityPrice;

        }
        public ProductDetail(string data){
            string [] value=data.Split(',');
            s_productId=int.Parse(value[0].Remove(0,3));
            ProductId=value[0];
            ProductName=value[1];
            QuantityAvailable=int.Parse(value[2]);
            QuantityPrice=double.Parse(value[3]);
        }


    }
}