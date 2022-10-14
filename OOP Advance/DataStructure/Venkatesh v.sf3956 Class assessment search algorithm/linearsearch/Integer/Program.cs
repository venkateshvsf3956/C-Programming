using System;
namespace Integer;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input:");
        int input=int.Parse(Console.ReadLine());
        int [] arr={1,2,3,4,5,6,7,8,9,10};
        int flag=0;
        int length=arr.Length;
        for (int i=0;i<length;i++)
        {
            if (arr[i]==input)
            {
                flag=1;
                System.Console.WriteLine("Element are present in the array:"+arr[i]);
                
            }
        }
        if (flag==0)
        {
            System.Console.WriteLine("element are not present in array");
           
        } 
        

    }
}