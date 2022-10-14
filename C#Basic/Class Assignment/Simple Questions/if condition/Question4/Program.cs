using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month option:1.January,March,May,July,August,October,December. 2.Feburary . 3.April,June,September,November");
        int month=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the leave taken in a month");
        int leave=Convert.ToInt32(Console.ReadLine());
        switch (month)
        {
        case 1:
        {
            int s=(31-leave)*500;
            System.Console.WriteLine("Monthly salary:"+s);
            break;

        }
        case 2:
        {
            int f=(29-leave)*500;
            System.Console.WriteLine("Monthly salary:"+f);
            break;
        }
        case 3:
        {
            int r=(30-leave)*500;
            System.Console.WriteLine("Mothly salary:"+r);
            break;
        }
        default:
        {
            System.Console.WriteLine("Enter the correct option");
            break;
        }
        }
    }
}
