using System;
using System.Collections.Generic;
namespace CollegeAdmission1
{
    public static class Operations
    {
        static StudentDetail currentStudent=null;
        static List<StudentDetail> studentList=new List<StudentDetail>();
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
        System.Console.WriteLine("Enter your name:");
        string name=Console.ReadLine();
        

        System.Console.WriteLine("Enter your Father name:");
        string fathername=Console.ReadLine();
        System.Console.WriteLine("Enter your dob (dd/MM/yyyy): ");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter Gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine("Enter phone number:");
        long phone=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your mail Id:");
        string mail=Console.ReadLine();
        System.Console.WriteLine("Enter your physics mark:");
        int physics=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your Maths mark:");
        int maths=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter your Chemistry mark:");
        int chemistry=Convert.ToInt32(Console.ReadLine());

        StudentDetail student1=new StudentDetail(name,fathername,dob,gender,mail,phone,physics,maths,chemistry);
        
        studentList.Add(student1);
        System.Console.WriteLine(student1.RegisterNumber);
        }

        public static void Login()
        {
            System.Console.WriteLine("Enter your Register Number");
            string registerNumber=Console.ReadLine().ToUpper();

            foreach (StudentDetail student in studentList)
            {
                if (student.RegisterNumber==registerNumber)
                {
                    System.Console.WriteLine("login successful\n");
                    currentStudent=student;
                    SuBMenu();
                    
                }
            }
        }
        public static void SuBMenu()
        {
            
            string choice="yes";
            do{
                System.Console.WriteLine("Enter the option: \n1.Show Detail \n2.Show Eligibility \n3.Exit");
            int show=int.Parse(Console.ReadLine());
            switch (show)
            {
                case 1:
                {
                    System.Console.WriteLine("Details:");
                    currentStudent.ShowDetail();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Check Eligibilty");
                    bool eligible=currentStudent.CheckEligibility(75.0);
                    if (eligible)
                    {
                    System.Console.WriteLine("You are eligible for admission");
                    }
                    else{
                    System.Console.WriteLine("You are not eligible for admission");
                    }
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    choice="no";
                    break;
                }
            }
            }while(choice=="yes");
        }

    }
}