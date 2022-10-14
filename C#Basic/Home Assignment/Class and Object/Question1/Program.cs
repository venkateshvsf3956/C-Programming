using System;
using System.Collections.Generic;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        List<Employee> EmployeeDetails=new List<Employee>();
        string create="";
        do{
            System.Console.WriteLine("Enter Employee Name:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter employee role:");
            string role=Console.ReadLine();
            System.Console.WriteLine("Work Location: Madura,Eymard");
            Location location=Enum.Parse<Location>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter team name:");
            string teamname=Console.ReadLine();
            System.Console.WriteLine("Enter date of joinig(dd/MM/yyy):");
            DateTime dateofjoin=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("No of working days in month:");
            int monthworking=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Number of days Leave taken:");
            int leavetaken=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

            Employee person=new Employee(name,role,location,teamname,dateofjoin,monthworking,leavetaken,gender);
            EmployeeDetails.Add(person);

            System.Console.WriteLine("Are you want to create another account:'yes' or 'no'");
            create=Console.ReadLine().ToLower();



        }while (create=="yes");

        foreach(Employee detail in EmployeeDetails)
        {
            System.Console.WriteLine("\n Employee detail\n");
            System.Console.WriteLine("Employee id:"+detail.EmployeeId);
            System.Console.WriteLine("Employee Name:"+detail.Name);
            System.Console.WriteLine("Role:"+detail.Role);
            System.Console.WriteLine("Work Location"+detail.location);
            System.Console.WriteLine("Team Name:"+detail.TeamName);
            System.Console.WriteLine("Date of Joining:"+detail.DateofJoin);
            System.Console.WriteLine("Number of working in month:"+detail.MonthWorking);
            System.Console.WriteLine("Number of Leave taken :"+detail.LeaveTaken);
            detail.Salary();
        }
    }
}