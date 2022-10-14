using System;
namespace DateTime1;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime dob = new DateTime(2021,8,10,10,40,32);
        System.Console.WriteLine("Year:"+dob.Year);
        System.Console.WriteLine("Month:"+dob.Month);
        System.Console.WriteLine("Day:"+dob.Day);
        System.Console.WriteLine("Hour:"+dob.Hour);
        System.Console.WriteLine("Minute:"+dob.Minute);
        System.Console.WriteLine("Seconds:"+dob.Second);

        string str=dob.ToString();
        string[] s=str.Split('/',':',' ');
        for (int i=s.Len)
        System.Console.WriteLine(s);
        System.Console.WriteLine(str);


        
    }
}
