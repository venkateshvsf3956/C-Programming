using System;
namespace Array;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of array:");
        int input=int.Parse(Console.ReadLine());
        int i;
        string [] names =new string[input];
        System.Console.WriteLine("Enter the name:");
        for (i=0;i<input;i++)
        {
            
            string name=Console.ReadLine().ToLower();
            names[i]=name;
            System.Console.WriteLine($"name:{names[i]}");
            
        }
        System.Console.WriteLine("Enter the name to search:");
        string search=Console.ReadLine().ToLower();
        int j;
        int temp=0;
        for (j=0;j<input;j++)
        {
            if (names[j]==search)
            {
                temp=1;
                System.Console.WriteLine($"The name is present in array. and The index value is {j}");
            }
           
        }
        if (temp==0)
        {
            System.Console.WriteLine("The name is not present in array");
        }
        int flag=0;
        foreach (string details in names)
        {
            if (details==search)
            {
                flag=1;
                System.Console.WriteLine("The name is present in array");
            }
            
        }
        if (flag==0)
        {
            System.Console.WriteLine("The name is not present in array");

        }
        

    }
}