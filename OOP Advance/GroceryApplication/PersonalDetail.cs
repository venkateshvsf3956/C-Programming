using System;
namespace Assessment
{
    public enum Gender{Default,Male,Female}
    public class PersonalDetail
    {

        public string  Name { get; set; }
        public string  FatherName{ get; set; }
        public Gender  Gender { get; set; }
        public long MobileNumber { get; set; }
        public DateTime DateOfBirth{get;set;}
        public string MailId{get;set;}

        public PersonalDetail(string name,string fatherName,Gender gender,long mobileNumber,DateTime dateOfBirth,string mailId)
        {

            Name=name;
            fatherName=FatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
            DateOfBirth=dateOfBirth;
            MailId=mailId;
        }
        public PersonalDetail(string data,string name,string fatherName,Gender gender,long mobileNumber,DateTime dateOfBirth,string mailId)
        {

            Name=name;
            fatherName=FatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
            DateOfBirth=dateOfBirth;
            MailId=mailId;
            
        }
        public PersonalDetail()
        {
          
        }


    }
}