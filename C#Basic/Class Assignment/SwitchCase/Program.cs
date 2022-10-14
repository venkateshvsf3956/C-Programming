using System;
namespace Switchcase;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int b=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("Enter your symbol for calculation:+,-,*,/,%");
        char symbol=Convert.ToChar(Console.ReadLine());

        switch(symbol)
        {
            case '+':
            {
                Console.WriteLine($"Added value:{a+b}");
                break;
            }
            case '-':
            {
                Console.WriteLine($"Substacted value:{a-b}");
                break;
            }
            case '*':
            {
                Console.WriteLine($"Multiplied vaule:{a*b}");
                break;
            }
            case '/':
            {
                Console.WriteLine($"Divide value:{a/b}");
                break;
            }
            case '%':
            {
                Console.WriteLine($"Modulo divided value:{a%b}");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid syntax");
                break;
            
            }
        }
    }
}
