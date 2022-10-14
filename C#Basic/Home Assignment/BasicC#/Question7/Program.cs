using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("a=");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("b= ");
        int b= Convert.ToInt32(Console.ReadLine());
        int c=a*a;
        int d=b*b;
        int e=2*a*b;
        int sum =c+d+e;
        Console.WriteLine($"(a+b)^2= {sum}");
    }
}
