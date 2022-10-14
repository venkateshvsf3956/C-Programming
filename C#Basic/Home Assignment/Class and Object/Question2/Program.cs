using System;
using System.Collections.Generic;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        List<Ebreading> EbDetails=new List<Ebreading>();

        string create="";
        do{
            System.Console.WriteLine("Enter username:");
            string username=Console.ReadLine();
            System.Console.WriteLine("Enter Phone number:");
            int phonenumber=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter mail id:");
            string mailid=Console.ReadLine();
            Ebreading  person=new Ebreading(username,phonenumber,mailid);
            EbDetails.Add(person);
    

            System.Console.WriteLine("Are you want to create another account:'yes' or 'no'");
            create=Console.ReadLine().ToLower();
        }while (create=="yes");

        foreach(Ebreading detail in EbDetails)
        {
            System.Console.WriteLine("----Eb details----");
            System.Console.WriteLine("Meter ID:"+detail.MeterId);
            System.Console.WriteLine("User Name:"+detail.UserName);
            System.Console.WriteLine("Phone Number:"+detail.PhoneNumber);
            System.Console.WriteLine("Mail id"+detail.MailId);
            System.Console.WriteLine("Units used:"+detail.Unit);
            detail.Ebread();
        }
    }
   // Properties - Meter ID -(EB1001), Username, Phone number, Mail id, Units Used =0
	//Methods - CalculateAmount = 100 units - free , 100 to 200 - 3 Rs,  200 to 400 - 5 Rs, 400 above - 6 Rs.
}