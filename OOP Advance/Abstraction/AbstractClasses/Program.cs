using System;
namespace AbstractClasses;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("\n-------Syncfusion class---------\n");
        Syncfusion person1=new Syncfusion();
        person1.Name="Venkat";
        person1.Salary(2);
       // person1.Display();
       System.Console.WriteLine("\n-------TCS class -----------\n");
        Tcs person2=new Tcs();
        person2.Name="Vaithi";
        person2.Salary(4);
       // person2.Display();

        
    }
}