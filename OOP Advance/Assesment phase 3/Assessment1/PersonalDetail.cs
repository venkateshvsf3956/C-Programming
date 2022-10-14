namespace Assessment1
{
    public class PersonalDetail
    {
        /// <summary>
        /// Property ---used to name the user
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Property--used to save age of the user
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
        /// <summary>
        /// Property ---used to save user mobile number
        /// </summary>
        /// <value></value>
        public long MobileNumber { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>used to name of the user
        /// <param name="age"></param>used to age to the user 
        /// <param name="mobileNumber"></param>used to mobile number to the user

        public PersonalDetail(string name,int age,long mobileNumber)
        {
            Name=name;
            Age=age;
            MobileNumber=mobileNumber;
        }
        public PersonalDetail(string data,string name,int age,long mobileNumber)
        {
            Name=name;
            Age=age;
            MobileNumber=mobileNumber;
        }
        public PersonalDetail()
        {
            
        }

    }
}