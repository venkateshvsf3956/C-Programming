using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string");
        string str=Console.ReadLine();
        string sum="";
        for (int i=0;i<=str.Length-1;i++)
        {
            if ((str[i]=='1')||(str[i]=='2')||(str[i]=='3')||(str[i]=='4')||(str[i]=='5')||(str[i]=='6')||(str[i]=='7')||(str[i]=='8')||(str[i]=='9')||(str[i]=='0'))
            {
                sum=sum+str[i];

            }
        }
        int num=Convert.ToInt32(sum);
        if (num%2==0)
        {
            System.Console.WriteLine($"{num} is a even number");
        }
        else
        {
            System.Console.WriteLine("Its is odd number");
        }
    }
}