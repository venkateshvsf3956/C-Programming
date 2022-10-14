using System;
namespace Character;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the character:");
        char input=char.Parse(Console.ReadLine());
        char [] arr={'a','b','c','d','e'};
        int length=arr.Length;
        int flag=0;
        for (int i=0;i<length;i++)
        {
            if (arr[i]==input)
            {
                flag=1;
                System.Console.WriteLine("Element are present in array:"+arr[i]);
            }

        }
        if (flag==0)
        {
            System.Console.WriteLine("Element are not present in array");
        }
    }
}