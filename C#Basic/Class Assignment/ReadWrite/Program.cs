using System;
namespace ReadWrite;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("my name:");
        string myName=Console.ReadLine();
        Console.WriteLine("FatherName: ");
        string fatherName=Console.ReadLine();
        //concatination-to 8
        Console.WriteLine("my name:"+myName +"fathername:"+fatherName);
        //place Holder 
        Console.WriteLine("myname {0} fathename{1}",myName,fatherName);
        //interpolation
        Console.WriteLine($"myname:{myName},fathename:{fatherName}");

    }
}