namespace Vaccination
{
    public enum Gender{Default,Male,Female,Transgender}
    public class Beneficiary
    {
        private static int s_registerNumber=1000;
        public string RegisterNumber { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }
        public string  City { get; set; }

        public Beneficiary(int age,Gender gender,long phone,string city)
        {
            s_registerNumber++;
            RegisterNumber="BID"+s_registerNumber;
            Age=age;
            Gender=gender;
            Phone=phone;
            City=city;

        }
    }
}