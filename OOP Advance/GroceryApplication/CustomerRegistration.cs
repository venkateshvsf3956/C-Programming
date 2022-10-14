using System;
namespace Assessment
{
    public class CustomerRegistration:PersonalDetail,IBalance
    {
        public static int s_customerId=1000;
       public string CustomerId{get;set;}
        public double  WalletBalance{ get; set; }
        public CustomerRegistration(string name,string fatherName,Gender gender,long mobileNumber,DateTime dateOfBirth,string mailId):base(name,fatherName,gender,mobileNumber,dateOfBirth,mailId)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;


        }
        public CustomerRegistration(string data)
        {
            string []value=data.Split(',');
            s_customerId=int.Parse(value[0].Remove(0,3));
            CustomerId=value[0];
            Name=value[1];
            FatherName=value[2];
            Gender=Enum.Parse<Gender>(value[3]);
            MobileNumber=int.Parse(value[4]);
            DateOfBirth=DateTime.Parse(value[5]);
            MailId=value[6];
            WalletBalance=double.Parse(value[7]);


        }
        

        public void ShowCustomerDetail()
        {
            System.Console.WriteLine("Customer ID: "+CustomerId);
            System.Console.WriteLine("Name :"+Name);
            System.Console.WriteLine("FatherName : "+FatherName);
            System.Console.WriteLine("Gender : "+Gender);
            System.Console.WriteLine($"Mobile Number: {MobileNumber} \nDate of Birth : {DateOfBirth} \nMail Id : {MailId} \nWallet Balance: {WalletBalance}");
        }
        public void WalletRecharge()
        {
            System.Console.WriteLine("\n----Wallet ------\n");
            System.Console.WriteLine("Enter amount to recharge:");
            double amount=int.Parse(Console.ReadLine());
            WalletBalance+=amount;
            System.Console.WriteLine("Wallet Balance:"+WalletBalance);
        
            
        }
        
    }

}