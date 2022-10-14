using System;
namespace Switchcase;
class Program 
{
    public static void Main(string[] args)
    {

        Console.WriteLine ("Enter a grade option:E-Excellent, V-very good ,G-good ,A-Average,F-Fail." );
        char letter=Convert.ToChar(Console.ReadLine());

        switch(letter)
        {
            case 'E':
            {
                Console.WriteLine("Execellent");
                break;
            }
            case 'V':
            {
                Console.WriteLine("Very Good");
                break;
            }
            case 'G':
            {
                Console.WriteLine("Good");
                break;
            }
            case 'A':
            {
                Console.WriteLine("Average");
                break;
            }
            case 'F':
            {
                Console.WriteLine("Fail");
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
