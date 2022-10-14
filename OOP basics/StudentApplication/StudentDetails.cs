namespace StudentApplication
{
    public enum Gender {Default,Male,Female,Transgender}
    
    public class StudentDetails
    {
        private static int s_registerNumber=3000;

        public String RegisterNumber { get; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }

        public int Physics { get; set; }

        public int Chemistry{get; set;}

        public int Maths { get; set; }

        public StudentDetails(string name,string fatherName,DateTime dob,Gender gender,int physics,int chemistry,int maths)
        {
            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;

        }
        public bool CheckEligibility(double cutoff)
        {
            double average=(double)(Physics+Chemistry+Maths)/3.0;
            if (average>=cutoff)
            {
                return true;
            }
            else{
                return false;
            }
        }
        public void ShowDetail( )
        {
            //System.Console.WriteLine(s_registerNumber);
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("Father Name: "+FatherName);
            System.Console.WriteLine("Date of Birth:"+DOB);
            System.Console.WriteLine("Gender: "+Gender);
            System.Console.WriteLine("Physics mark: "+Physics);
            System.Console.WriteLine("Chemistry mark: "+Chemistry);
            System.Console.WriteLine("Maths mark: "+Maths);
        }
    }
}