namespace Library
{
    public enum Gender {Default,Male,Female,Transgender}
    public enum Department{Default,ECE,EEE,CSE}
    public class Registration
    {
        private static int s_registrationId=3000;
        public string  RegistrationId { get; set; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        public DateTime Datetime { get; set; }
        public Department Department { get; set; }
        public long Phone { get; set; }
        public string MailId { get; set; }

        public Registration(string username,Gender gender,DateTime dateTime,Department department,long phone,string mailId)
        {
            s_registrationId++;
            RegistrationId="SF"+s_registrationId;
            UserName=username;
            Gender=gender;
            Datetime=dateTime;
            Department=department;
            Phone=phone;
            MailId=mailId;
        }

        
    }
}