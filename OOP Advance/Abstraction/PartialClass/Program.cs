using System;
namespace PartialClass;
class Program 
{
    public static void Main(string[] args)
    {
        StudentDetail obj=new StudentDetail("venkat","vaithi",new DateTime(2000,08,31),Gender.Male,"qsgdwuyg",098765,90,90,90);
        obj.CheckEligibility(75.0);
        obj.ShowDetail();
    }
}
