using System;
namespace Question7;
class Progam 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string:");
        string str=Console.ReadLine();
        int v=0;
        int c=0;
        int l=str.Length;
        for (int i=0;i<l;i++)
        {
            if (str[i]=='a' ||str[i]=='e' ||str[i]=='i'||str[i]=='o'||str[i]=='u')
            {
                v++;
            }
            else if ((str[i]>='a'&&str[i]<='i')||str[i]>='A'&&str[i]<='Z')
            {
                c++;
            }
        }
        System.Console.WriteLine($"Vowel:{v}");
        System.Console.WriteLine($"Consonant:{c}");
    }
}
