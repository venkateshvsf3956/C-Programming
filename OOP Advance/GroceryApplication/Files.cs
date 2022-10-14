using System;
using System.IO;
namespace Assessment
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Grocery"))
            {
                System.Console.WriteLine("Creating folder");
                Directory.CreateDirectory("Grocery");
            }
            if(!File.Exists("Grocery/CustomerRegistration.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Grocery/CustomerRegistration.csv");
            }
            if(!File.Exists("Grocery/ProductDetail.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Grocery/ProductDetail.csv");
            }
            if(!File.Exists("Grocery/BookingDetail.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Grocery/BookingDetail.csv");
            }
            if(!File.Exists("Grocery/OrderDetail.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("Grocery/OrderDetail.csv");
            }
        }
        public static void ReadFile()
        {
            string []customer=File.ReadAllLines("Grocery/CustomerRegistration.csv");
            foreach(string customerData in customer)
            {
                CustomerRegistration customer1=new CustomerRegistration(customerData);
                Operation.customerList.Add(customer1);
            }

            string []product=File.ReadAllLines("Grocery/ProductDetail.csv");
            foreach(string productData in product)
            {
                ProductDetail product1=new ProductDetail(productData);
                Operation.productList.Add(product1);
            }
            string []booking =File.ReadAllLines("Grocery/BookingDetail.csv");
            foreach(string bookingdata in booking)
            {
                BookingDetail booking1=new BookingDetail(bookingdata);
                Operation.bookingList.Add(booking1);

            }
            string []order=File.ReadAllLines("Grocery/OrderDetail.csv");
            foreach(string orderData in order)
            {
                OrderDetail order1=new OrderDetail(orderData);
                Operation.orderList.Add(order1);
            }
        }
        public static void WriteToFiles()
        {
            string[]customer=new string[Operation.customerList.Count];
            for(int i=0;i<Operation.customerList.Count;i++)
            {
                customer[i]=Operation.customerList[i].CustomerId+','+Operation.customerList[i].Name+','+Operation.customerList[i].FatherName+','+Operation.customerList[i].Gender+','+Operation.customerList[i].MobileNumber+','+Operation.customerList[i].DateOfBirth.ToString("dd/MM/yyyy")+','+Operation.customerList[i].MailId+','+Operation.customerList[i].WalletBalance;


            }
            File.WriteAllLines("Grocery/CustomerRegistration.csv",customer);
            string []product=new string [Operation.productList.Count];
            for (int i=0;i<Operation.productList.Count;i++)
            {
                product[i]=Operation.productList[i].ProductId+','+Operation.productList[i].ProductName+','+Operation.productList[i].QuantityAvailable+','+Operation.productList[i].QuantityPrice;
            }
            File.WriteAllLines("Grocery/ProductDetail.csv",product);
            string []booking=new string[Operation.bookingList.Count];
            for (int i=0;i<Operation.bookingList.Count;i++)
            {
                booking[i]=Operation.bookingList[i].BookingId+','+Operation.bookingList[i].CustomerId+','+Operation.bookingList[i].TotalPrice+','+Operation.bookingList[i].DateOfBooking.ToShortDateString()+','+Operation.bookingList[i].BookingStatus;

            }
            File.WriteAllLines("Grocery/BookingDetail.csv",booking);
            string [] order=new string[Operation.orderList.Count];
            for (int i =0;i<Operation.orderList.Count;i++)
            {
                order[i]=Operation.orderList[i].OrderId+','+Operation.orderList[i].BookingId+','+Operation.orderList[i].ProductId+','+Operation.orderList[i].PurchaseCount+','+Operation.orderList[i].PriceOfOrder;
            }
            File.WriteAllLines("Grocery/OrderDetail.csv",order);

        }


        
    }

}