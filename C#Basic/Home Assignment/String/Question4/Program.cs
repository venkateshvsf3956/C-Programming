using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string ");
        string str=Console.ReadLine();
        int l=0;
        int w=1;
        while (l<=str.Length-1)
        {
            if (str[l]==' ')
            {
                w++;
            }
            l++;
        }
        System.Console.WriteLine($"Total count of word in string {w}:");
    }
}
