using System;
using System.Collections.Generic;

namespace ECommerce
{
    public class CustomerDetails
    {
        private static int s_customer=1000;
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public long Phone { get; set; }
        public double WalletBalance{ get; set; }
        public string Mail{ get; set; }
        //constructor
        public CustomerDetails(string customerName,string city,long phone,double walletBalance,string mail)
        {
            s_customer++;
            CustomerId="CID"+s_customer;
            CustomerName=customerName;
            City=city;
            Phone=phone;
            WalletBalance=walletBalance;
            Mail=mail;
        }
        
    }
}