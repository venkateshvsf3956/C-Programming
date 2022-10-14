using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number:");
        int value1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second number:");
        int value2=int.Parse(Console.ReadLine());
        Swap(value1,value2);

        void Swap(int input1,int input2)
        {
            int n;
            n=input1;
            input1=input2;
            input2=n;
            System.Console.WriteLine($"Now the first number is {input1} and the second number is {input2}");
            

        }
    }
}
