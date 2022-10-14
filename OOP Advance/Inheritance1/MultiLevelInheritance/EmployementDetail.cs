using System;
namespace MultiLevelInheritance
{
    public class EmployementDetail:StudentDetails
    {
        private static int s_employeeId=100;
        public string EmployeeId { get; set; }
        public DateTime  Date { get; set; }
        public EmployementDetail(string studentId,string aid,string name,string fatherName,Gender gender,long phone,Department department):base(studentId,aid,name,fatherName,gender,phone,department)
        {
            s_employeeId++;
            EmployeeId="EID"+s_employeeId;
            Date=DateTime.Now;
        }
        public void ShowEmploymentDetail()
        {
            
            System.Console.WriteLine("Employement Id:"+EmployeeId);
            ShowStudent();
            System.Console.WriteLine("Registration date:"+Date.ToString("dd/MM/yyyy"));
        }
    }
}