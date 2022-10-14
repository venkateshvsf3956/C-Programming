using System;
namespace WhileLoop;
class Program 
{
    public static void Main(string[] args)
    {
        int i=0;
        while (i<=25)
        {
            
            if (i%2==0)
            {
                System.Console.WriteLine($"{i}");

            }
            i++;
            
        }
        System.Console.WriteLine("Enter the validate number:");
        int number;
        bool v=int.TryParse(Console.ReadLine(),out number);

     
        
        while (v!=true)
        {
            System.Console.WriteLine("Please,Enter a Valid number");
            string input =Console.ReadLine();
            v =int.TryParse(input,out number);//loop changer
            

        }
        System.Console.WriteLine("Its is a validate number");

    }
}
