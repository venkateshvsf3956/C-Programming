using System;
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
        public DepartmentDetails(string list)
        {
            string []values=list.Split(',');
            s_departmentId=int.Parse(values[0].Remove(0,3));
            DepartmentId=values[0];
            DepartmentName=values[1];
            NoOfSeats=int.Parse(values[2]);
        }
        
    }
}