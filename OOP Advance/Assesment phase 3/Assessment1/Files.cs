using System;
using System.IO;

namespace Assessment1
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("TheatreTickets"))
            {
                Directory.CreateDirectory("TheatreTickets");
            }
            if (!File.Exists("TheatreTickets/UserDetail.csv"))
            {
                File.Create("TheatreTickets/UserDetail.csv");
            }
            if(!File.Exists("TheatreTickets/MovieDetail.csv"))
            {
                File.Create("TheatreTickets/MovieDetail.csv");
            }
            if(!File.Exists("TheatreTickets/TheatreDetail.csv"))
            {
                File.Create("TheatreTickets/TheatreDetail.csv");
            }
            if(!File.Exists("TheatreTickets/BookingDetail.csv"))
            {
                File.Create("TheatreTickets/BookingDetail.csv");

            }
            if(!File.Exists("TheatreTickets/ScreeningDetail.csv"))
            {
                File.Create("TheatreTickets/ScreeningDetail.csv");
            }

        }
        public static void ReadFile()
        {
            string []userDetail=File.ReadAllLines("TheatreTickets/UserDetail.csv");
            foreach(string data in userDetail)
            {
                UserDetail userDetail1=new UserDetail(data);
                Operation.userList.Add(userDetail1);

            }
            string []movieDetail=File.ReadAllLines("TheatreTickets/MovieDetail.csv");
            foreach(string data in movieDetail)
            {
                MovieDetails movieDetails=new MovieDetails(data);
                Operation.movieList.Add(movieDetails);
            }
            string []theatreDetail=File.ReadAllLines("TheatreTickets/TheatreDetail.csv");
            foreach(string data in theatreDetail)
            {
                TheatreDetails theatreDetail1=new TheatreDetails(data);
                Operation.theatreList.Add(theatreDetail1);
            }
            string []bookingDetail=File.ReadAllLines("TheatreTickets/BookingDetail.csv");
            foreach(string data in bookingDetail)
            {
                BookingDetail bookingDetail1=new BookingDetail(data);
                Operation.bookingList.Add(bookingDetail1);
            }
            string [] screeningDetail=File.ReadAllLines("TheatreTickets/ScreeningDetail.csv");
            foreach(string data in screeningDetail)
            {
                ScreeningDetail screeningDetail1=new ScreeningDetail(data);
                Operation.screenList.Add(screeningDetail1);
            }
        }
        public static void WriteToFiles()
        {
            string []userDetail=new string[Operation.userList.Count];
            for(int i=0;i<Operation.userList.Count;i++)
            {
                userDetail[i]=Operation.userList[i].UserId+','+Operation.userList[i].Name+','+Operation.userList[i].Age+','+Operation.userList[i].MobileNumber+','+Operation.userList[i].WalletBalance;

            }
            File.WriteAllLines("TheatreTickets/UserDetail.csv",userDetail);

            string []movieDetail=new string[Operation.movieList.Count];
            for (int i=0;i<Operation.movieList.Count;i++)
            {
                movieDetail[i]=Operation.movieList[i].MovieId+','+Operation.movieList[i].MovieName+','+Operation.movieList[i].Language;

            }
            File.WriteAllLines("TheatreTickets/MovieDetail.csv",movieDetail);
            

            string[]theatreDetail=new string[Operation.theatreList.Count];
            for(int i=0;i<Operation.theatreList.Count;i++)
            {
                theatreDetail[i]=Operation.theatreList[i].TheatreId+','+Operation.theatreList[i].TheatreName+','+Operation.theatreList[i].TheatreLocation;

            }
            File.WriteAllLines("TheatreTickets/TheatreDetail.csv",theatreDetail);

            string []bookingDetail=new string[Operation.bookingList.Count];
            for(int i=0;i<Operation.bookingList.Count;i++)
            {
                bookingDetail[i]=Operation.bookingList[i].BookingID+','+Operation.bookingList[i].UserId+','+Operation.bookingList[i].MovieId+','+Operation.bookingList[i].TheatreId+','+Operation.bookingList[i].SeatCount+Operation.bookingList[i].TotalPrice+Operation.bookingList[i].BookingStatus1;
            }
            File.WriteAllLines("TheatreTickets/ScreeningDetail.csv",bookingDetail);

            string []screeningDetail=new string[Operation.screenList.Count];
            for (int i=0;i<Operation.screenList.Count;i++)
            {
                screeningDetail[i]=Operation.screenList[i].MovieId+','+Operation.screenList[i].TheatreId+','+Operation.screenList[i].TicketPrice+','+Operation.screenList[i].NoOfSeatsAvailable;
            }
            File.WriteAllLines("TheatreTickets/ScreeningDetail.csv",screeningDetail);
        }
    }
}