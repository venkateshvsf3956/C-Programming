using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the First integer: ");
        int first=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Second integer: ");
        int second=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the option:1-Addition 2-Substraction 3-Multilplication 4-Division 5-exit");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine($"The addition of {first} and {second} is {first+second}");
                break;
            }
            case 2:
            {
                System.Console.WriteLine($"The Substraction of {first} and {second} is {first-second}");
                break;
            }
            case 3:
            {
                System.Console.WriteLine($"The Multiplication of {first} and {second} is {first*second}");
                break;
            }
            case 4:
            {
                System.Console.WriteLine($"The division of {first} and {second} is {first/second}");
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Exit");
                break;
            }
            default:
            {
                System.Console.WriteLine("Choose the correct option.");
                break;
            }
            
        }
    }
}
