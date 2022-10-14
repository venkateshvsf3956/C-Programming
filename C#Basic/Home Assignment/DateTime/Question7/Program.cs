using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        
        DateTime date1=new DateTime(2016,8,1,0,0,0);
        DateTime date2= new DateTime(2016,8,1,12,0,0);
        int output=DateTime.Compare(date1,date2);
        if (output<0)
        {
            System.Console.WriteLine($"{date1} is earlier than {date2}");
        }
        else if (output==0)
        {
            System.Console.WriteLine($"{date1} is the same time as {date2}");
        }
        else
        {
            System.Console.WriteLine($"{date1} is later than {date2}");
        }
    }
}