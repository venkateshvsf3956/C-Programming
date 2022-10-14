using System;
namespace BankLibrary
{
    public enum Gender{Default,Male,Female,Transgender}
    public enum AccounType{Default,SD,FD,RD}
    public class AccountHolder
    {
        private static int s_accountnumber=5000;

        public string AccountNumber { get;}
        
        
        public string Name { get; set; }

        public string FatherName { get; set; }

        public Gender Gender { get; set; }

        public DateTime DOB { get; set; }

        public AccounType AccountType { get; set; }

        public double Balance { get; set; }

        // parametrized constructor
        public AccountHolder(string name,string fathername,Gender gender,DateTime dob,AccounType accounttype)
        {
            s_accountnumber++;
            AccountNumber="HDFC"+s_accountnumber;
            Name=name;
            FatherName=fathername;
            Gender=gender;
            DOB=dob;
            AccountType=accounttype;
        }
        //method
        public void Deposit()
        {
            
            System.Console.WriteLine("Enter the amount to deposit:");
            double depositamount=double.Parse(Console.ReadLine());
            Balance+=depositamount;
            System.Console.WriteLine("Deposited amount:"+Balance);
        }
        public void Withdraw()
        {
            System.Console.WriteLine("Enter the amount to withdraw:");
            double withdrawAmount=double.Parse(Console.ReadLine());
            Balance-=withdrawAmount;
            System.Console.WriteLine("Withdraw Amount:"+Balance);
        }
        public void Show()
        {
            System.Console.WriteLine("Balance:"+Balance);
        }
            

        

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}