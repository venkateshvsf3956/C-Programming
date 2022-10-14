using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the option of cricket player of the country:1-India ,2-Pakistan ,3-Bangladesh");
        int input=int.Parse(Console.ReadLine());
        switch(input)
        {
            case 1:
            {
                System.Console.WriteLine("1.Dhoni");
                System.Console.WriteLine("2.Virat Kholi");
                System.Console.WriteLine("3.Suresh Raina");
                break;

            }
            case 2:
            {
                System.Console.WriteLine("1.Afridi");
                System.Console.WriteLine("2.salman");
                System.Console.WriteLine("3.Ameen");
                break;
            }
            case 3:
            {
                System.Console.WriteLine("1.Litton");
                System.Console.WriteLine("2.Tamim");
                System.Console.WriteLine("3.Rafique");
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