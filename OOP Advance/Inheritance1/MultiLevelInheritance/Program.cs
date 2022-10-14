using System;
namespace MultiLevelInheritance;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("\n--------Person detail-----\n");
       // List<PersonalDetail> personList=new List<PersonalDetail>();
        PersonalDetail person1=new PersonalDetail("Venkat","Vaithi",Gender.Male,9597019482);
       // personList.Add(person1);

        //foreach(PersonalDetail person in personList)
        //{
            person1.Show();
       // }
       System.Console.WriteLine("\n---------------Student Detail----------\n");
       StudentDetails student1=new StudentDetails("342258519482","venkat","Vaithi",Gender.Male,98765456789,Department.EEE,"final year");
       student1.ShowStudent();
       student1.GetMark(90,90,90);
       student1.ShowMark();
       student1.Calculate();


        System.Console.WriteLine("\n-------------Customer Detail-----------\n");
       CustomerDetails customer1=new CustomerDetails("343432343","Jose","vayavsy",Gender.Male,9876786767);
       customer1.ShowCustomer();
       customer1.Recharge();


        System.Console.WriteLine("\n---------Employement detial---------\n");
       EmployementDetail employee1=new EmployementDetail("sid100","342258519482","venkat","Vaithi",Gender.Male,98765456789,Department.EEE);
       employee1.ShowEmploymentDetail();
       
    }
}