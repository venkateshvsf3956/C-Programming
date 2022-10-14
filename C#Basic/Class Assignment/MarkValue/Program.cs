using System;
namespace MarkValue;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your mark:");
        int mark=Convert.ToInt32(Console.ReadLine());
        if (mark <=100)
        {
            if (mark<=100 && mark>80)
            {Console.WriteLine("Grade A");}
            if (mark<=80 && mark>60)
            {Console.WriteLine("Grade B");}
            if (mark<=60 && mark>35)
            {Console.WriteLine("Grade C");}
            if (mark<=35 && mark>=1)
            {Console.WriteLine("Grade d");}
            
        }
        else
            {Console.WriteLine("Inavlid syntax");}


    

    }
}
