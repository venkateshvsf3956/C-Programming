namespace Assessment1
{
    public class ScreeningDetail
    {
        /// <summary>
        /// Property -- used to store the movie Id
        /// </summary>
        /// <value></value>
           public string MovieId { get; set; }
           /// <summary>
           /// Property ---used to store the theatre id
           /// </summary>
           /// <value></value>
           public string TheatreId { get; set; }
           /// <summary>
           /// Property--- used to save the seat availability
           /// </summary>
           /// <value></value>
           public int NoOfSeatsAvailable { get; set; }
           /// <summary>
           /// property --used to store the price of the ticket
           /// </summary>
           /// <value></value>
           public double TicketPrice {get;set;}

           /// <summary>
           /// Constructor
           /// </summary>
           /// <param name="movieId"></param>movie id
           /// <param name="theatreId"></param>theatre id
           /// <param name="ticketPrice"></param>ticket price
           /// <param name="noOfSeatsAvailable"></param> seat availability
           public ScreeningDetail(string movieId,string theatreId,double ticketPrice,int noOfSeatsAvailable)

           {
            MovieId=movieId;
            TheatreId=theatreId;

            TicketPrice=ticketPrice;
            NoOfSeatsAvailable=noOfSeatsAvailable;
            
           }
           public ScreeningDetail(string data)
           {
            string []value=data.Split(',');
            MovieId=value[0];
            TheatreId=value[1];
            NoOfSeatsAvailable=int.Parse(value[3]);
            TicketPrice=double.Parse(value[2]);
           }
    }
}