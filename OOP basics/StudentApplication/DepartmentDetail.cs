namespace StudentApplication
{
    
    public class DepartmentDetails
    {// feild
    
        private static int s_departmentId=100;
        //property
        public string DepartmentId{get;}
        public string DepartmentName { get; set; }
        public int NoOfSeats { get; set; }
        
        //constructor
        public DepartmentDetails(string departmentName,int numberOfSeats)
        {
            s_departmentId++;
            DepartmentId="DID"+s_departmentId;
            DepartmentName=departmentName;
            NoOfSeats=numberOfSeats;


        }
        
    }
}