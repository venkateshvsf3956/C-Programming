using System;
using AdmissionLibrary;
using System.Collections.Generic;
namespace AdmissionApplication;

public class Operations
{
    public static void MainMenu()
    {
        //File
        List<StudentDetail> studentList=new List<StudentDetail>();
        string willing="";

        do {

        
        System.Console.WriteLine("Enter your name");
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
        


        System.Console.WriteLine("Are you willing to join:'yes' or 'no' ");
        willing =Console.ReadLine().ToLower();

            

        }while(willing=="yes");

        

      
        
        foreach(StudentDetail student in studentList)
        {
        System.Console.WriteLine("\nStudent detail are:\n");
        System.Console.WriteLine($"Name: {student.Name} \nFatherName: {student.FatherName} \nDate of Birth: {student.DOB} \nGender: {student.Gender}\nPhone Number: {student.DOB}");
        System.Console.WriteLine($"Email ID :{student.Mail}" );
        System.Console.WriteLine($"Physics mark: {student.Physics}");
        System.Console.WriteLine($"Maths mark:{student.Maths}");
        System.Console.WriteLine($"Chemistry mark:{student.Chemistry}");
        bool eligible=student.CheckEligibility(75.0);
        if (eligible)
        {
            System.Console.WriteLine("You are eligible for admission");
        }
        else{
            System.Console.WriteLine("You are not eligible for admission");
        }
        System.Console.WriteLine("\n------------\n");

        }
        
        
        
    }
}