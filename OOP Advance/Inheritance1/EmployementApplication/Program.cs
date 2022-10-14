using System;
namespace EmployementApplication;
class Program 
{
    public static void Main(string[] args)
    {
       // List<PersonalDetail> personList=new List<PersonalDetail>();
        PersonalDetail person1=new PersonalDetail("Venkat","Vaithi",Gender.Male,9597019482);
       // personList.Add(person1);

        //foreach(PersonalDetail person in personList)
        //{
            person1.ShowDetail();
       // }
    }
}