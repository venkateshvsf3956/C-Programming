using System;
using System.Collections.Generic;
namespace Question2
{

        public static class Operations
    {
        static Ebreading currentEb=null;
        static List<Ebreading> ebdetails=new List<Ebreading>();
        public static void MainMenu()
        {
            string choice="yes";
            do{
            System.Console.WriteLine("Select option \n1.Registration \n2.Login \n3.Exit");
            int option=int.Parse(Console.ReadLine());
            

            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration\n");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login\n");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit\n");
                    choice="no";
                    break;
                }
            }
            }while(choice=="yes");
        }
        public static void Registration()
        {
            System.Console.WriteLine("Enter username:");
            string username=Console.ReadLine();
            System.Console.WriteLine("Enter Phone number:");
            int phonenumber=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter mail id:");
            string mailid=Console.ReadLine();
            Ebreading  person=new Ebreading(username,phonenumber,mailid);
            ebdetails.Add(person);

            System.Console.WriteLine("Ebnumber:"+person.MeterId);
        }
                public static void Login()
        {
            System.Console.WriteLine("Enter your Meter id Number");
            string registerNumber=Console.ReadLine().ToUpper();

            foreach (Ebreading meter in ebdetails)
            {
                if (meter.MeterId==registerNumber)
                {
                    System.Console.WriteLine("login successful\n");
                    currentEb=meter;
                    SuBMenu();
                    
                }
            }
        }
        public static void SuBMenu()
        {
            
            string choice="yes";
            do{
                System.Console.WriteLine("Enter the option: \n1.Show Detail \n2.Bill \n3.Exit");
            int show=int.Parse(Console.ReadLine());
            switch (show)
            {
                case 1:
                {
                    System.Console.WriteLine("Details:");
                    currentEb.ShowDetail();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Bill:");
                    currentEb.Ebread();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            }while(choice=="yes");
        }

}
}
