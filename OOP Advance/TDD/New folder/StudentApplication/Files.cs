using System;

using System.IO;

namespace StudentApplication
{
    public static class Files
    {
        public static void Create()
        {

            //Student detail
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");

            }
            if (!File.Exists("College/StudentDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/StudentDetails.csv");
            }
            //Student Departmentdetail

            if (!File.Exists("College/DepartmentDetail.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/DepartmentDetail.csv");
            }
            //admission deatail

            if (!File.Exists("College/AdmissionDetail.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("College/AdmissionDetail.csv");
            }

        }
        public static void ReadFile()
        {
            //student detail csv
            string []students=File.ReadAllLines("College/StudentDetails.csv");
            foreach(string data in students)
            {
                StudentDetails student=new StudentDetails(data);
                Operation.studentList.Add(student);
            }
            //department detail
            string []department=File.ReadAllLines("College/DepartmentDetail.csv");
            foreach(string list in department)
            {
                DepartmentDetails department1=new DepartmentDetails(list);
                Operation.departmentList.Add(department1);

            }
            //Admission detail
            string []admission=File.ReadAllLines("College/AdmissionDetail.csv");
            foreach(string data in admission)
            {
                AdmissionDetails admissions=new AdmissionDetails(data);
                Operation.admissionList.Add(admissions);
            }
            
        }
        public static void WriteToFiles()
        {
            string [] studentDetails=new string[Operation.studentList.Count];
            for(int i=0;i<Operation.studentList.Count;i++)
            {
                studentDetails[i]=Operation.studentList[i].RegisterNumber+","+Operation.studentList[i].Name+","+Operation.studentList[i].FatherName+","+Operation.studentList[i].DOB.ToString("dd/MM/yyyy")+","+Operation.studentList[i].Gender+","+Operation.studentList[i].Physics+","+Operation.studentList[i].Chemistry+","+Operation.studentList[i].Maths;

            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);
            
            //Departdetails
            string [] departmentDetails=new string[Operation.departmentList.Count];
            for (int i=0;i<Operation.departmentList.Count;i++)
            {
                departmentDetails[i]=Operation.departmentList[i].DepartmentId+','+Operation.departmentList[i].DepartmentName+','+Operation.departmentList[i].NoOfSeats;

            }
            File.WriteAllLines("College/DepartmentDetail.csv",departmentDetails);

            //Admissiondetails
            string [] admissionDetails=new string [Operation.admissionList.Count];
            for (int i=0;i<Operation.admissionList.Count;i++)
            {
                admissionDetails[i]=Operation.admissionList[i].StudentId+','+Operation.admissionList[i].DepartmentId+','+Operation.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy")+','+Operation.admissionList[i].AdmissionStatus;
            }
            File.WriteAllLines("College/AdmissionDetail.csv",admissionDetails);
        }
        
    }
}