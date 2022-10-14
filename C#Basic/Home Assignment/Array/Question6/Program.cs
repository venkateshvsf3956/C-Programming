using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of array:");
        int input=int.Parse(Console.ReadLine());

        int [] array=new int[100];
        int i,j,temp;
        System.Console.WriteLine($"Give {input} element in an array");
        for (i=0;i<input;i++)
        {
            System.Console.WriteLine("element-{0}",i+1);
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        for(i=0;i<input;i++)
        {
            for (j=i+1;j<input;j++)
            {
                if (array[j]<array[i])
                {
                    temp=array[i];
                    array[i]=array[j];
                    array[j]=temp;

                }
            }
            
        }
        
        System.Console.WriteLine("Soretd array:");
        for (i=0;i<input;i++)
        {
            System.Console.WriteLine(array[i]);
        }
    }
}
