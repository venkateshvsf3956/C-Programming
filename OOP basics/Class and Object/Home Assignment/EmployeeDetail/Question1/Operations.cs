using System;
using System.Collections.Generic;
namespace Question1;

    public static class Operations
    {
        static Employee currentemployee=null;
        static List<Employee> EmployeeDetails=new List<Employee>();
        public static void MainMenu()
        {
            string choice="yes";
            do{
            System.Console.WriteLine("Select option \n1.Registration \n2.Login \n3.Exit");
            int option=int.Parse(Console.ReadLine());
            

            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration\n");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Login\n");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit\n");
                    choice="no";
                    break;
                }
            }
            }while(choice=="yes");
        }

        public static void Registration()
        {
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
            System.Console.WriteLine("Employee Id:"+person.EmployeeId);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Employee Id  Number");
            string registerNumber=Console.ReadLine().ToUpper();

            foreach (Employee student in EmployeeDetails)
            {
                if (student.EmployeeId==registerNumber)
                {
                    System.Console.WriteLine("login successful\n");
                    currentemployee=student;
                    SuBMenu();
                    
                }
            }
        }
        public static void SuBMenu()
        {
            
            string choice="yes";
            do{
                System.Console.WriteLine("Enter the option: \n1.Show Detail \n2.Leave taken\n4.salary \n3.Exit");
            int show=int.Parse(Console.ReadLine());
            switch (show)
            {
                case 1:
                {
                    System.Console.WriteLine("Details:");
                    currentemployee.ShowDetail();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Leave Taken in month");
                    System.Console.WriteLine(currentemployee.LeaveTaken);
                   
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Salary:");
                    currentemployee.Salary();
                    break;

                }
                case 4:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            }while(choice=="yes");
        }



    }

        
        