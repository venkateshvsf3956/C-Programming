using System;
namespace AdmissionLibrary
{
    public enum Gender{Default,Male,Female,Transgender}
    public class StudentDetail
    {
      
        
        private static int s_registernumber=3000;
        public string RegisterNumber { get; }
        
        
        public string Name { get; set; }// Auto Property
         
        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public Gender Gender { get; set; }

        public long Phone { get; set; }
        
        public string Mail { get; set; }
         
        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }

       
        // Paramterized Construtor
        public StudentDetail(string name,string fathername,DateTime dob,Gender gender,string mail,long phone,int physics,int maths,int chemistry)
        {
            s_registernumber++;
            RegisterNumber="SF"+s_registernumber;
            Name=name;
            FatherName=fathername;
            DOB=dob;
            Gender=gender;
            Mail=mail;
            Phone=phone;
            Physics=physics;
            Maths=maths;
            Chemistry=chemistry;

        }
        //method
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
        ~StudentDetail()
        {

        }

        
    }
}