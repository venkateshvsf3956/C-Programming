using System;
namespace String;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the bike name to search in the array:");
        string input =Console.ReadLine().ToLower();
        string [] arr={"r15","ducati","ninja","rc200","rx100","bmw","h2r"};
        int length=arr.Length;
        int flag=0;
        for (int i=0;i<length;i++)
        {
            if (arr[i]==input)
            {
                flag=1;
                System.Console.WriteLine("The bike name present in the array:"+arr[i]);
            }
        }
        if (flag==0)
        {
            System.Console.WriteLine("The bike are not present in array.");
        }
    }
}