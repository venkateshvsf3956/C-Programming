using System;
using System.Collections.Generic;


namespace Assessment1;
 public delegate void EventManger();

    
    public class Operation 
    {
        public static event EventManger eventLink=null;

        public static void Subsrcibe()
        {
            eventLink+=new EventManger(Files.Create);
           // eventLink+=new EventManger(Files.ReadFile);
            eventLink+=new EventManger(MainMenu);
            eventLink+=new EventManger(Files.WriteToFiles);
        }
        public static void StartEvent()
        {
            Subsrcibe();
            eventLink();
        }
        
        
        public static UserDetail currentUser=null;
        public static List<UserDetail> userList=new List<UserDetail>();
        public static List<MovieDetails> movieList=new List<MovieDetails>();
        public static List<TheatreDetails> theatreList=new List<TheatreDetails>();
        public static List<BookingDetail> bookingList=new List<BookingDetail>();
        public static List<ScreeningDetail> screenList=new List<ScreeningDetail>();


        public static void AddDefalut()
        {
            //user detail
            UserDetail user1=new UserDetail("Ravi",30,98765678);
            UserDetail user2=new UserDetail("Baskaran",30,9765678767);
            userList.Add(user1);
            userList.Add(user2);


            
            //Movie detail
            MovieDetails movie1=new MovieDetails("Bagubali2","Telgu");
            MovieDetails movie2=new MovieDetails("Ponniyin selvan","Tamil");
            MovieDetails movie3=new MovieDetails("Cobra","Tamil");
            MovieDetails movie4=new MovieDetails("Vikram","Tamil");
            MovieDetails movie5=new MovieDetails("Vikram","Hindi(Dubbed)");
            MovieDetails movie6=new MovieDetails("Beast","English");

            movieList.Add(movie1);
            movieList.Add(movie2);
            movieList.Add(movie3);
            movieList.Add(movie4);
            movieList.Add(movie5);
            movieList.Add(movie6);

            //Theater detail
            TheatreDetails theatre1=new TheatreDetails("Inox","Anna Nagar");
            TheatreDetails theatre2=new TheatreDetails("Ega","Chetpet");
            TheatreDetails theatre3=new TheatreDetails("Kamala","Vadapalani");

            theatreList.Add(theatre1);
            theatreList.Add(theatre2);
            theatreList.Add(theatre3);
            

            //Booking details
            BookingDetail booking1=new BookingDetail("UID1001","MID501","TID301", 1, 200,BookingStatus.Booked);
            BookingDetail booking2=new BookingDetail("UID1001","MID504","TID302",1,400,BookingStatus.Booked);
            BookingDetail booking3=new BookingDetail("UID1002","MID505","TID302",1,300,BookingStatus.Booked);

            bookingList.Add(booking1);
            bookingList.Add(booking2);
            bookingList.Add(booking3);

            //Screening Details
            ScreeningDetail screen1=new ScreeningDetail("MID501","TID301",200,5);
            ScreeningDetail screen2=new ScreeningDetail("MID502","TID301",300,2);
            ScreeningDetail screen3=new ScreeningDetail("MID503","TID301",200,5);
            ScreeningDetail screen4=new ScreeningDetail("MID506","TID303",50,11);
            ScreeningDetail screen5=new ScreeningDetail("MID501","TID302",400,11);
            ScreeningDetail screen6=new ScreeningDetail("MID502","TID302",300,2);
            ScreeningDetail screen7=new ScreeningDetail("MID504","TID302",500,2);
            ScreeningDetail screen8=new ScreeningDetail("MID505","TID303",100,11);
            ScreeningDetail screen9=new ScreeningDetail("MID504","TID303",350,2);

            screenList.Add(screen1);
            screenList.Add(screen2);
            screenList.Add(screen3);
            screenList.Add(screen4);
            screenList.Add(screen5);
            screenList.Add(screen6);
            screenList.Add(screen7);
            screenList.Add(screen8);
            screenList.Add(screen9);

            
        }


        public static void MainMenu()
        {
            //AddDefalut();
            string choice="yes";
            do{
                System.Console.WriteLine("--------Main Menu -------\n");
                System.Console.WriteLine("Enter the Option: \n1.User Registration \n2.Login \n3.Exit");
                int option=int.Parse(Console.ReadLine());
                
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("\n-----User Registration------\n");

                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("\n-------Login-------\n");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("\n-------Exit Main menu------\n");
                        choice="no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Enter the correct Option.");
                        break;
                    }
                }

            }while(choice=="yes");
        }


        public static void Registration()
        {
            System.Console.WriteLine("Enter your name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Age:");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Mobile Number:");
            long mobileNumber=long.Parse(Console.ReadLine());
            
       

            UserDetail person=new UserDetail(name,age,mobileNumber);
            userList.Add(person);
            System.Console.WriteLine("Your Id: "+person.UserId);
        }


        public static void Login()
        {
            System.Console.WriteLine("Enter your User ID:");
            string userId=Console.ReadLine().ToUpper();
            foreach(UserDetail user in userList)
            {
                if(userId==user.UserId)
                {
                    System.Console.WriteLine("\n-----Login successfully");
                    currentUser=user;
                    SubMenu();
                


                }
            }
            
        }
        public static void SubMenu()
        {
            string choice="yes";
            do{
                System.Console.WriteLine("Enter the option: \n1.Ticket Booking \n2.Ticket Cancellation \n3.Booking Histroy \n4.Wallet Recharge \n5.Exit");
                int option=int.Parse(Console.ReadLine().ToLower());

                switch (option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("\n----Ticket Booking------\n");
                        TicketBooking();
                        break;

                    }
                    case 2:
                    {
                        System.Console.WriteLine("\n------Ticket cancellation-----\n");
                        TicketCancel();
                        
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("\n------Booking Histroy------\n");
                        BookingHistroy();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("\n------Wallet Recharge--------\n");
                        currentUser.RechargeWallet();
                        
                        
                        break;

                    }
                    case 5:
                    {
                        System.Console.WriteLine("\n-----Exit Sub Menu--------\n");
                        choice="no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Enter the correct option.");
                        break;
                    }


                }
            }while(choice=="yes");

        }
        public static void TicketBooking()
        {
            string choice="yes";
            
            foreach (TheatreDetails theatre in theatreList)
            {
                System.Console.WriteLine($"Theatre ID: {theatre.TheatreId}\t Theatre name: {theatre.TheatreName}\t Theatre Location:{theatre.TheatreLocation}");

            }
            do{
            double totalAmount=0;
            System.Console.WriteLine("Enter the Theartre Id :");
            string theatreId=Console.ReadLine().ToUpper();
            
            foreach (TheatreDetails theatre in theatreList)
            {
                if (theatre.TheatreId==theatreId)
                {
                    int flag1=0;
                    int flag2=0;
                    int flag3=0;
                        foreach(ScreeningDetail screen1 in screenList)
                        {
                            if(theatreId==screen1.TheatreId){
                                System.Console.WriteLine("Movie Id:"+screen1.MovieId);

                            }
                           
                        }
                    System.Console.WriteLine("\nEnter the Movie Id to book:");
                    string movieId=Console.ReadLine().ToUpper();
                    System.Console.WriteLine("How many seats do you want?");
                    int seats=int.Parse(Console.ReadLine());
                    foreach(ScreeningDetail screen in screenList)
                    {


                        
                        if(theatreId==screen.TheatreId)
                        {
                            flag1=1;
                          if (movieId==screen.MovieId)
                            {
                                flag2=1;

                                
                                if((seats<=screen.NoOfSeatsAvailable)&&(seats>0))
                                {
                                    flag3=1;
                                    double average=(seats*screen.TicketPrice)*0.18;
                                    totalAmount=(seats*screen.TicketPrice)+average;
                                    System.Console.WriteLine("Total amount of Ticket:"+totalAmount);
                                    if(totalAmount>currentUser.WalletBalance)
                                    {
                                        currentUser.RechargeWallet();
                                    }
                                    else{
                                        BookingDetail tempObjectBooking=new BookingDetail(currentUser.UserId,screen.MovieId,screen.TheatreId,seats,totalAmount,BookingStatus.Booked);
                                        bookingList.Add(tempObjectBooking);

                                        currentUser.WalletBalance-=totalAmount;
                                        screen.NoOfSeatsAvailable-=seats;
                                        System.Console.WriteLine("Ticket booked successfully");
                                        System.Console.WriteLine();
                                        foreach (BookingDetail booking in bookingList)
                                        {
                                            if(currentUser.UserId==booking.UserId)
                                            {
                                                System.Console.WriteLine("Your booking id:"+booking.BookingID);
                                            }
                                        }
                                    }
                                   
                                }
                            }
                            
                        }
                    }
                    if(flag1==0)
                    {
                        System.Console.WriteLine("Enter the correct theatre Id.");
                    }
                    if(flag2==0)
                    {
                        System.Console.WriteLine("Enter the correct Movie Id.");
                    }
                    if (flag3==0)
                    {
                        System.Console.WriteLine("There is no enough seats.");
                    }


                }
            }
            
            System.Console.WriteLine("Do you want to continue? 'yes' or 'no'");
            choice=Console.ReadLine().ToUpper();

            

            }while (choice=="yes");
            

        }


        public static void BookingHistroy()
        {
            int flag=0;
                
         foreach(BookingDetail booking1 in bookingList)
         {
                if(currentUser.UserId==booking1.UserId)
                {
                    flag=1;
                     System.Console.WriteLine($"User Id{currentUser.UserId} and Booking Status{booking1.BookingStatus1}");
                }
         }
         if(flag==0)
         {
            System.Console.WriteLine("you are not booking and cancelling any tikets");

         }
                

        }

        public static void TicketCancel()
        {
            int temp=0;
            foreach(BookingDetail booking1 in bookingList)
            {
                if(currentUser.UserId==booking1.UserId)
                {
                    
                     System.Console.WriteLine($"User Id{currentUser.UserId} and Booking Status{booking1.BookingStatus1}");
                }
            }
            System.Console.WriteLine("Enter the Booking id:");
            string bookingId=Console.ReadLine().ToUpper();
            foreach(BookingDetail booking in bookingList)
            {
                if(bookingId==booking.BookingID){
                if (booking.BookingStatus1==BookingStatus.Booked)
                {
                    currentUser.WalletBalance+=(booking.TotalPrice-20);
                    foreach(ScreeningDetail screen in screenList)
                    {
                        if(screen.MovieId==booking.MovieId)
                        {
                            screen.NoOfSeatsAvailable+=booking.SeatCount;
                            temp=1;

                        }
                    }
                    
                    
                }
                }
            }
            if(temp==1)
            {
                System.Console.WriteLine("Ticket cancel successfully");
            }

            
            


            


        }

        
    }
