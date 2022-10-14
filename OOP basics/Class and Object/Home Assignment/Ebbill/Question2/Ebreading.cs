using System;
namespace Question2
{
    public class Ebreading
    {
        private static int s_meterId=1000;
        //public static int s_meterId=1000; Its only access by class 

        public string MeterId { get;}
        public string UserName { get; set; }//

        public long PhoneNumber { get; set; }

        

        public string MailId{ get; set; }

        

        public int Unit { get; set; }

        public Ebreading(string username,long phonenumber,string mailid)
        {
            s_meterId++;
            MeterId="EB"+s_meterId;
            UserName=username;
            PhoneNumber=phonenumber;
            MailId=mailid;
        }
        public void Ebread()
        {
            System.Console.WriteLine("Enter used unit:");
            int units=int.Parse(Console.ReadLine());
            if (units<=100)
            {
                System.Console.WriteLine("current bill is free");
            }
            else if ((units>100)&&(units<=200))
            {
                units=units*3;
                System.Console.WriteLine("current bill:"+units);
            }
            else if ((units>200)&&(units<=400))
            {
                units=units*5;
                System.Console.WriteLine("Current bill:"+units);
            }
            else if ((units>=400))
            {
                units=units*6;
                System.Console.WriteLine("Current bill:"+units);
            }
        }
        public void ShowDetail()
        {
             System.Console.WriteLine("----Eb details----");
            System.Console.WriteLine("Meter ID:"+MeterId);
            System.Console.WriteLine("User Name:"+UserName);
            System.Console.WriteLine("Phone Number:"+PhoneNumber);
            System.Console.WriteLine("Mail id"+MailId);
            System.Console.WriteLine("Units used:"+Unit);
        }
        
    }
}