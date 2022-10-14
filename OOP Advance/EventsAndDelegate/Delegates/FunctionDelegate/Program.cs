using System;
namespace FunctionDelegate;
class Program 
{
    public static double Sum(int a,int b)
    {
        return a+b;

    }
    public static double Substract(int a,int b)
    {
        return a-b;
    }
    public static double Calculator(Func<int,int,double>operation,int x,int y)
    {
        return operation(x,y);
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Addition: "+Calculator(Sum,10,20));
        System.Console.WriteLine("Substraction: "+Calculator(Substract,10,20));

    }
}