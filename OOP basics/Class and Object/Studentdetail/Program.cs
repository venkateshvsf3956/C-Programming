using System;
namespace FirstAssignment;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Student Name: ");
        string sName=Console.ReadLine();

        Console.WriteLine("Father Name: ");
        string fName=Console.ReadLine();

        Console.WriteLine("email Id : ");
        string emailId=Console.ReadLine();

        Console.WriteLine("Phone number :");
        ulong phNumber=Convert.ToUInt64(Console.ReadLine());

        Console.WriteLine("age :");
        int age=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("gender :");
        string gender=Console.ReadLine();

        Console.WriteLine("Chemistry Mark: ");
        int chem=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Physics Mark: ");
        int phy=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Maths Mark: ");
        int math=Convert.ToInt32(Console.ReadLine());

        int average=(chem+phy+math)/3;
        Console.WriteLine($"Average :{average}");

        int percentage=average/2;
        Console.WriteLine($"Percentage :{percentage}");

        Console.WriteLine($"Name: {sName} ,Father Name:{fName} ,Email Id:{emailId} ,Phone Number: {phNumber} ,Age: {age}, gender:{gender} , Average mark:{average} ,Percenatge:{percentage}");


    }
}