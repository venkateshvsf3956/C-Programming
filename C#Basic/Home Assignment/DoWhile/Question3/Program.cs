using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range number:");
        int input =int.Parse(Console.ReadLine());
        int i=1;
        int j=1;
        int k;
        System.Console.WriteLine(i);
        do
        {
            System.Console.WriteLine(i);
            k=i+j;
            j=i;
            i=k;

        }while(i<=input);

    }
}
