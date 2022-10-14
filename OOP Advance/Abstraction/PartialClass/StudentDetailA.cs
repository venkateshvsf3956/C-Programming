namespace PartialClass
{
    public partial class StudentDetail
    {
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
        
        
    }
}