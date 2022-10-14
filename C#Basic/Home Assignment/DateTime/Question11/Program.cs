using System;
namespace Question11;
class Program 
{
    public static void Main(string[] args)
    {
        
        DateTime today=DateTime.Now;
        System.Console.WriteLine("today:",today.ToString("dd/MM/yyyy"));
        for (int i=0;i<12;i++)
        {
            System.Console.WriteLine(today.ToString("MMMM"));
            today=today.AddMonths(1);

        }
        System.Console.WriteLine();
    }
}