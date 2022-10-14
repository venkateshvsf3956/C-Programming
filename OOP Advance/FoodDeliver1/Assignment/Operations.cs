using System;


namespace FoodDeliveryApplication
{
    public delegate void EventManager();
        public static class Operations
    {

        public static event EventManager eventLink = null; 

        public static void Subscribe()
        {
            eventLink += new EventManager(Files.Create);

            eventLink += new EventManager(Files.ReadFiles);

            eventLink += new EventManager(Operations.MainMenu);

            eventLink += new EventManager(Files.WriteToFiles);
        }

        public static void StartEvent()
        {
            Subscribe();
            eventLink();
        }

        public static CustomerRegistration currentCustomer = null;
        public static List<CustomerRegistration> customerList = new List<CustomerRegistration>();

        public static List<FoodDetails> foodList = new List<FoodDetails>();

        public static List<BookingDetails> bookingList = new List<BookingDetails>();

        public static List<OrderDetails> orderList = new List<OrderDetails>();



        public static void MainMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select option \n1.Customer Registration \n2.Customer Login \n3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Customer Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Customer Login");
                        CustomerLogin();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice = "no";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void Registration()
        {
            System.Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your father name : ");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter your gender : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your mobile number : ");
            long mobile = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your date of birth : ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your mail ID : ");
            string mail = Console.ReadLine();
            System.Console.WriteLine( "Enter your location : ");
            string location = Console.ReadLine();
            
            CustomerRegistration customer1 = new CustomerRegistration(name,fatherName,gender,mobile,dob,mail,location);
            customerList.Add(customer1);

            System.Console.WriteLine("Your Customer ID is "+customer1.CustomerID);
        }

        public static void CustomerLogin()
        {
            System.Console.WriteLine("Enter your Customer ID : ");
            string customerId = Console.ReadLine();
            int flag =0;
            foreach(CustomerRegistration user in customerList)
            {
                if(user.CustomerID==customerId)
                {
                    flag++;
                    System.Console.WriteLine("Login Successfully");
                    currentCustomer=user;
                    SubMenu();
                    

                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("Invalid ID");
            }
        }

        public static void SubMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select option \n1.Show Food Item Details \n2.Order Food \n3.Cancel Booking \n4.Order History 5.Recharge Wallet 6.Exit SubMenu");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show Food Item Details");
                        ShowFoodItemDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Order Food");
                        OrderFood();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Cancel Booking");
                        CancelBooking();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Order History");
                        OrderHistory();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Recharge Wallet");
                        currentCustomer.WalletRecharge();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("Exit SubMenu");
                        choice = "no";
                        break;
                    }

                }
            }while(choice=="yes");
        }


        public static void ShowFoodItemDetails()
        {
            foreach(FoodDetails food in foodList)
            {
                System.Console.WriteLine($"Food ID is {food.FoodID} Food Name is {food.FoodName} Food Price Per Quantity is {food.PricePerQuantity} ");
            }
        }

        public static void OrderFood()
        {
            List<OrderDetails> orderList1=new List<OrderDetails>();
            orderList1.AddRange(orderList);
            

            System.Console.WriteLine("Do you want to purchase or not ? Enter 'yes' or 'no' ");
            string opinion = Console.ReadLine();
            string choice = "";
            if(opinion=="yes")
            {
                BookingDetails booking1 = new BookingDetails(currentCustomer.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
                bookingList.Add(booking1);
                
                do
                {
                    foreach(FoodDetails food1 in foodList)
                    {
                        System.Console.WriteLine($"Food ID is {food1.FoodID} Food Name is {food1.FoodName} Food Price Per Quantity is {food1.PricePerQuantity} ");
                    }

                    System.Console.WriteLine("Enter the food ID to order : ");
                    string foodID = Console.ReadLine();
                    System.Console.WriteLine("Enter the purchase quantity : ");
                    int purchaseCount = int.Parse(Console.ReadLine());
                    int flag =0;
                    foreach(FoodDetails food in foodList)
                    {
                       if(food.FoodID==foodID)
                       {
                            flag++;
                            double orderPrice = purchaseCount*food.PricePerQuantity;
                            double totalPrice =0;
                            //totalPrice+=orderPrice; 
                            if(currentCustomer.WalletBalance>=orderPrice)
                            {
                                OrderDetails order1 = new OrderDetails(booking1.BookingID,food.FoodID,purchaseCount,orderPrice);
                                orderList1.Add(order1);
                                totalPrice+=orderPrice;
                                booking1.TotalPrice=totalPrice;

                                currentCustomer.WalletBalance-=orderPrice;
                                
                            }
                            else
                            {
                                System.Console.WriteLine("Not Enough Balance");
                                
                            }
                       }
                    

                        
                    }
                    if(flag == 0)
                    {
                        System.Console.WriteLine("Invalid Food ID");
                    }

                    System.Console.WriteLine("Do you want to place another order? Enter 'yes' or 'no'");
                    choice = Console.ReadLine();
                }while(choice=="yes");
                if(choice == "no")
                {
                    foreach(BookingDetails book in bookingList)
                    {
                        if(book.BookingID==booking1.BookingID)
                        {
                            booking1.BookingStatus= BookingStatus.Booked;
                            
                        }
                    }
                    
                }

                System.Console.WriteLine("Booking Successful and your Booking ID is "+booking1.BookingID);
            }
        }


        public static void CancelBooking()
        {
            foreach(BookingDetails booking in bookingList)
            {
                if(currentCustomer.CustomerID==booking.CustomerId && booking.BookingStatus==BookingStatus.Booked)
                {
                    System.Console.WriteLine($"Booking ID is {booking.BookingID} \t Cutomer ID is {booking.CustomerId} \t Total Price is {booking.TotalPrice} \t Booked Date is {booking.DateOfBooking} \t Booking status is {booking.BookingStatus} ");
                    
                }
            }
            System.Console.WriteLine("Enter the booking ID to cancel : ");
            string bookingID = Console.ReadLine();
            foreach(BookingDetails book in bookingList)
            {
                if(bookingID==book.BookingID)
                    {
                        book.BookingStatus = BookingStatus.Cancelled;
                        currentCustomer.WalletBalance+=book.TotalPrice;
                        System.Console.WriteLine("Cancelled Booking Successfully");
                    }
            }
        }


        public static void OrderHistory()
        {
            foreach(BookingDetails book in bookingList)
            {
                if(book.CustomerId==currentCustomer.CustomerID)
                {
                    foreach(OrderDetails order in orderList)
                    {
                        if(order.BookingId==book.BookingID)
                        {
                            System.Console.WriteLine($"Order ID is {order.OrderID}\t Booking ID is {order.BookingId}\t Food ID is {order.FoodId}\t Purchase Count is {order.PurchaseCount}\t Price of Order is {order.PriceOfOrder} ");
                        }
                    }
                }
            }
        }
    }
}