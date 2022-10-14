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

    }
}