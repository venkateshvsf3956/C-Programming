using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string:");
        string str=Console.ReadLine();
        int l=str.Length;
        char[] array=str.ToCharArray(0,l);
        System.Console.WriteLine("input position:");
        int pos=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Length of substring:");
        int len =Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("The substring Retrieve:");
        int i=1;
        while(i<len)
        {
            System.Console.Write(array[pos+i-1]);
            i++;
        }
        System.Console.WriteLine();

    }
}