using System;
namespace BubbleSort;
class Program 
{
    public static void Main(string[] args)
    {
        int []arr={18,19,1,5,7,3,20};
        int temp=0;
        int length=arr.Length;
        for (int i=0;i<length-1;i++)
        {
            for (int j=0;j<length-1-i;j++)
            {
                if (arr[j]>arr[j+1])
                {
                    temp=arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;

                }
            }
        }
        for (int i=0;i<length-1;i++)
        {
            System.Console.WriteLine("The sorted array :"+arr[i]);
        }
    }
}