namespace Assessment1
{
    public class TheatreDetails
    {
        /// <summary>
        /// Field ---used to store the theatre id
        /// </summary>
        private static int s_theatreId=300;
        /// <summary>
        /// Property ---used to store the theatre id
        /// </summary>
        /// <value></value>
        public string  TheatreId { get; set; }
        /// <summary>
        /// property --used to given the name to the theatre
        /// </summary>
        /// <value></value>
         public string TheatreName{ get; set; }
         /// <summary>
         /// property--used to given the location of the theatre
         /// </summary>
         /// <value></value>
         public string TheatreLocation { get; set; }
         /// <summary>
         /// Constructor
         /// </summary>
         /// <param name="theatreName"></param>---used to store the name of the theatre
         /// <param name="theatreLocation"></param>--used to store the location of the theatre
         public TheatreDetails(string theatreName,string theatreLocation)
         {
            s_theatreId++;
            TheatreId="TID"+s_theatreId;
            TheatreName=theatreName;
            TheatreLocation=theatreLocation;
         }
         public TheatreDetails(string data)
         {
            string [] value=data.Split(',');
            s_theatreId=int.Parse(value[0].Remove(0,3));
            TheatreId=value[0];
            TheatreName=value[1];
            TheatreLocation=value[2];

         }
    }
}