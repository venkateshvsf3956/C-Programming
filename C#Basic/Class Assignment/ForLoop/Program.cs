using System;
namespace ForLoop;
class Program 
{
    public static void Main(string[] args)
    {
        for (int i=0;i<=25;i++)
        {
            if (i%2==0)
            {
                Console.WriteLine($"Even number:{i}");
            }
            
        }
        Console.WriteLine("Enter the initial number: ");
        int initial=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Final number; ");
        int final=Convert.ToInt32(Console.ReadLine());
        int sum=0;
       
        
        for (int i=initial;i<=final;i++)
        {
            
            int square=i*i;
            sum =sum+square;
        }
        Console.WriteLine($"Sum of Squares: {sum}");
    }
}
