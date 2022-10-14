namespace Question2
{
        
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalInfo
    {
        
    
        
   
            //field
        
        //property
        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }
        //Constructor
        //primary key
        public  PersonalInfo(string name,string fatherName,Gender gender,long phone)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;

        }
        //foreign key
        public  PersonalInfo(string aid,string name,string fatherName,Gender gender,long phone)
        {
            
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;

        }
        public void ShowDetail()
        {
            System.Console.WriteLine($"\nName:{Name} \nFather Name:{FatherName} \nGender:{Gender} \nPhone Number:{Phone}");
        }
    }
}