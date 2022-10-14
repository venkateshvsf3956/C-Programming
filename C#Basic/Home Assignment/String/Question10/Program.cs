using System;
namespace Question10;
class Program 
{
    public static void Main(string[] args)
    {
        int c=0;
        string str,str2;
        do{
            System.Console.WriteLine("User name :");
            str=Console.ReadLine();
            System.Console.WriteLine("password:");
            str2=Console.ReadLine();
            if (str!="abcd"|| str2!="1234")
            {
                c++;

            }
            else{
                c=1;
            }
            
        }while((str!="abcd"|| str2!="1234")&&(c!=1));
        System.Console.WriteLine("Password entered succcessfully");

    }
}