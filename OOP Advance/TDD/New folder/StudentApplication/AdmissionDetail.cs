using System;
namespace StudentApplication
{
    public enum AdmissionStatus{Default,Booked,Cancelled}
    public class AdmissionDetails
    {
        private static int s_admissionId=1000;

        //property
        public string  AdmissionId { get; set; }
        public string StudentId { get; set; }
        public string DepartmentId{ get; set; }
        public DateTime AdmissionDate { get; set; }
        
        public AdmissionStatus AdmissionStatus { get; set; }
        public AdmissionDetails(string studentId,String departmentId,DateTime admissionDate,AdmissionStatus admissionStatus)
        {
            s_admissionId++;
            AdmissionId="AD"+s_admissionId;
            StudentId=studentId;
            DepartmentId=departmentId;
            AdmissionDate=admissionDate;
            AdmissionStatus=admissionStatus;
        }
        public AdmissionDetails(string data)
        {
            string []values=data.Split(',');
            s_admissionId=int.Parse(values[0].Remove(0,2));
            StudentId=values[0];
            DepartmentId=values[1];
            AdmissionDate=DateTime.ParseExact(values[2],"dd/MM/yyyy",null);
            AdmissionStatus=Enum.Parse<AdmissionStatus>(values[3]);
        }

    }
}