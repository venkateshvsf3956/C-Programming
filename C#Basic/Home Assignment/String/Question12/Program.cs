using System;
namespace Question12;
class Program 
{
    public static void Main(string[] args)
    {
        string str= " 349021";
        int i=Convert.ToInt32(str);
        System.Console.WriteLine(i);
        int [] input=new int [str.Length];
        System.Console.WriteLine(input[4]);
        int max=input[0];
        int min=input[0];
        for (int j=1;j<input.Length-1;i++)
        {
            if (input[j]>max)
            {
                max=input[j];

            }
            else if (input[j]<min)
            {
                min=input[j];
            }
        }
        System.Console.WriteLine(max);




    }
}