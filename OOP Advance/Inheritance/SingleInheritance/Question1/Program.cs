using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("\n----------Student Detail----------");
        StudentInfo student1=new StudentInfo("342258519482","venkat","Vaithi",Gender.Male,98765456789,Department.EEE,"final year");
       student1.ShowStudent();
    }
}