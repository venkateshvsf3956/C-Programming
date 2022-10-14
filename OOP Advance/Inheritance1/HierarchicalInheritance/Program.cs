using System;
namespace HierarchicalInheritance;
class Program 
{
    public static void Main(string[] args)
    {
       // List<PersonalDetail> personList=new List<PersonalDetail>();
        PersonalDetail person1=new PersonalDetail("Venkat","Vaithi",Gender.Male,9597019482);
       // personList.Add(person1);

        //foreach(PersonalDetail person in personList)
        //{
            person1.Show();
       // }
       StudentDetails student1=new StudentDetails("342258519482","venkat","Vaithi",Gender.Male,98765456789,Department.EEE,"final year");
       student1.ShowStudent();

       CustomerDetails customer1=new CustomerDetails("343432343","Jose","vayavsy",Gender.Male,9876786767);
       customer1.Recharge();
       customer1.ShowCustomer();
       
    }
}