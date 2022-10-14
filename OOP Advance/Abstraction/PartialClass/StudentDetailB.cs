namespace PartialClass
{
    public partial class StudentDetail
    {
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
        public void ShowDetail()
        {
        System.Console.WriteLine("\nStudent detail are:\n");
        System.Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nDate of Birth: {DOB} \nGender: {Gender}\nPhone Number: {Phone}");
        System.Console.WriteLine($"Email ID :{Mail}" );
        System.Console.WriteLine($"Physics mark: {Physics}");
        System.Console.WriteLine($"Maths mark:{Maths}");
        System.Console.WriteLine($"Chemistry mark:{Chemistry}");
        
        }
        
    }
}