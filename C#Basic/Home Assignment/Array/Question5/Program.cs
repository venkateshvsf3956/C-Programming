using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of array:");
        int input=int.Parse(Console.ReadLine());

        int [] array=new int[input];
        int i;
        int j=0;
        int k=0;
        int []even=new int[input];
        int []odd=new int[input];
        System.Console.WriteLine($"Give {input} element in an array");
        for (i=0;i<input;i++)
        {
            System.Console.WriteLine("element-{0}",i+1);
            array[i]=Convert.ToInt32(Console.ReadLine());
            if (array[i]%2==0)
            {
                even[j]=array[i];
                j++;
            }
            else{
                odd[k]=array[i];
                k++;

            }

        }
        System.Console.WriteLine("Even numbers:");
        for (i=0;i<j;i++)
        {
            System.Console.WriteLine(even[i]);
        }
        System.Console.WriteLine("odd Number:");
        for (i=0;i<k;i++)
        {
            System.Console.WriteLine(odd[i]);
        }
    }
}