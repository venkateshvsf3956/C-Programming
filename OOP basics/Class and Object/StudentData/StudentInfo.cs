using System;

namespace StudentData
{
    public static class StudentInfo
    {
        public static int RegisterNumber;
        public static string Name { get; set; }

        static StudentInfo()
        {
            RegisterNumber=100;
            Name="venkatesh";

        }
        public static void display()
        {
            System.Console.WriteLine("Register Name:"+RegisterNumber);
            System.Console.WriteLine("Name:" +Name);
        }
     
        
    }
}