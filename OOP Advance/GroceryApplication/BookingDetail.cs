using System;
namespace Assessment
{
    public enum BookingStatus{Default,Booked,Cancelled,Initiated}
    public class BookingDetail
    {
        public static int s_bookingId=3000;
        public string BookingId { get;  }
        public string CustomerId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public BookingDetail(string customerId,double totalPrice,DateTime dateOfbooking,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            CustomerId=customerId;
            
            TotalPrice=totalPrice;
            DateOfBooking=dateOfbooking;
            BookingStatus=bookingStatus;
        }
        public BookingDetail(string data)
        {
            string []value=data.Split(",");
            s_bookingId=int.Parse(value[0].Remove(0,3));
            BookingId=value[0];
            CustomerId=value[1];
            TotalPrice=double.Parse(value[2]);
            DateOfBooking=DateTime.Parse(value[3]);
            BookingStatus=Enum.Parse<BookingStatus>(value[4]);

        }

        
    }
}