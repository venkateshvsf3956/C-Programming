using System;
/// <summary>
/// used to process the college admission this application
/// </summary>
namespace PartialClass
{
    /// <summary>
    /// used to select a student gender information
    /// </summary>
    public enum Gender{Default,Male,Female,Transgender}

    /// <summary>
    ///  class <see cref="StudentDetail"/>used to collect student's information
    /// </summary>


    public partial class StudentDetail
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

       
        
        ~StudentDetail()
        {

        }

        
    }
}