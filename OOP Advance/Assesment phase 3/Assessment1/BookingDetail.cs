using System;
namespace Assessment1
{
    public enum  BookingStatus{Booked,Cancelled}
    public class BookingDetail
    {
        private static int s_bookingId=7000;
        public string BookingID { get; set; }
        
        public string UserId{ get; set; }
        public string MovieId { get; set; }
        public string TheatreId { get; set; }
        public int SeatCount{get;set;}
        public double TotalPrice{get;set;}
        public BookingStatus BookingStatus1 { get; set; }
        public BookingDetail(string userId,string movieId,string theatreId,int seatCount,double totalPrice,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingID="BID"+s_bookingId;
            UserId=userId;
            MovieId=movieId;
            TheatreId=theatreId;
            SeatCount=seatCount;
            TotalPrice=totalPrice;
            BookingStatus1=bookingStatus;
        }

        public BookingDetail(string data)
        {
            string[] value=data.Split(',');
            s_bookingId=int.Parse(value[0].Remove(0,3));
            BookingID=value[0];
            UserId=value[1];
            MovieId=value[2];
            TheatreId=value[3];
            SeatCount=int.Parse(value[4]);
            TotalPrice=double.Parse(value[5]);
            BookingStatus1=Enum.Parse<BookingStatus>(value[6]);
        }


    }
}