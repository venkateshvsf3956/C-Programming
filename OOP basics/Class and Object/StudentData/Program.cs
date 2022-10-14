using System;
namespace StudentData;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo.display();
        StudentInfo.RegisterNumber=12;
        System.Console.WriteLine("Register Number:"+StudentInfo.RegisterNumber);
    }
}