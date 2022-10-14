using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string ");
        string str=Console.ReadLine();
        int l=str.Length;
        int alp=0;
        int dig=0;
        int spl=0;
        int i=0;
        while(i<l)
        {
            if ((str[i]>='a' && str[i]<='z')||(str[i]>='A' &&str[i]<='Z'))
            {
                alp++;
            }
            else if(str[i]>='0'&&str[i]<='9')
            {
                dig++;
            }
            else{
                spl++;
            }
            i++;
        }
        System.Console.WriteLine($"Digit:{dig}");
        System.Console.WriteLine($"Alphabet:{alp}");
        System.Console.WriteLine($"special charcter:{spl}");

    }
}