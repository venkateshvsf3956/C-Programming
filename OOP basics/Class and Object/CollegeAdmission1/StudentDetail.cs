using System;
/// <summary>
/// used to process the college admission this application
/// </summary>
namespace CollegeAdmission1
{
    /// <summary>
    /// used to select a student gender information
    /// </summary>
    public enum Gender{Default,Male,Female,Transgender}

    /// <summary>
    ///  class <see cref="StudentDetail"/>used to collect student's information
    /// </summary>


    public class StudentDetail
    {
       // private string _name;//field declaration

       // public string Name { get{return _name;} set{_name=value;} }
        //public string Name1{ get{return _name;}}

        /// <summary>
        /// Static feild used to auto increment and only used in class.
        /// </summary>
        
        private static int s_registernumber=3000;
        /// <summary>
        /// Property Register number used to provide a number to the student.class <see cref="RegisterNumber"/>
        /// </summary>
        
        public string RegisterNumber { get; }
        /// <summary>
        /// Property Name used to provide a name to the  student.<see cref="Name"/>
        /// </summary>
        
        
        public string Name { get; set; }// Auto Property
        /// <summary>
        /// Property Fathername used to provide a father name to the name of that student.<see cref="FatherName"/>
        /// </summary>
      
         
        public string FatherName { get; set; }
        /// <summary>
        /// Property DOB used to provide a the birth date of that student.<see cref="DOB"/>
        /// </summary>
       

        public DateTime DOB { get; set; }
        /// <summary>
        /// Property Gender used to provide the gender of that student.<see cref="Gender"/>
        /// </summary>
      

        public Gender Gender { get; set; }
        /// <summary>
        /// Property Phone used to provide the Phone number of that student.<see cref="Phone"/>
        /// </summary>
        

        public long Phone { get; set; }
        /// <summary>
        /// Property Mail used to provide the mail id of that student.<see cref="Mail"/>
        /// </summary>
        
        
        public string Mail { get; set; }
        /// <summary>
        /// Property Physics used to provide the Physics markof that student.<see cref="Physics"/>
        /// </summary>
       
         
        public int Physics { get; set; }
        /// <summary>
        /// Property Chemistry used to provide the chemistry markof that student.<see cref="Chemistry"/>
        /// </summary>
       

        public int Chemistry { get; set; }
        /// <summary>
        /// Property Maths used to provide the Mathematics markof that student.<see cref="Maths"?>
        /// </summary>
       

        public int Maths { get; set; }

       
        // Paramterized Construtor
        /// <summary>
        /// Constructor <see cref="StudentDetail"/>To initalize the data of the student
        /// </summary>
        /// <param name="name"></param>To initalize the name of the student
        /// <param name="fathername"></param>To initalize the fathername of the student
        /// <param name="dob"></param>To initalize the data of birth of the student
        /// <param name="gender"></param>To initalize the gender of the student
        /// <param name="mail"></param>To initalize the mail of the student
        /// <param name="phone"></param>To initalize the phone number of the student
        /// <param name="physics"></param>To initalize the physics mark of the student
        /// <param name="maths"></param>To initalize the maths mark of the student
        /// <param name="chemistry"></param>To initalize the chemistry mark of the student
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
        /// <summary>
        /// Methods <see cref="CheckEligibility"/> used to check eligility to admission
        /// </summary>
        /// <param name="cutoff"></param>
        /// <returns> It is used check the eligibility of the student</returns>
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
        /// <summary>
        /// Methods<see cref="ShowDetail"/>used to show the detail
        /// </summary>
        public void ShowDetail()
        {
        System.Console.WriteLine("\nStudent detail are:\n");
        System.Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nDate of Birth: {DOB} \nGender: {Gender}\nPhone Number: {Phone}");
        System.Console.WriteLine($"Email ID :{Mail}" );
        System.Console.WriteLine($"Physics mark: {Physics}");
        System.Console.WriteLine($"Maths mark:{Maths}");
        System.Console.WriteLine($"Chemistry mark:{Chemistry}");
        }
        ~StudentDetail()
        {

        }

        
    }
}