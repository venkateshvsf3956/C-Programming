namespace Assessment1
{
    public class MovieDetails
    {
        /// <summary>
        /// field ---store the movie id number
        /// </summary>
        private static int s_movieId=1000;

        /// <summary>
        /// property -- used to the store the movie id
        /// </summary>
        /// <value></value>
        public string MovieId { get; set; }
        /// <summary>
        /// property --- used to store the movie name
        /// </summary>
        /// <value></value>
        public string MovieName { get; set; }
        /// <summary>
        /// property ---used to store the language of the movie        /// </summary>
        /// <value></value>
        public string Language { get; set; }
        public MovieDetails(string movieName,string language)
        {
            s_movieId++;
            MovieId="MID"+s_movieId;
            MovieName=movieName;
            Language=language;

        }
        public MovieDetails(string data)
        {
            string []value=data.Split(',');
            s_movieId=int.Parse( value[0].Remove(0,3));
            MovieId=value[0];
            MovieName=value[1];
            Language=value[2];
        }
    }
}