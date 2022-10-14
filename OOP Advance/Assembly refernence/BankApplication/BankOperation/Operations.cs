using System;
using BankLibrary;
using System.Collections.Generic;
namespace BankOperation;
class Operations
{
    public static void MainMenu()
    {
        List<AccountHolder> AccountDetails=new List<AccountHolder>();
        string create="";
        do{
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
            
            

            System.Console.WriteLine("Are you want to create another account:'yes' or 'no'");
            create=Console.ReadLine().ToLower();
            

        }while (create=="yes");

        foreach(AccountHolder detail in AccountDetails)
        {
            
            System.Console.WriteLine("\nAccount Holder details\n");
            System.Console.WriteLine($"Account Number: {detail.AccountNumber}");

            System.Console.WriteLine($"Account Holder name:{detail.Name}");
            System.Console.WriteLine($"Account Holder Father name: {detail.FatherName}");
            System.Console.WriteLine($"Gender: {detail.Gender}");
            System.Console.WriteLine($"Date of Birth: {detail.DOB}");
            System.Console.WriteLine($"Account Type: {detail.AccountType}");
            System.Console.WriteLine($"Balance: {detail.Balance}");
            
            detail.Deposit();
            detail.Withdraw();
            detail.Show();
            System.Console.WriteLine("\n--------\n");

        }
    }
}