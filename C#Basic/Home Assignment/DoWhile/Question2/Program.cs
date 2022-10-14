using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number:");
        int input=int.Parse(Console.ReadLine());
        int sum=0;
        do{
            sum+=input;
            System.Console.WriteLine("Enter a number:");
            input=int.Parse(Console.ReadLine());
        
            if (input<0)
            {
                break;
            }

        }while(true);
        System.Console.WriteLine($"The sum is {sum}:");
    }
}