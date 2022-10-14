using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Customer id:");
        int id=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Customer name:");
        string name=Console.ReadLine();
        
        System.Console.WriteLine("Enter the usage unit of current:");
        int unit=Convert.ToInt32(Console.ReadLine());

        if ((unit>=84)&&(unit<200))
        {
            System.Console.WriteLine($"Amount charges @1.20 per unit:{unit*1.20}");
        }
        else if ((unit>=200) && (unit<400))
        {
            System.Console.WriteLine($"Amount charges @1.50 per unit;{unit*1.50}");
        }
        else if ((unit>=400) && (unit<600))
        {
            double percent= (double)unit*1.80;
            double surchage=percent*0.15;
            System.Console.WriteLine($"Amount charges @1.80 per unit: {percent}");
            System.Console.WriteLine($"Surchage amount: {surchage}");
            System.Console.WriteLine($"Net amount paid by the customer: {percent+surchage}");


        }
        else if (unit<84)
        {
            System.Console.WriteLine("Net amount paid by the customer:100");
        }
        else
        {
            double percent1= (double)unit*2;
            double surchage1=percent1*0.15;
            System.Console.WriteLine($"Amount charges @1.80 per unit: {percent1}");
            System.Console.WriteLine($"Surchage amount: {surchage1}");
            System.Console.WriteLine($"Net amount paid by the customer: {percent1+surchage1}");
        }


    }
}
