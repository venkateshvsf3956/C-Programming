using System;
namespace DoWhile;
class Program 
{
    public static void Main(string[] args)
    {
        
        string condition="";
        
        do{
            
            System.Console.WriteLine("Enter the number:");
            int input=int.Parse(Console.ReadLine());
            if (input%2==0)
            {
                System.Console.WriteLine("Its a even number");
            }
            else 
            {
                System.Console.WriteLine("Its a Odd number");
            }
            System.Console.WriteLine("If you check another another .Please, enter 'yes' or 'no'");
            condition=Console.ReadLine().ToLower();
            while ((condition!="no")&&(condition!="yes"))
            {
                System.Console.WriteLine("Give a correct statement");
                System.Console.WriteLine("If you check another another .Please, enter 'yes' or 'no'");
                condition=Console.ReadLine().ToLower();

            }
            

        }while(condition=="yes");
    }
}
