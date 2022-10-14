using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        int a1=5;
        int s=(2*2*2);
        double a2=(double)s/(1*2*3);
        double a3=(double)(s*2)/(1*2*3*4);
        double a4=(double)(s*2*2)/(1*2*3*4*5);
        double a5=(double)(s*s)/(1*2*3*4*5*6);
        double a6=(double)(s*s*2)/(1*2*3*4*5*6*7);
        double a7=(double)(s*s*2*2)/(1*2*3*4*5*6*7*8);
        double sum=a1+a2+a3+a4+a5+a6+a7;
        System.Console.WriteLine("output"+sum);
    }
}