namespace OnlineApplication
{
    public class Details
    {
        private static int s_userId=1000;
        public string Userid { get; set; }
        public string  Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public long Phone { get; set; }
        public double Balance { get; set; }
        public Details(string name,int age,string city,long phone,double balance)
        {
            s_userId++;
            Userid="UID"+s_userId;
            Name=name;
            Age=age;
            City=city;
            Phone=phone;
            Balance=balance;


        }
        public Details(string data)
        {
                string []values=data.Split(',');
                s_userId=int.Parse(values[0].Remove(0,3));
                Userid=values[0];
                Name=values[1];
                Age=int.Parse(values[2]);
                City=values[3];
                Phone=long.Parse(values[4]);
                Balance=double.Parse(values[5]);

        }
        

    }
}