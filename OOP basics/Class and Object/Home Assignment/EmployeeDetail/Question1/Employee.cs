using System;
namespace Question1
{
    public enum Gender{Default,Male ,Female,Transgender}
    public enum Location{Default,Madura,Eymard}
    public class Employee
    {
        private static int s_employeeId=1000;

        public string EmployeeId { get;}
        public string Name { get; set; }

        public string Role { get; set; }

        public Location location{get;set;}

        public string TeamName { get; set; }

        public DateTime DateofJoin { get; set; }

        public int MonthWorking { get; set; }

        public int LeaveTaken{get;set;}

        public Gender Gender{ get; set; }

        public Employee(string name,string role,Location location,string teamname,DateTime dateofjoin,int monthworking,int leavetaken,Gender gender)
        {
            s_employeeId++;
            EmployeeId="SF"+s_employeeId;
            Name=name;
            Role=role;
            TeamName=teamname;
            DateofJoin=dateofjoin;
            MonthWorking=monthworking;
            LeaveTaken=leavetaken;
            Gender=gender;
        }

        public void Salary()
        {
            
            System.Console.WriteLine("This month salary is:");
            int salary=MonthWorking*500;
            System.Console.WriteLine(salary);
        }
        public void ShowDetail()
        {
            System.Console.WriteLine("\n Employee detail\n");
            System.Console.WriteLine("Employee id:"+EmployeeId);
            System.Console.WriteLine("Employee Name:"+Name);
            System.Console.WriteLine("Role:"+Role);
            System.Console.WriteLine("Work Location"+location);
            System.Console.WriteLine("Team Name:"+TeamName);
            System.Console.WriteLine("Date of Joining:"+DateofJoin);
            System.Console.WriteLine("Number of working in month:"+MonthWorking);
            System.Console.WriteLine("Number of Leave taken :"+LeaveTaken);
        }
        

        
        

        
        
        
        
        
        
        
        
    }
}