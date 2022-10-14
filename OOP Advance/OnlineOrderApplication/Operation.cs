using System;


namespace OnlineApplication
{
    public class Operation
    {
        public static Details currentPerson=null;
        public static List<Details> userList=new List<Details>();
        public static List<Medicine> medicineList=new List<Medicine>();
       public static List<OrderDetail> orderList=new List<OrderDetail>();

        public void AddDefault()
        {
            //details
            Details person1=new Details("Ravi",33,"Theni",9877774440,400);
            userList.Add(person1);
            Details person2=new Details("Baskaran",33,"Chennai",8847757470,500);
            userList.Add(person2);
            //medicine details
            Medicine medicine1=new Medicine("Paracetomal",40,5,new DateTime(2022,06,30));
            medicineList.Add(medicine1);
            Medicine medicine2=new Medicine("Calpol",10,5,new DateTime(2022,05,30));
            medicineList.Add(medicine2);
            Medicine medicine3=new Medicine("Gelucil",3,40,new DateTime(2022,04,30));
            medicineList.Add(medicine3);
            Medicine medicine4=new Medicine("Metrogel",5,50,new DateTime(2022,10,30));
            medicineList.Add(medicine4);
            Medicine medicine5=new Medicine("Povidin Iodine",10,50,new DateTime(2022,10,30));
            medicineList.Add(medicine5);
            //order detail




        }
        public static void Mainmenu()
        {
            string choice="yes";
            do{
            System.Console.WriteLine("Enter the option:\n1.User Registration \n2.User Login \n3.Order Histroy\n4.Exit");
            int option=int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                {
                    System.Console.WriteLine("\n-----Register number------\n");
                    Registration();

                    break;

                }
                case 2:
                {
                    System.Console.WriteLine("Login.");
                    Login();

                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Order History");

                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Exit");
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
        public static void Registration()
        {
            System.Console.WriteLine("Enter your name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your age:");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your city:");
            string city=Console.ReadLine();
            System.Console.WriteLine("Enter your Phone number:");
            long phone=Convert.ToInt64(Console.ReadLine());
            double balance=0;

            Details person=new Details(name,age,city,phone,balance);
            userList.Add(person);
            System.Console.WriteLine("User Id: "+person.Userid);

        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your User Id:");
            string userId=Console.ReadLine().ToUpper();

            foreach(Details person in userList)
            {
                if(person.Userid==userId)
                {
                    currentPerson=person;
                    System.Console.WriteLine("Login successfully.");
                    SubMenu();

                }

            }
            
        }
        public static void SubMenu()
        {
            string choice="yes";
            do{
            System.Console.WriteLine("Enter option:\n1.Show medicine list\n2.Purchase medicine \n3.Cancel purchase\n4.Show purchase histroy \n5.Recharge\n6.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                     System.Console.WriteLine("Show medicine list.");
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Purchase medicine.");
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Cancel purchase.");
                    break;

                }
                case 4:
                {
                    System.Console.WriteLine("Show purchase histroy.");
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("Recharge.");
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("Exit");
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
        
    }
}