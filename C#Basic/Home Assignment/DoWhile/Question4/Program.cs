using System;
namespace WhileLoop;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the validate number:");
        int number;
        bool v=int.TryParse(Console.ReadLine(),out number);
        
     
    
        do
        {
            
            System.Console.WriteLine("Please,Enter a Valid number");
            string input =Console.ReadLine();
            v =int.TryParse(input,out number);//loop changer
            
            
        }while(!v);
        if (number<=10)
        {
            System.Console.WriteLine($"The validate number {number}");
        }
        
    }
}
