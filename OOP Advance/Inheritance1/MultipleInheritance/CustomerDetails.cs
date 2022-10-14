using System;
namespace MultipleInheritance
{
    public class CustomerDetails:PersonalDetail
    {
        private static int s_customerId=100;
        public String CustomerId { get; set; }
        public double Balance { get; set; }
        public CustomerDetails(string aid,string name,string fatherName,Gender gender,long phone):base(aid,name,fatherName,gender,phone)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
        }
        public void Recharge()
        {
            System.Console.WriteLine("Enter the amount to recharge:");
            Balance+=double.Parse(Console.ReadLine());
        }
        public void ShowCustomer()
        {
            System.Console.WriteLine("\n\n------Customer Detail--------\n\n");
            System.Console.WriteLine("Customer Id:"+CustomerId);
            Show();
            System.Console.WriteLine("Balance:"+Balance);
        }
        
    }
}