using System;
namespace ListFileManipulation
{
    public enum Gender{Default,Male,Female,Transgender}
    public class StudentDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime Dob { get; set; }
     /*   public StudentDetails(string name,string fatherName,Gender gender,DateTime dob)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Dob=dob;
        }*/


        
    }
}