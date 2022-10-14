using System;
namespace Question13;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string");
        string str=Console.ReadLine();
        int sum=0;
        System.Console.WriteLine(str[1]);
        for (int i=0;i<=str.Length-1;i++)
        {
            if ((str[i]=='1')||(str[i]=='2')||(str[i]=='3')||(str[i]=='4')||(str[i]=='5')||(str[i]=='6')||(str[i]=='7')||(str[i]=='8')||(str[i]=='9')||(str[i]=='0'))
            {
                int j=Convert.ToInt32(str[i]);
                sum=sum+j;


            }
        }
        System.Console.WriteLine(sum);
        
    }
}
