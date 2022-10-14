using System;

namespace Assessment;
public delegate void EventManger();
public class Operation
{
    public static event EventManger eventLink=null;
    public static void Subscribe()
    {
        eventLink+=new EventManger(Files.Create);
        eventLink+=new EventManger(Files.ReadFile);
        eventLink+=new EventManger(Operation.MainMenu);
        eventLink+=new EventManger(Files.WriteToFiles);
    }
    public static void Startevent()
    {
        Subscribe();
        eventLink();
    }


    public static List<CustomerRegistration> customerList=new List<CustomerRegistration>();
    public static List<ProductDetail> productList=new List<ProductDetail>();
    public static List<BookingDetail> bookingList=new List<BookingDetail>();
    public static List<OrderDetail> orderList=new List<OrderDetail>();

    public static CustomerRegistration currentLoggedIncustomer;
    
    
    public static void MainMenu()
    {
       //AddDefaultData();
        string choice="yes";
    do{
        System.Console.WriteLine("Enter the option:\n1.Customer Registration \n2.Customer Login \n3.Exit");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {

                CustomerRegistration();
                break;
            }
            case 2:
            {
                CustomerLogin();

                break;
            }
            case 3:
            {
                System.Console.WriteLine("Exit Main menu");
                choice="no";

                break;
            }

        }

    }while (choice=="yes");
      
    }
    public static void CustomerRegistration()
    {
        System.Console.WriteLine("Enter your Name:");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter your Father Name:");
        string fatherName=Console.ReadLine();
        System.Console.WriteLine("");
        System.Console.WriteLine("Enter your Gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine());
        System.Console.WriteLine("Enter your Mobile Number:");
        long mobileNumber=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Date of Birth:");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy"),null);
        System.Console.WriteLine("Enter your mail id:");
        string mailId=Console.ReadLine();


        CustomerRegistration person=new CustomerRegistration(name,fatherName,gender,mobileNumber,dob,mailId);
        customerList.Add(person);
        System.Console.WriteLine("Customer Id:"+person.CustomerId);

        
       



    }
    public static void CustomerLogin()
    {
        System.Console.WriteLine("Enter your Customer Id:");
        string customerId=Console.ReadLine().ToUpper();
        int flag=0;
        foreach(CustomerRegistration customer in customerList)
        {
            if(customer.CustomerId==customerId)
            {
                currentLoggedIncustomer=customer;
                System.Console.WriteLine("Login Successfully");
                SubMenu();

                flag=1;

            }
        }
        if(flag==0)
        {
            System.Console.WriteLine("Invalid Id");
        }
        

    }
    public static void SubMenu()
    {

        string choice="yes";
        do{
        System.Console.WriteLine("Enter the option:\n1.Show detail \n2.Show product detail \n3.Wallet Recharge\n4.Take Order \n5.Modify order quantity \n6.Cancel order\n7.Exit");
        int option =int.Parse(Console.ReadLine());

            switch(option)
             {
            case 1:
            {
                System.Console.WriteLine("Show detail----\n");
                currentLoggedIncustomer.ShowCustomerDetail();
                break;
            }
            case 2:
            {
                System.Console.WriteLine("\n----Show product detail----\n");
                ShowProductDetail();
                break;
            }
            case 3:
            {
                System.Console.WriteLine("\n-----Wallet Recharge-----\n");
                currentLoggedIncustomer.WalletRecharge();
                break;
            }
            case 4:
            {
                System.Console.WriteLine("\n----Take Order-----\n");
                TakeOrder();

                break;
            }
            case 5:
            {
                System.Console.WriteLine("\n------Modify order quantity------\n");
                ModifyOrder();
                break;

            }
            case 6:
            {
                System.Console.WriteLine("\n------Cancel order-------\n");
                CancelOrder();
                break;
            }
            case 7:
            {
                System.Console.WriteLine("\n------Exit------\n");
                choice="no";
                break;
            }
            }
            
        }while(choice=="yes");


        
        
    }


    public static void AddDefaultData()
    {
        CustomerRegistration person1=new CustomerRegistration("Baskaran","Sethurajan",Gender.Male,847575775,new DateTime(1999,11,11),"baskaran@gmail.com");
        customerList.Add(person1);
        //product detail data
        ProductDetail product1=new ProductDetail("Sugar",20,40);
        productList.Add(product1);
        ProductDetail product2=new ProductDetail("Rice",100,50);
        productList.Add(product2);
        ProductDetail product3=new ProductDetail("Milk",10,40);
        productList.Add(product3);
        ProductDetail product4=new ProductDetail("Coffee",10,10);
        productList.Add(product4);
        ProductDetail product5=new ProductDetail("Tea",10,20);
        productList.Add(product5);
        ProductDetail product6=new ProductDetail("Masala Powder",10,10);
        productList.Add(product6);
        ProductDetail product7=new ProductDetail("Salt",10,10);
        productList.Add(product7);
        ProductDetail product8=new ProductDetail("Tumeric powder",10,20);
        productList.Add(product8);
        ProductDetail product9=new ProductDetail("Chilli powder",10,25);
        productList.Add(product9);
        ProductDetail product10=new ProductDetail("Groundnut oil",10,40);
        productList.Add(product10);

                //Booking detail data
        BookingDetail booking1=new BookingDetail("CID3001",220,new DateTime(2022,07,26),BookingStatus.Booked);
        bookingList.Add(booking1);
        BookingDetail booking2=new BookingDetail("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);
        bookingList.Add(booking2);
        BookingDetail booking3=new BookingDetail("CID3001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);
        bookingList.Add(booking3);
        BookingDetail booking4=new BookingDetail("CID3002",280,new DateTime(2022,07,26),BookingStatus.Initiated);
        bookingList.Add(booking4);

        //Order Detail data
        OrderDetail order1=new OrderDetail("BID3001","PID101",2,80);
        orderList.Add(order1);

        OrderDetail order2= new OrderDetail("BID3001","PID102",2,100);
        orderList.Add(order2);

        OrderDetail order3=new OrderDetail("BID3001","PID103",1,40);
        orderList.Add(order3);
        OrderDetail order4=new OrderDetail("BID3002","PID101",1,40);
        orderList.Add(order4);
        OrderDetail order5=new OrderDetail("BID3002","PID102",4,200);
        orderList.Add(order5);
        OrderDetail order6=new OrderDetail("BID3002","PID110",1,140);
        orderList.Add(order6);
        OrderDetail order7=new OrderDetail("BID3002","PID109",1,20);
        orderList.Add(order7);
        OrderDetail order8=new OrderDetail("BID3003","PID102",2,100);
        orderList.Add(order8);
        OrderDetail order9=new OrderDetail("BID3003","PID108",4,100);
        orderList.Add(order9);
        OrderDetail order10=new OrderDetail("BID3003","PID101",2,80);
        orderList.Add(order10);
    }
    public static void ShowProductDetail()
    {
        foreach(ProductDetail product in productList)
        {
            System.Console.WriteLine($"Product Id:{product.ProductId} \tProduct name:{product.ProductName} \tQuantity Available:{product.QuantityAvailable} \tQuantity price:{product.QuantityPrice}");
        }

    }
    public static void TakeOrder()
    {
        //Create a booking object
        double totalPrice1=0;

        BookingDetail tempbooking=new BookingDetail(currentLoggedIncustomer.CustomerId,totalPrice1,DateTime.Now,BookingStatus.Initiated);
        List<OrderDetail> tempOrderList=new List<OrderDetail>();
        string choice="yes";
        do{

        //Show product detailed list
        ShowProductDetail();



        //select a product and check the quantity

        System.Console.WriteLine("Select a product from above the product list id:");
        string tempProductId=Console.ReadLine();
         int flag=0;
         int flag1=0;
        foreach(ProductDetail product in productList)
        {
            if(product.ProductId==tempProductId)
            {
                flag=1;
                 //Get the Quantity and compare with the availability
                System.Console.WriteLine("Enter the quantity you want:");
                int quantity1=int.Parse(Console.ReadLine());
                if(quantity1<product.QuantityAvailable)
                {
                    flag1=1;
                //Calculate price and compare with customer wallet
                totalPrice1=product.QuantityPrice*quantity1;
                OrderDetail tempOrderObject=new OrderDetail(tempbooking.BookingId,product.ProductId,quantity1,totalPrice1);
                product.QuantityAvailable--;
                tempOrderList.Add(tempOrderObject);
                System.Console.WriteLine("Add product to cart successfully.");

                }
                if(flag1==0)
                {
                    System.Console.WriteLine("Product count is not available");
                }


            }
        }
        if (flag==0)
        {
            System.Console.WriteLine("Product is not available");
        }


        System.Console.WriteLine("Do you want Add another product to the cart?");
        choice=Console.ReadLine().ToLower();
        
        }while(choice=="yes");
        double totalProductPrice=0;

        //take order and create object and add in local list

        foreach(OrderDetail order in tempOrderList)
        {
            totalProductPrice=totalProductPrice+order.PriceOfOrder;

        }
        System.Console.WriteLine("Do you want to proceed? 'yes' or 'no'");
        string choice3=Console.ReadLine().ToLower();
        if(choice3=="yes")
        {
            while(choice3=="yes")
            {
            
                if(currentLoggedIncustomer.WalletBalance>=totalProductPrice)
                {
                    currentLoggedIncustomer.WalletBalance-=totalProductPrice;
                    tempbooking.BookingStatus=BookingStatus.Booked;
                    tempbooking.TotalPrice=totalProductPrice;
                    orderList.AddRange(tempOrderList);
                    System.Console.WriteLine("Your order is successfully.");
                
                    break;
                }
                else{

                    System.Console.WriteLine("You have insufficient balance.");
                    System.Console.WriteLine($"TotalProductPrice: {totalProductPrice} and Your wallet balance: {currentLoggedIncustomer.WalletBalance}");
                    currentLoggedIncustomer.WalletRecharge();
                }


            }

        }
        else{
            foreach(ProductDetail product in productList)
            {
                foreach(OrderDetail order in orderList)
                {
                    System.Console.WriteLine("your cart will be deleted");
                    if(product.ProductId==order.OrderId)
                    {
                        product.QuantityAvailable+=order.PurchaseCount;
                        System.Console.WriteLine("Your cart will be deleted");
                    }
                }
                
            }

        }


    }
    public static void ModifyOrder()
    {
        System.Console.WriteLine("\n-----Modify order----\n");

    }
    public static void CancelOrder()
    {
        System.Console.WriteLine("\n------Cancel Order------\n");
    }

}