using System;
using System.Collections.Generic;
namespace AccountDetail;


    public static class Operations
    {
        static AccountHolder currentAccount=null;
        static List<AccountHolder> AccountDetails=new List<AccountHolder>();
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
            System.Console.WriteLine("Enter your Name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your father name:");
            string fathername=Console.ReadLine();
            System.Console.WriteLine("Gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Date of birth(dd/MM/yyyy):");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your Account type:");
            AccounType accounttype=Enum.Parse<AccounType>(Console.ReadLine(),true);

            AccountHolder person=new AccountHolder(name,fathername,gender,dob,accounttype);
            AccountDetails.Add(person);
            System.Console.WriteLine(person.AccountNumber);

        }
 
        public static void Login()
        {
            System.Console.WriteLine("Enter your Register Number");
            string registerNumber=Console.ReadLine().ToUpper();

            foreach (AccountHolder user in AccountDetails)
            {
                if (user.AccountNumber==registerNumber)
                {
                    System.Console.WriteLine("login successful\n");
                    currentAccount=user;
                    SuBMenu();
                    
                }
            }
        }
        public static void SuBMenu()
        {
            
            string choice="yes";
            do{
                System.Console.WriteLine("Enter the option: \n1.Show Detail \n2.Deposit \n3.Withdraw \n4.Balance \n5.Exit");
            int show=int.Parse(Console.ReadLine());
            switch (show)
            {
                case 1:
                {
                    System.Console.WriteLine("Details:");
                    currentAccount.ShowDetail();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Deposited Amount");
                    currentAccount.Deposit();
                    break;
                    
                }
                case 3:
                {
                    System.Console.WriteLine("Withdraw Amount");
                    currentAccount.Withdraw();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Balance");
                    currentAccount.Show();
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            }while(choice=="yes");
        }

   }
