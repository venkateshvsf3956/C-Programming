namespace Question1
{
    public enum Department{Default,CSE,EEE,ECE,MECH};
    public class StudentInfo:PersonalInfo
    {
       private static int s_Id=1000;
       public String StudentId { get; set; } 
       public Department  Department { get; set; }
       public String Year { get; set; }
       public StudentInfo(string aid,string name,string fatherName,Gender gender,long phone,Department department,string year):base( aid, name,fatherName,gender,phone)
       {
        s_Id++;
        StudentId="SID"+s_Id;
        Department=department;
        Year=year;
       }
       public void ShowStudent()
       {
        System.Console.WriteLine("Student Id:"+StudentId);
        ShowDetail();
        System.Console.WriteLine("Department:"+Department);
        System.Console.WriteLine("Year"+Year);
       }

    }
}