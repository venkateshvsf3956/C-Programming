namespace Library
{
    public enum Status{Default,Returned,Issue}
    public class BorrowDetails
    {
        private static int s_borrowID=300;
        public string  BorrowId { get; set; }
        public DateTime DateTime { get; set; }
        public  Status Status{ get; set; }

        public BorrowDetails(DateTime dateTime,Status status)
        {
            s_borrowID++;
            BorrowId="LB"+s_borrowID;
            DateTime=dateTime;
            Status=status;

        }
    }
}