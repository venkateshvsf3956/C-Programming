using System;
using System.Collections.Generic;
namespace ECommerce
{
    public static class Operations
    {
        static CustomerDetails currentCustomer=null;
        static List<CustomerDetails> customerList=new List<CustomerDetails>();
        static List<ProductDetails> productList=new List<ProductDetails>();
        static List<OrderDetails> orderList=new List<OrderDetails>();
        public static void DefaultData()
        {
            CustomerDetails customer1=new CustomerDetails("Ravi","Chennai",988585883,50000,"ravi@mail.com");
            customerList.Add(customer1);
            CustomerDetails customer2=new CustomerDetails("Baskaran","Chennai",9858858858,60000,"baskaran@mail.com");
            customerList.Add(customer2);
            ProductDetails product1=new ProductDetails("Mobile",10000,10,3);
            productList.Add(product1);
            ProductDetails product2=new ProductDetails("Tablet",15000,5,2);
            productList.Add(product2);
            ProductDetails product3=new ProductDetails("Camera",20000,3,4);
            productList.Add(product3);
            ProductDetails product4=new ProductDetails("iPhone",50000,5,6);
            productList.Add(product4);
            ProductDetails product6=new ProductDetails("Laptop",40000,3,3);
            productList.Add(product6);
            OrderDetails order1=new OrderDetails(customer1.CustomerId,product1.ProductId,20000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(order1);
            OrderDetails order2=new OrderDetails(customer2.CustomerId,product3.ProductId,40000,DateTime.Now,2,OrderStatus.Ordered);
            orderList.Add(order2);


        }
        public static void MainMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Enter the Option: 1.Customer Registeration\n2.Login and Purchase\n3.Exit");
                int option =int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Customer Registration.");
                        Registeration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login and Purchase.");
                        LoginAndPurchase();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("select the option.");
                        break;
                    }
                }
            }while(choice=="yes");
        }
        public static void Registeration()
        {
            System.Console.WriteLine("Enter your Name:");
            string customerName=Console.ReadLine();
            System.Console.WriteLine("Enter your city:");
            string city=Console.ReadLine();
            System.Console.WriteLine("Enter your Phone Number:");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your wallet Balance:");
            double walletBalance=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mail ID:");
            string mail=Console.ReadLine();
            
            CustomerDetails customer3=new CustomerDetails(customerName,city,mobileNumber,walletBalance,mail);
            customerList.Add(customer3);
            System.Console.WriteLine("Your Customer ID:"+customer3.CustomerId);
        }
        public static void LoginAndPurchase()
        {
            System.Console.WriteLine("Enter your Customer ID:");
            string customerId=Console.ReadLine();
            foreach(CustomerDetails customer in customerList)
            {
                if (customer.CustomerId==customerId)
                {
                    System.Console.WriteLine("Login Successful");
                    currentCustomer=customer;
                    SubMenu();
                    break;
                }
            }
        }
        public static void SubMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Select Option a.Purchase\n b.Order History\nc.Wallet Balance\nd.Cancel Order \ne. Exit");
                char option=char.Parse(Console.ReadLine());
                switch (option)
                {
                    case 'a':
                    {
                        System.Console.WriteLine("Purchase");
                        Purchase();
                        break;
                    }
                    case 'b':
                    {
                        System.Console.WriteLine("Order History");
                        OrderHistory();
                        break;

                    }
                    case 'c':
                    {
                        System.Console.WriteLine("Wallet balance");
                        WalletBalance();
                        break;
                    }
                    case 'd':
                    {
                        System.Console.WriteLine("Cancel Order");
                        CancelOrder();
                        break;
                    }
                    case 'e':
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }
            }while(choice=="yes");
        }
        public static void Purchase()
        {
            foreach(ProductDetails product in productList)
            {
                System.Console.WriteLine($"Product Id{product.ProductId}\tProduct Name :{product.ProductName}\tProduct Stock:{product.Stock}\t Product price per quantity{product.Price}\tProduct shipping duration{product.StockDuration}");

            }
            System.Console.WriteLine("Enter the Product Id :");
            string prouductId=Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter the quantity of the Product:");
            int count=int.Parse(Console.ReadLine());
            foreach(ProductDetails product1 in productList)
            {
                if (prouductId==product1.ProductId)
                {
                    if (count<product1.Stock){
                    double delivery=50;
                    double totalPrice=(count*product1.Price)+delivery;
                    if (currentCustomer.WalletBalance>=totalPrice)
                    {
                        currentCustomer.WalletBalance-=totalPrice;
                        product1.Stock-=count;
                        System.Console.WriteLine($"Order placed successfully .delvierdeon{DateTime.Now.AddDays(product1.StockDuration)}");
                        OrderDetails order3=new OrderDetails(currentCustomer.CustomerId,product1.ProductId,totalPrice,DateTime.Now,count,OrderStatus.Ordered);
                        orderList.Add(order3);
                    }
                    else
                    {
                        System.Console.WriteLine("Please recharge your wallet.");
                    }
                    }
                   else
                  {
                    System.Console.WriteLine("required count is not available");
                    System.Console.WriteLine("Current Availability:"+product1.Stock);
                  }
                }

            }
        }
        public static void OrderHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                if (order.CustomerId==currentCustomer.CustomerId)
                {
                    System.Console.WriteLine($"Your order ID:{order.OrderId}\n Customer Id:{order.CustomerId}\n Product ID {order.ProductId}\nTotal price:{order.TotalPrice}\nPurchase Date{order.PurchaseDate}\nProduct Quantity:{order.Quantity}\nOrder Status:{order.OrderStatus} ");

                }
            }
        }
        public static void WalletBalance()
        {
            foreach (CustomerDetails customer in customerList)
            if (currentCustomer.CustomerId==customer.CustomerId)
            {
                System.Console.WriteLine("Wallet Balance"+customer.WalletBalance);
                System.Console.WriteLine("Do you want recharge your wallet? 'yes' or 'no'");
                string option=Console.ReadLine().ToLower();
                if (option=="yes")
                {
                    System.Console.WriteLine("Enter the amount to be recharged:");
                    double amount=double.Parse(Console.ReadLine());
                    currentCustomer.WalletBalance+=amount;
                    System.Console.WriteLine("Wallet Balance"+currentCustomer.WalletBalance);
                }
            
                
            }
        }
        public static void CancelOrder()
        {
            foreach (OrderDetails cancel in orderList)
            {
                if (currentCustomer.CustomerId==cancel.CustomerId)
                {
                    System.Console.WriteLine($"Your orderId:{cancel.OrderId}\nCustomer Id:{cancel.CustomerId}\nProduct Id{cancel.ProductId}\nOrder Status:{cancel.OrderStatus}");

                }
            }
            System.Console.WriteLine("Enter the Order ID to be cancel");
            string orderId=Console.ReadLine();
            foreach(OrderDetails cancelOrder in orderList)
            {
                if (orderId==cancelOrder.OrderId)
                {
                    foreach(ProductDetails product in productList)
                    {
                        if (cancelOrder.ProductId==product.ProductId)
                        {
                            product.Stock+=cancelOrder.Quantity;
                            double deliveryCharge=50;
                            double returnAmount=(cancelOrder.Quantity*product.Price)-deliveryCharge;
                            currentCustomer.WalletBalance+=returnAmount;
                            System.Console.WriteLine("Order cancel successfully");
                            cancelOrder.OrderStatus=OrderStatus.Cancelled;
                        }
                    }
                }
            }
        }
    }
}