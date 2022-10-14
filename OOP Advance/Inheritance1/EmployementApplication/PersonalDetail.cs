using System;
namespace EmployementApplication
{
    public enum Gender{Default,Male,Female,Transgender}
    public class PersonalDetail
    {
        
   
            //field
        private static int s_adhaarNumber=1000;
        //property
        public string AdhaarNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }
        //Constructor
        public  PersonalDetail(string name,string fatherName,Gender gender,long phone)
        {
            s_adhaarNumber++;
            AdhaarNumber="AID"+s_adhaarNumber;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;

        }
        public void ShowDetail()
        {
            System.Console.WriteLine($"Adhaar ID:{AdhaarNumber} \nName:{Name} \nFather Name:{FatherName} \nGender:{Gender} \nPhone Number:{Phone}");
        }
        

        
            
    }
}