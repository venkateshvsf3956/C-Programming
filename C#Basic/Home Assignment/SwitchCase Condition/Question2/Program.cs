using System;
namespace Switchcase;
class Program 
{
    public static void Main(string[] args)
    {

        Console.WriteLine ("Enter a day option:1-Monday, 2-Tuesday ,3-wednesday ,4-Thursday ,5-Friday,6-Saturday ,7-Sunday" );
        int day=Convert.ToInt32(Console.ReadLine());

        switch(day)
        {
            case 1:
            {
                Console.WriteLine("Monday");
                break;
            }
            case 2:
            {
                Console.WriteLine("Tuesday");
                break;
            }
            case 3:
            {
                Console.WriteLine("Wednesday");
                break;
            }
            case 4:
            {
                Console.WriteLine("Thursday");
                break;
            }
            case 5:
            {
                Console.WriteLine("Friday");
                break;
            }
            case 6:
            {
                Console.WriteLine("Saturday");
                break;
            }
            case 7:
            {
                Console.WriteLine("Sunday");
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