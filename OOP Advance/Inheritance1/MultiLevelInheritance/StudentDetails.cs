using System;
namespace MultiLevelInheritance
{
    public enum Department{Default,CSE,EEE,ECE,MECH};
    public class StudentDetails:PersonalDetail,IMarkDetail
    {
       private static int s_studentId=1000;
       public String StudentId { get; set; } 
       public Department  Department { get; set; }
       public String Year { get; set; }
       
       public int Physics { get; set; }// Propeerty declaration only allowed
        public int Chemistry { get; set; }
        public  int Maths { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }
        //No constrctor and object
       public StudentDetails(string aid,string name,string fatherName,Gender gender,long phone,Department department,string year):base( aid, name,fatherName,gender,phone)
       {
        s_studentId++;
        StudentId="SID"+s_studentId;
        Department=department;
        Year=year;
       }
        public StudentDetails(string studentId,string aid,string name,string fatherName,Gender gender,long phone,Department department):base( aid, name,fatherName,gender,phone)
       {
        StudentId=studentId;
        Department=department;
       }
       public void GetMark(int physics,int chemistry,int maths)
       {
        Physics=physics;
        Chemistry=chemistry;
        Maths=maths;
       }
       public void Calculate()
       {
        Total=Physics+Chemistry+Maths;
        Average=Total/3;
       }
       public void ShowMark()
       {
        System.Console.WriteLine($"Physcis Mark:{Physics} \nChemistry:{Chemistry} \nMaths:{Maths}");
        System.Console.WriteLine($"Total:{Total} \nAverage:{Average}");
       }
       public void ShowStudent()
       {
        
        System.Console.WriteLine("Student Id:"+StudentId);
        Show();
        System.Console.WriteLine("Department:"+Department);
        
       }

    }
}