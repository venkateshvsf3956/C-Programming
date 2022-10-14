using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter the number:");
        bool input=int.TryParse(Console.ReadLine(),out number);
        while(input!=true)
        {

        
                System.Console.WriteLine("Invalid input enter again");
                string i=Console.ReadLine();
                
                input=int.TryParse(i,out number);
                
        
        }
        System.Console.WriteLine("Its a valid number");
    }
}